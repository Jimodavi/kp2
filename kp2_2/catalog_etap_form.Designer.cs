
namespace kp2_2
{
    partial class catalog_etap_form
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
            this.Справочник_этапов_турнира_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_этапа_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Этап_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_системы_проведения_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_систем_проведения_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Справочник_этапов_турнира_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Справочник_этапов_турнира_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_этапов_турнираTableAdapter();
            this.Справочник_систем_проведения_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_этапов_турнира_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_этапов_турнира_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Справочник_этапов_турнира_DataGridView
            // 
            this.Справочник_этапов_турнира_DataGridView.AllowUserToAddRows = false;
            this.Справочник_этапов_турнира_DataGridView.AllowUserToDeleteRows = false;
            this.Справочник_этапов_турнира_DataGridView.AutoGenerateColumns = false;
            this.Справочник_этапов_турнира_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Справочник_этапов_турнира_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_этапа_DataGridViewColumn,
            this.Этап_DataGridViewColumn,
            this.Код_системы_проведения_DataGridViewColumn});
            this.Справочник_этапов_турнира_DataGridView.DataSource = this.Справочник_этапов_турнира_BindingSource;
            this.Справочник_этапов_турнира_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Справочник_этапов_турнира_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Справочник_этапов_турнира_DataGridView.Name = "Справочник_этапов_турнира_DataGridView";
            this.Справочник_этапов_турнира_DataGridView.ReadOnly = true;
            this.Справочник_этапов_турнира_DataGridView.Size = new System.Drawing.Size(414, 361);
            this.Справочник_этапов_турнира_DataGridView.TabIndex = 0;
            // 
            // Код_этапа_DataGridViewColumn
            // 
            this.Код_этапа_DataGridViewColumn.DataPropertyName = "Код этапа";
            this.Код_этапа_DataGridViewColumn.HeaderText = "Код этапа";
            this.Код_этапа_DataGridViewColumn.Name = "Код_этапа_DataGridViewColumn";
            this.Код_этапа_DataGridViewColumn.ReadOnly = true;
            this.Код_этапа_DataGridViewColumn.Width = 90;
            // 
            // Этап_DataGridViewColumn
            // 
            this.Этап_DataGridViewColumn.DataPropertyName = "Этап";
            this.Этап_DataGridViewColumn.HeaderText = "Этап";
            this.Этап_DataGridViewColumn.Name = "Этап_DataGridViewColumn";
            this.Этап_DataGridViewColumn.ReadOnly = true;
            // 
            // Код_системы_проведения_DataGridViewColumn
            // 
            this.Код_системы_проведения_DataGridViewColumn.DataPropertyName = "Код системы проведения";
            this.Код_системы_проведения_DataGridViewColumn.DataSource = this.Справочник_систем_проведения_BindingSource;
            this.Код_системы_проведения_DataGridViewColumn.DisplayMember = "Название системы";
            this.Код_системы_проведения_DataGridViewColumn.HeaderText = "Код системы проведения";
            this.Код_системы_проведения_DataGridViewColumn.Name = "Код_системы_проведения_DataGridViewColumn";
            this.Код_системы_проведения_DataGridViewColumn.ReadOnly = true;
            this.Код_системы_проведения_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_системы_проведения_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_системы_проведения_DataGridViewColumn.ValueMember = "Код системы";
            this.Код_системы_проведения_DataGridViewColumn.Width = 180;
            // 
            // Справочник_систем_проведения_BindingSource
            // 
            this.Справочник_систем_проведения_BindingSource.DataMember = "Справочник систем проведения";
            this.Справочник_систем_проведения_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Справочник_этапов_турнира_BindingSource
            // 
            this.Справочник_этапов_турнира_BindingSource.DataMember = "Справочник этапов турнира";
            this.Справочник_этапов_турнира_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // Справочник_этапов_турнира_TableAdapter
            // 
            this.Справочник_этапов_турнира_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_систем_проведения_TableAdapter
            // 
            this.Справочник_систем_проведения_TableAdapter.ClearBeforeFill = true;
            // 
            // catalog_etap_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.Справочник_этапов_турнира_DataGridView);
            this.Name = "catalog_etap_form";
            this.Text = "catalog_etap_form";
            this.Load += new System.EventHandler(this.catalog_etap_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_этапов_турнира_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_этапов_турнира_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Справочник_этапов_турнира_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Справочник_этапов_турнира_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_этапов_турнираTableAdapter Справочник_этапов_турнира_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_систем_проведения_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter Справочник_систем_проведения_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_этапа_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Этап_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_системы_проведения_DataGridViewColumn;
    }
}