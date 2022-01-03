
namespace kp2_2
{
    partial class catalog_category_form
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
            this.Справочник_категорий_DataGridView = new System.Windows.Forms.DataGridView();
            this.Справочник_категорий_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Справочник_категорий_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_катерогийTableAdapter();
            this.Код_категории_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_категории_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание_категории_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_категорий_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_категорий_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Справочник_категорий_DataGridView
            // 
            this.Справочник_категорий_DataGridView.AllowUserToAddRows = false;
            this.Справочник_категорий_DataGridView.AllowUserToDeleteRows = false;
            this.Справочник_категорий_DataGridView.AutoGenerateColumns = false;
            this.Справочник_категорий_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Справочник_категорий_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_категории_DataGridViewColumn,
            this.Название_категории_DataGridViewColumn,
            this.Описание_категории_DataGridViewColumn});
            this.Справочник_категорий_DataGridView.DataSource = this.Справочник_категорий_BindingSource;
            this.Справочник_категорий_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Справочник_категорий_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Справочник_категорий_DataGridView.Name = "Справочник_категорий_DataGridView";
            this.Справочник_категорий_DataGridView.Size = new System.Drawing.Size(494, 361);
            this.Справочник_категорий_DataGridView.TabIndex = 0;
            this.Справочник_категорий_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Справочник_категорий_DataGridView_CellEndEdit);
            this.Справочник_категорий_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Справочник_категорий_DataGridView_DataError);
            // 
            // Справочник_категорий_BindingSource
            // 
            this.Справочник_категорий_BindingSource.DataMember = "Справочник катерогий";
            this.Справочник_категорий_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Справочник_категорий_TableAdapter
            // 
            this.Справочник_категорий_TableAdapter.ClearBeforeFill = true;
            // 
            // Код_категории_DataGridViewColumn
            // 
            this.Код_категории_DataGridViewColumn.DataPropertyName = "Код категории";
            this.Код_категории_DataGridViewColumn.HeaderText = "Код категории";
            this.Код_категории_DataGridViewColumn.Name = "Код_категории_DataGridViewColumn";
            this.Код_категории_DataGridViewColumn.ReadOnly = true;
            this.Код_категории_DataGridViewColumn.Width = 110;
            // 
            // Название_категории_DataGridViewColumn
            // 
            this.Название_категории_DataGridViewColumn.DataPropertyName = "Название категории";
            this.Название_категории_DataGridViewColumn.HeaderText = "Название категории";
            this.Название_категории_DataGridViewColumn.Name = "Название_категории_DataGridViewColumn";
            this.Название_категории_DataGridViewColumn.ReadOnly = true;
            this.Название_категории_DataGridViewColumn.Width = 140;
            // 
            // Описание_категории_DataGridViewColumn
            // 
            this.Описание_категории_DataGridViewColumn.DataPropertyName = "Описание категории";
            this.Описание_категории_DataGridViewColumn.HeaderText = "Описание категории";
            this.Описание_категории_DataGridViewColumn.Name = "Описание_категории_DataGridViewColumn";
            this.Описание_категории_DataGridViewColumn.Width = 200;
            // 
            // catalog_category_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.Справочник_категорий_DataGridView);
            this.Name = "catalog_category_form";
            this.Text = "catalog_category_form";
            this.Load += new System.EventHandler(this.catalog_category_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_категорий_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_категорий_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Справочник_категорий_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Справочник_категорий_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_катерогийTableAdapter Справочник_категорий_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_категории_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_категории_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание_категории_DataGridViewColumn;
    }
}