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
    public partial class catalog_court_form : Form
    {
        private object old_value;
        public catalog_court_form()
        {
            InitializeComponent();
        }

        private void catalog_court_form_Load(object sender, EventArgs e)
        {
            /*загрузка данных кп2_DataSet*/
            this.Справочник_кортов_TableAdapter.Fill(this.кп2_DataSet.Справочник_кортов);
        }
        private void Справочник_кортов_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*удаление строки правой кнопкой мыши*/
            if (e.Button == MouseButtons.Right)
                if (MessageBox.Show("Удалить корт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Справочник_кортов_TableAdapter.Delete(code);
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
        }
        private void Справочник_кортов_DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            /*сохранение прежнего значения клетки для отмены изменений*/
            old_value = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void Справочник_кортов_DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*добавление пустой строки в БД*/
            ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value = кп2_DataSet.Next_DB_index("Код корта", "Справочник кортов");

            string newelement = "";
            newelement += ((DataGridView)sender).Rows[e.Row.Index - 1].Cells[0].Value.ToString();
            for (int i = 1; i < 3; i++)
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
            this.Справочник_кортов_TableAdapter.Insert(newelement);
        }
        private void Справочник_кортов_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*проверка ввода*/
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) return;

            /*запрос в БД*/
            string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            string newelement = "";
            newelement += "[" + кп2_DataSet.Tables["Справочник кортов"].Columns[e.ColumnIndex].ColumnName + "] = ";
            newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
            this.Справочник_кортов_TableAdapter.Update(newelement, code);
        }
        private void Справочник_кортов_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
    }
}