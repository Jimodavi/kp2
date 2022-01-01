using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace kp2_2
{
    public partial class schedule_form : Form
    {
        private int code_tournament;
        private object old_value;
        public schedule_form(int code_tournament)
        {
            InitializeComponent();
            this.code_tournament = code_tournament;
        }

        private void schedule_form_Load(object sender, EventArgs e)
        {
            /*загрузка данных кп2_DataSet*/
            this.Справочник_кортов_TableAdapter.Fill(this.кп2_DataSet.Справочник_кортов);
            this.Расписание_TableAdapter.Fill(this.кп2_DataSet.Расписание, code_tournament.ToString());
            this.Расписание_TableAdapter.Fill(this.кп2_DataSet.Расписание, code_tournament.ToString());
        }
        private void Расписание_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*удаление строки правой кнопкой мыши*/
            if (e.Button == MouseButtons.Right)
                if (MessageBox.Show("Удалить матч?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Расписание_TableAdapter.Delete(code);
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
        }
        private void Расписание_DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            /*сохранение прежнего значения клетки для отмены изменений*/
            old_value = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void Расписание_DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*добавление пустой строки в БД*/
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value = кп2_DataSet.Next_DB_index("Код матча", "Расписание");
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[1].Value = code_tournament;
            string newelement = "";
            newelement += ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value.ToString();
            newelement += ", " + ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[1].Value.ToString();
            for (int i = 2; i < 4; i++)
            {
                newelement += ", ";
                if (((DataGridView)sender).Rows[e.Row.Index - 1].Cells[i].ValueType.Name != "String")
                {
                    newelement += "null";

                }
                else
                {
                    newelement += "''";
                }
            }
            this.Расписание_TableAdapter.Insert(newelement);
        }
        private void Расписание_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*проверка ввода*/
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) return;
            int intvalue;
            bool flag;
            DateTime datetimevalue;
            string format_date_time = @"^[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9] [0-2][0-9]:[0-5][0-9]$";
            try
            {                
                switch (e.ColumnIndex)
                {
                    case 2:/*Корт*/
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        flag = true;
                        for (int i = 0; (i < 3)&&flag; i++) {
                            if (main_form.Row_ref.Cells[10 + i].Value != DBNull.Value)
                            if ((int)main_form.Row_ref.Cells[10 + i].Value == intvalue) flag = false;
                        }
                        if (flag)
                        {
                            MessageBox.Show("Этот корт не выбран для турнира", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                   
                    case 3:/*Время начала*/
                        datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_date_time))
                        {
                            MessageBox.Show("Дата вводится в формате \"дд.мм.гггг чч.мм\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                }

                /*запрос в БД*/
                string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                string newelement = "";
                newelement += "[" + кп2_DataSet.Tables["Расписание"].Columns[e.ColumnIndex].ColumnName + "] = ";
                if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name == "DateTime") newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
                else newelement += ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Расписание_TableAdapter.Update(newelement, code);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Ошибка");
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                return;
            }
        }
        private void Расписание_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
    }
}
