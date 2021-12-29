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
    public partial class catalog_etap_form : Form
    {
        private object old_value;
        public catalog_etap_form()
        {
            InitializeComponent();
        }

        private void catalog_etap_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_систем_проведения". При необходимости она может быть перемещена или удалена.
            this.Справочник_систем_проведения_TableAdapter.Fill(this.кп2_DataSet.Справочник_систем_проведения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кп2_DataSet.Справочник_этапов_турнира". При необходимости она может быть перемещена или удалена.
            this.Справочник_этапов_турнира_TableAdapter.Fill(this.кп2_DataSet.Справочник_этапов_турнира);

        }

    }
}
