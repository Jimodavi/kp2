
namespace kp2_2
{
    partial class catalog_system_form
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
            this.Справочник_систем_проведения_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_системы_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_системы_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание_системы_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Справочник_систем_проведения_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Справочник_систем_проведения_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Справочник_систем_проведения_DataGridView
            // 
            this.Справочник_систем_проведения_DataGridView.AutoGenerateColumns = false;
            this.Справочник_систем_проведения_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Справочник_систем_проведения_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_системы_DataGridViewColumn,
            this.Название_системы_DataGridViewColumn,
            this.Описание_системы_DataGridViewColumn});
            this.Справочник_систем_проведения_DataGridView.DataSource = this.Справочник_систем_проведения_BindingSource;
            this.Справочник_систем_проведения_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Справочник_систем_проведения_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Справочник_систем_проведения_DataGridView.Name = "Справочник_систем_проведения_DataGridView";
            this.Справочник_систем_проведения_DataGridView.Size = new System.Drawing.Size(483, 361);
            this.Справочник_систем_проведения_DataGridView.TabIndex = 0;
            this.Справочник_систем_проведения_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Справочник_систем_проведения_DataGridView_CellBeginEdit);
            this.Справочник_систем_проведения_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Справочник_систем_проведения_DataGridView_CellEndEdit);
            this.Справочник_систем_проведения_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Справочник_систем_проведения_DataGridView_CellMouseClick);
            this.Справочник_систем_проведения_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Справочник_систем_проведения_DataGridView_DataError);
            this.Справочник_систем_проведения_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Справочник_систем_проведения_DataGridView_UserAddedRow);
            // 
            // Код_системы_DataGridViewColumn
            // 
            this.Код_системы_DataGridViewColumn.DataPropertyName = "Код системы";
            this.Код_системы_DataGridViewColumn.HeaderText = "Код системы";
            this.Код_системы_DataGridViewColumn.Name = "Код_системы_DataGridViewColumn";
            this.Код_системы_DataGridViewColumn.ReadOnly = true;
            // 
            // Название_системы_DataGridViewColumn
            // 
            this.Название_системы_DataGridViewColumn.DataPropertyName = "Название системы";
            this.Название_системы_DataGridViewColumn.HeaderText = "Название системы";
            this.Название_системы_DataGridViewColumn.Name = "Название_системы_DataGridViewColumn";
            this.Название_системы_DataGridViewColumn.Width = 140;
            // 
            // Описание_системы_DataGridViewColumn
            // 
            this.Описание_системы_DataGridViewColumn.DataPropertyName = "Описание системы";
            this.Описание_системы_DataGridViewColumn.HeaderText = "Описание системы";
            this.Описание_системы_DataGridViewColumn.Name = "Описание_системы_DataGridViewColumn";
            this.Описание_системы_DataGridViewColumn.Width = 200;
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
            // Справочник_систем_проведения_TableAdapter
            // 
            this.Справочник_систем_проведения_TableAdapter.ClearBeforeFill = true;
            // 
            // catalog_system_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 361);
            this.Controls.Add(this.Справочник_систем_проведения_DataGridView);
            this.Name = "catalog_system_form";
            this.Text = "catalog_system_form";
            this.Load += new System.EventHandler(this.catalog_system_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Справочник_систем_проведения_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Справочник_систем_проведения_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter Справочник_систем_проведения_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_системы_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_системы_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание_системы_DataGridViewColumn;
    }
}