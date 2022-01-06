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
    public partial class draws_form : Form
    {
        private int code_tournament;
        public draws_form (int code_tournament)
        {
            InitializeComponent();
            this.code_tournament = code_tournament;
        }
        private void draws_form_Load(object sender, EventArgs e)
        {
            Сетки_DataGridView.ColumnCount = 3;
            Сетки_DataGridView.RowCount = 3;
        }
    }
}