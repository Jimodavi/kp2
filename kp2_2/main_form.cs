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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Catalog_category_MenuItem_Click(object sender, EventArgs e)
        {
            //Catalog_category novoeokno = new Catalog_category();

            //if (novoeokno.ShowDialog(this) == DialogResult.OK)//новое окно tournaments_form
            //{
            //}
            //else { }
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "category_DataSet.Справочник_катерогий". При необходимости она может быть перемещена или удалена.
            this.справочник_катерогийTableAdapter.Fill(this.category_DataSet.Справочник_катерогий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kp2DataSet.Справочник_кортов". При необходимости она может быть перемещена или удалена.
            this.справочник_кортовTableAdapter.Fill(this.kp2DataSet.Справочник_кортов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tournaments_Dataset.Турниры". При необходимости она может быть перемещена или удалена.
            this.турнирыTableAdapter.Fill(this.tournaments_Dataset.Турниры);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
