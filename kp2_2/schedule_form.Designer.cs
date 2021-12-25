
namespace kp2_2
{
    partial class schedule_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Расписание_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_матча_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_турнира_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Корт_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_кортов_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Время_начала_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расписание_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Расписание_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.РасписаниеTableAdapter();
            this.Справочник_кортов_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_кортовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Расписание_DataGridView
            // 
            this.Расписание_DataGridView.AutoGenerateColumns = false;
            this.Расписание_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Расписание_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_матча_DataGridViewTextBoxColumn,
            this.Код_турнира_DataGridViewTextBoxColumn,
            this.Корт_DataGridViewTextBoxColumn,
            this.Время_начала_DataGridViewTextBoxColumn});
            this.Расписание_DataGridView.DataSource = this.Расписание_BindingSource;
            this.Расписание_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Расписание_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Расписание_DataGridView.Name = "Расписание_DataGridView";
            this.Расписание_DataGridView.Size = new System.Drawing.Size(304, 361);
            this.Расписание_DataGridView.TabIndex = 0;
            this.Расписание_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Расписание_DataGridView_CellBeginEdit);
            this.Расписание_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Расписание_DataGridView_CellEndEdit);
            this.Расписание_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Расписание_DataGridView_CellMouseClick);
            this.Расписание_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Расписание_DataGridView_DataError);
            this.Расписание_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Расписание_DataGridView_UserAddedRow);
            // 
            // Код_матча_DataGridViewTextBoxColumn
            // 
            this.Код_матча_DataGridViewTextBoxColumn.DataPropertyName = "Код матча";
            this.Код_матча_DataGridViewTextBoxColumn.HeaderText = "Код матча";
            this.Код_матча_DataGridViewTextBoxColumn.Name = "Код_матча_DataGridViewTextBoxColumn";
            this.Код_матча_DataGridViewTextBoxColumn.Visible = false;
            // 
            // Код_турнира_DataGridViewTextBoxColumn
            // 
            this.Код_турнира_DataGridViewTextBoxColumn.DataPropertyName = "Код турнира";
            this.Код_турнира_DataGridViewTextBoxColumn.HeaderText = "Код турнира";
            this.Код_турнира_DataGridViewTextBoxColumn.Name = "Код_турнира_DataGridViewTextBoxColumn";
            this.Код_турнира_DataGridViewTextBoxColumn.Visible = false;
            // 
            // Корт_DataGridViewTextBoxColumn
            // 
            this.Корт_DataGridViewTextBoxColumn.DataPropertyName = "Корт";
            this.Корт_DataGridViewTextBoxColumn.DataSource = this.Справочник_кортов_BindingSource;
            this.Корт_DataGridViewTextBoxColumn.DisplayMember = "Название корта";
            this.Корт_DataGridViewTextBoxColumn.HeaderText = "Корт";
            this.Корт_DataGridViewTextBoxColumn.Name = "Корт_DataGridViewTextBoxColumn";
            this.Корт_DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Корт_DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Корт_DataGridViewTextBoxColumn.ValueMember = "Код корта";
            this.Корт_DataGridViewTextBoxColumn.Width = 150;
            // 
            // Справочник_кортов_BindingSource
            // 
            this.Справочник_кортов_BindingSource.DataMember = "Справочник кортов";
            this.Справочник_кортов_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Время_начала_DataGridViewTextBoxColumn
            // 
            this.Время_начала_DataGridViewTextBoxColumn.DataPropertyName = "Время начала";
            dataGridViewCellStyle5.Format = "dd.MM.yyyy - HH:mm";
            this.Время_начала_DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.Время_начала_DataGridViewTextBoxColumn.HeaderText = "Время начала";
            this.Время_начала_DataGridViewTextBoxColumn.Name = "Время_начала_DataGridViewTextBoxColumn";
            this.Время_начала_DataGridViewTextBoxColumn.Width = 110;
            // 
            // Расписание_BindingSource
            // 
            this.Расписание_BindingSource.DataMember = "Расписание";
            this.Расписание_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // Расписание_TableAdapter
            // 
            this.Расписание_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_кортов_TableAdapter
            // 
            this.Справочник_кортов_TableAdapter.ClearBeforeFill = true;
            // 
            // schedule_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.Расписание_DataGridView);
            this.Name = "schedule_form";
            this.Text = "schedule_form";
            this.Load += new System.EventHandler(this.schedule_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Расписание_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Расписание_BindingSource;
        private кп2_DataSetTableAdapters.РасписаниеTableAdapter Расписание_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_кортовTableAdapter Справочник_кортов_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_матча_DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_турнира_DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Корт_DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_начала_DataGridViewTextBoxColumn;
    }
}