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
    public partial class main_form : Form
    {
        private int max_number_of_courts = 3;
        private int max_number_of_participants = 16;
        private object old_value;
        public static DataGridViewRow Row_ref;
        public main_form()
        {
            InitializeComponent();
        }


        private void main_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_кортов". При необходимости она может быть перемещена или удалена.
            this.Справочник_кортов_TableAdapter.Fill(this.кп2_DataSet.Справочник_кортов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_систем_проведения". При необходимости она может быть перемещена или удалена.
            this.Справочник_систем_проведения_TableAdapter.Fill(this.кп2_DataSet.Справочник_систем_проведения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_катерогий". При необходимости она может быть перемещена или удалена.
            this.Справочник_катерогий_TableAdapter.Fill(this.кп2_DataSet.Справочник_катерогий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Турниры". При необходимости она может быть перемещена или удалена.
            this.Турниры_TableAdapter.Fill(this.кп2_DataSet.Турниры);
            for (int i = 0; i < Турниры_DataGridView.RowCount -  1; i++)
            {
                /*[Количетсво групп] доступно в зависимости от [Код категории]*/
                try
                {
                    if ((int)Турниры_DataGridView.Rows[i].Cells[3].Value != 3) Турниры_DataGridView.Rows[i].Cells[6].ReadOnly = true;
                }
                catch (Exception) { Турниры_DataGridView.Rows[i].Cells[6].ReadOnly = true; }
                /*[Код корта] доступно в зависимости от [Количество кортов]*/
                try
                {
                    for (int j = max_number_of_courts; j > (int)Турниры_DataGridView.Rows[i].Cells[9].Value; j--) Турниры_DataGridView.Rows[i].Cells[9 + j].ReadOnly = true;
                }
                catch (Exception) { for (int j = max_number_of_courts; j > 0; j--) Турниры_DataGridView.Rows[i].Cells[9 + j].ReadOnly = true; }
                /*[Количество сеянных игроков] доступно в зависимости от [Количество игроков]*/
                if (Турниры_DataGridView.Rows[i].Cells[4].Value == DBNull.Value) Турниры_DataGridView.Rows[i].Cells[18].ReadOnly = true;
            }            
        }
        private void Турниры_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (MessageBox.Show("Удалить турнир?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Турниры_TableAdapter.Delete(code);
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
        }
        private void Турниры_DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            old_value = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void Турниры_DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*Добавление пустой строки в БД*/
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value = кп2_DataSet.Next_DB_index("Код турнира", "Турниры");

            string newelement = ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value.ToString();
            for (int i = 1; i < 19; i++)
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
            this.Турниры_TableAdapter.Insert(newelement);
            /*[Количетсво групп] доступно в зависимости от [Код категории]*/
            Турниры_DataGridView.Rows[e.Row.Index - 1].Cells[6].ReadOnly = true;
            /*[Код корта] доступно в зависимости от [Количество кортов]*/
            for (int j = 3; j > 0; j--) Турниры_DataGridView.Rows[e.Row.Index - 1].Cells[9 + j].ReadOnly = true;
            /*[Количество сеянных игроков] доступно в зависимости от [Количество игроков]*/
            Турниры_DataGridView.Rows[e.Row.Index - 1].Cells[18].ReadOnly = true;
        }
        private void Турниры_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) return;
            int intvalue;
            DateTime datetimevalue;
            string format_date = @"^[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]$";
            string format_time = @"^[0-2][0-9]:[0-5][0-9]$";
            try
            {
                /*проверка ввода*/
                switch (e.ColumnIndex)
                {
                    case 3:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (intvalue == 3) ((DataGridView)sender).Rows[e.RowIndex].Cells[6].ReadOnly = false;
                        else
                        {
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[6].ReadOnly = true;
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[6].Value = DBNull.Value;
                        }
                        break;
                    case 4:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if ((intvalue < 2) || (intvalue > max_number_of_participants))
                        {
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[18].ReadOnly = true;
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[18].Value = DBNull.Value;
                            MessageBox.Show("Недомустимое количество игроков", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[18].ReadOnly = false;
                        break;
                    case 6:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if ((intvalue < 1) || (intvalue > ((int)((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value) / 3))
                        {
                            MessageBox.Show("Недомустимое количество групп", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 7: datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_date))
                        {
                            MessageBox.Show("Дата вводится в формате \"дд.мм.гггг\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 8:
                        datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_date))
                        {
                            MessageBox.Show("Дата вводится в формате \"дд.мм.гггг\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        if ((DateTime)((DataGridView)sender)[e.RowIndex, e.ColumnIndex - 1].Value >= datetimevalue)
                        {
                            MessageBox.Show("Дата конца должна быть позже даты начала", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 9:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if ((intvalue < 1) || (intvalue > 3))
                        {
                            MessageBox.Show("Недомустимое количество кортов", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        for (int j = 0; j < max_number_of_courts; j++) {
                            if (j < intvalue) ((DataGridView)sender).Rows[e.RowIndex].Cells[10 + j].ReadOnly = false;
                            else {
                                ((DataGridView)sender).Rows[e.RowIndex].Cells[10 + j].ReadOnly = true;
                                ((DataGridView)sender).Rows[e.RowIndex].Cells[10 + j].Value = DBNull.Value;
                            }
                        }
                        break;
                    case 13:
                        datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_time))
                        {
                            MessageBox.Show("Время вводится в формате \"чч:мм\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 14:
                        datetimevalue = (DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (!Regex.IsMatch(((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), format_time))
                        {
                            MessageBox.Show("Время вводится в формате \"чч:мм\"", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        if ((DateTime)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value >= datetimevalue)
                        {
                            MessageBox.Show("Время конца должно быть позже времени начала", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 15:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if ((intvalue < 40) || (intvalue > 120))
                        {
                            MessageBox.Show("Недомустимая длительность матча", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                    case 18:
                        intvalue = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if ((intvalue < 0) || (intvalue > (int)((DataGridView)sender)[e.RowIndex, 4].Value))
                        {
                            MessageBox.Show("Недомустимок количество сеянных игроков", "Ошибка");
                            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                            return;
                        }
                        break;
                }
                /*запрос в БД*/
                string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                string newelement = "";
                newelement += "[" + кп2_DataSet.Tables["Турниры"].Columns[e.ColumnIndex].ColumnName + "] = ";
                if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name != "String")
                {
                    if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name == "DateTime") newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() + "'";
                    else newelement += ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else
                {
                    newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() + "'";
                }
                this.Турниры_TableAdapter.Update(newelement, code);
            }
            catch(Exception exeption){
                MessageBox.Show(exeption.Message, "Ошибка");
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
                return;
            }
        }
        private void Турниры_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
        private void Schedule_MenuItem_Click(object sender, EventArgs e)
        {
            if (Турниры_DataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите 1 турнир", "Ошибка");
                return;
            }
            schedule_form novoeokno = new schedule_form((int)(Турниры_DataGridView.SelectedRows[0].Cells[0].Value));
            Row_ref = Турниры_DataGridView.SelectedRows[0];

            if (novoeokno.ShowDialog(this) == DialogResult.OK)//новое окно schedule_form
            {
            }
            else { }
        }
        private void Catalog_category_MenuItem_Click(object sender, EventArgs e)
        {
            //Catalog_category novoeokno = new Catalog_category();

            //if (novoeokno.ShowDialog(this) == DialogResult.OK)//новое окно
            //{
            //}
            //else { }
        }
    }
}
