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
    public partial class catalog_system_form : Form
    {
        public catalog_system_form()
        {
            InitializeComponent();
        }

        private void catalog_system_form_Load(object sender, EventArgs e)
        {
            /*загрузка данных кп2_DataSet*/
            this.Справочник_систем_проведения_TableAdapter.Fill(this.кп2_DataSet.Справочник_систем_проведения);

        }
        private void Справочник_систем_проведения_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*проверка ввода*/
            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(DBNull.Value)) return;

            /*запрос в БД*/
            string code = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            string newelement = "";
            newelement += "[" + кп2_DataSet.Tables["Справочник систем проведения"].Columns[e.ColumnIndex].ColumnName + "] = ";
            newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'";
            this.Справочник_систем_проведения_TableAdapter.Update(newelement, code);
        }
        private void Справочник_систем_проведения_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный ввод", "Ошибка");
            return;
        }
    }
}
