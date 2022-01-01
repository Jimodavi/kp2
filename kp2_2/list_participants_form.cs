using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp2_2
{
    public partial class list_participants_form : Form
    {
        private int code_tournament;
        private object old_value;
        public list_participants_form(int code_tournament)
        {
            InitializeComponent();
            this.code_tournament = code_tournament;
        }

        private void list_participants_form_Load(object sender, EventArgs e)
        {
            /*загрузка данных кп2_DataSet*/
            this.Справочник_игроков_TableAdapter.Fill(this.кп2_DataSet.Справочник_игроков);
            this.Cписки_участников_TableAdapter.Fill(this.кп2_DataSet.Списки_участников, code_tournament.ToString());

            /*выключение Visisble для поля [Код игрока 2]*/
            if (main_form.Row_ref.Cells[5].EditedFormattedValue.ToString().Contains("диночный"))
            Списки_участников_DataGridView.Columns[3].Visible = false;
        }
        private void Списки_участников_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*удаление строки правой кнопкой мыши*/
            if (e.Button == MouseButtons.Right)
                if (MessageBox.Show("Удалить участника?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Cписки_участников_TableAdapter.Delete(code);
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
        }
        private void Списки_участников_DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            /*сохранение прежнего значения клетки для отмены изменений*/
            old_value = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void Списки_участников_DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*добавление пустой строки в БД*/
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value = кп2_DataSet.Next_DB_index("Код учаcтника", "Списки участников");

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
            this.Cписки_участников_TableAdapter.Insert(newelement);
        }
        private void Списки_участников_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*проверка ввода*/
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) return;
            object objectvalue;
            bool flag;
            try
            {
                switch (e.ColumnIndex)
                {
                    case 2:/*Код игрока 1*/

                    case 3:/*Код игрока 2*/
                        objectvalue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        flag = false;
                        for (int i = 0; (i < Списки_участников_DataGridView.RowCount - 1) && (!flag); i++)
                        {
                            if (Списки_участников_DataGridView.Rows[i].Cells[2].Value == objectvalue) flag = true;
                            if (Списки_участников_DataGridView.Rows[i].Cells[3].Value == objectvalue) flag = true;
                        }
                        if (flag)
                        {
                            MessageBox.Show("Этот игрок уже выбран для турнира", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                }

                /*запрос в БД*/
                string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                string newelement = "";
                newelement += "[" + кп2_DataSet.Tables["Списки участников"].Columns[e.ColumnIndex].ColumnName + "] = ";
                newelement += ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Cписки_участников_TableAdapter.Update(newelement, code);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Ошибка");
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                return;
            }
        }
        private void Списки_участников_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
    }
}
