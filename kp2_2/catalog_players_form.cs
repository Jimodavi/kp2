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
    public partial class catalog_players_form : Form
    {

        private object old_value;
        public catalog_players_form()
        {
            InitializeComponent();
        }

        private void catalog_players_form_Load(object sender, EventArgs e)
        {
            /*загрузка данных кп2_DataSet*/
            this.Справочник_игроков_TableAdapter.Fill(this.кп2_DataSet.Справочник_игроков);

        }
        private void Справочник_игроков_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*удаление строки правой кнопкой мыши*/
            if (e.Button == MouseButtons.Right)
                if (MessageBox.Show("Удалить игрока?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Справочник_игроков_TableAdapter.Delete(code);
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
        }
        private void Справочник_игроков_DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            /*сохранение прежнего значения клетки для отмены изменений*/
            old_value = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void Справочник_игроков_DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*добавление пустой строки в БД*/
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value = кп2_DataSet.Next_DB_index("Код игрока", "Справочник игроков");
            string newelement = ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value.ToString();
            for (int i = 1; i < 8; i++)
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
            this.Справочник_игроков_TableAdapter.Insert(newelement);
        }
        private void Справочник_игроков_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*проверка ввода*/
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) return;
            int intvalue;
            DateTime datetimevalue;
            string format_date = @"^[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]$";
            try
            {
                switch (e.ColumnIndex)
                {
                    case 4:/*Дата рождения*/
                        datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_date))
                        {
                            MessageBox.Show("Дата вводится в формате \"дд.мм.гггг\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 7:/*Рейтинг*/
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (intvalue < 0)
                        {
                            MessageBox.Show("Недомустимый рейтинг", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                }

                /*запрос в БД*/
                string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                string newelement = "";
                newelement += "[" + кп2_DataSet.Tables["Справочник игроков"].Columns[e.ColumnIndex].ColumnName + "] = ";
                if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name != "String")
                {
                    if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name == "DateTime") newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
                    else newelement += ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else
                {
                    newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
                }
                this.Справочник_игроков_TableAdapter.Update(newelement, code);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Ошибка");
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                return;
            }
        }
        private void Справочник_игроков_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
    }
}
