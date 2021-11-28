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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_кортов". При необходимости она может быть перемещена или удалена.
            this.Справочник_кортов_TableAdapter.Fill(this.кп2_DataSet.Справочник_кортов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_систем_проведения". При необходимости она может быть перемещена или удалена.
            this.Справочник_систем_проведения_TableAdapter.Fill(this.кп2_DataSet.Справочник_систем_проведения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_катерогий". При необходимости она может быть перемещена или удалена.
            this.Справочник_катерогий_TableAdapter.Fill(this.кп2_DataSet.Справочник_катерогий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Турниры". При необходимости она может быть перемещена или удалена.
            this.Турниры_TableAdapter.Fill(this.кп2_DataSet.Турниры);

        }

        private void Турниры_DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value < 0)
            {
                //Турниры_TableAdapter.Insert(/*((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value,*/
                //((DataGridView)sender).Rows[e.RowIndex].Cells[1].EditedFormattedValue == DBNull.Value ? "" : (string)((DataGridView)sender).Rows[e.RowIndex].Cells[1].EditedFormattedValue,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[5].EditedFormattedValue == DBNull.Value ? "" : (string)((DataGridView)sender).Rows[e.RowIndex].Cells[5].EditedFormattedValue,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[6].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[6].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[7].Value == DBNull.Value ? (System.DateTime?)null : (System.DateTime?)((DataGridView)sender).Rows[e.RowIndex].Cells[7].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[8].Value == DBNull.Value ? (System.DateTime?)null : (System.DateTime?)((DataGridView)sender).Rows[e.RowIndex].Cells[8].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[9].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[9].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[10].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[10].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[11].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[11].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[12].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[12].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[13].Value==DBNull.Value ? (System.DateTime?)null : (System.DateTime?)((DataGridView)sender).Rows[e.RowIndex].Cells[13].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[14].Value == DBNull.Value ? (System.DateTime?)null : (System.DateTime?)((DataGridView)sender).Rows[e.RowIndex].Cells[14].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[15].Value== DBNull.Value ?(int?)null: (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[15].Value,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[16].EditedFormattedValue == DBNull.Value ? "" : (string)((DataGridView)sender).Rows[e.RowIndex].Cells[16].EditedFormattedValue,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[17].EditedFormattedValue == DBNull.Value ? "" : (string)((DataGridView)sender).Rows[e.RowIndex].Cells[17].EditedFormattedValue,
                //((DataGridView)sender).Rows[e.RowIndex].Cells[18].Value == DBNull.Value ? (int?)null : (int?)((DataGridView)sender).Rows[e.RowIndex].Cells[18].Value);

                string newelement = "", newelement2;
                ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value = (int)((DataGridView)sender).Rows[e.RowIndex - 1].Cells[0].Value + 1;
                for (int i = 0; i < 19; i++)
                {
                    if (i != 0) newelement += ", ";
                    if ( ((DataGridView)sender).Rows[e.RowIndex].Cells[i].ValueType.Name != "String")
                    {
                        if (((DataGridView)sender).Rows[e.RowIndex].Cells[i].EditedFormattedValue == "")
                        {
                            newelement += "null";
                        }
                        else
                        {
                            if (((DataGridView)sender).Rows[e.RowIndex].Cells[i].ValueType.Name == "DateTime") newelement += "'" + ((DataGridView)sender).Rows[e.RowIndex].Cells[i].EditedFormattedValue.ToString() + "'";
                            else newelement += ((DataGridView)sender).Rows[e.RowIndex].Cells[i].Value.ToString();
                        }
                    }
                    else
                    {
                        newelement += "'" +((DataGridView)sender).Rows[e.RowIndex].Cells[i].EditedFormattedValue.ToString()+ "'";
                    }
                }
                newelement2 = "INSERT INTO `Турниры` (`Код турнира`, `Наименование`, `Код категории`, `Код системы проведения`, `Количество участников`, `Разряд`, `Количество групп`, `Дата начала`, `Дата конца`, `Количество кортов`, `Код корта 1`, `Код корта 2`, `Код корта 3`, `Время начала проведения`, `Время конца проведения`, `Длительность матча`, `ФИО директора`, `Телефон директора`, `Количество сеянных участников`) VALUES (" + newelement + ")";
                this.Турниры_TableAdapter.Insert(newelement);
            }
            //Турниры_TableAdapter.Fill();
        }
    }
}
