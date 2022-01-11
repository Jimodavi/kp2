
namespace kp2_2
{
    partial class catalog_court_form
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
            this.Справочник_кортов_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_корта_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_корта_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расположение_корта_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Справочник_кортов_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Справочник_кортов_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_кортовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Справочник_кортов_DataGridView
            // 
            this.Справочник_кортов_DataGridView.AutoGenerateColumns = false;
            this.Справочник_кортов_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Справочник_кортов_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Справочник_кортов_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_корта_DataGridViewColumn,
            this.Название_корта_DataGridViewColumn,
            this.Расположение_корта_DataGridViewColumn});
            this.Справочник_кортов_DataGridView.DataSource = this.Справочник_кортов_BindingSource;
            this.Справочник_кортов_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Справочник_кортов_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Справочник_кортов_DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Справочник_кортов_DataGridView.Name = "Справочник_кортов_DataGridView";
            this.Справочник_кортов_DataGridView.Size = new System.Drawing.Size(525, 472);
            this.Справочник_кортов_DataGridView.TabIndex = 0;
            this.Справочник_кортов_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Справочник_кортов_DataGridView_CellBeginEdit);
            this.Справочник_кортов_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Справочник_кортов_DataGridView_CellEndEdit);
            this.Справочник_кортов_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Справочник_кортов_DataGridView_CellMouseClick);
            this.Справочник_кортов_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Справочник_кортов_DataGridView_DataError);
            this.Справочник_кортов_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Справочник_кортов_DataGridView_UserAddedRow);
            // 
            // Код_корта_DataGridViewColumn
            // 
            this.Код_корта_DataGridViewColumn.DataPropertyName = "Код корта";
            this.Код_корта_DataGridViewColumn.HeaderText = "Код корта";
            this.Код_корта_DataGridViewColumn.Name = "Код_корта_DataGridViewColumn";
            this.Код_корта_DataGridViewColumn.ReadOnly = true;
            this.Код_корта_DataGridViewColumn.Width = 93;
            // 
            // Название_корта_DataGridViewColumn
            // 
            this.Название_корта_DataGridViewColumn.DataPropertyName = "Название корта";
            this.Название_корта_DataGridViewColumn.HeaderText = "Название корта";
            this.Название_корта_DataGridViewColumn.Name = "Название_корта_DataGridViewColumn";
            this.Название_корта_DataGridViewColumn.Width = 128;
            // 
            // Расположение_корта_DataGridViewColumn
            // 
            this.Расположение_корта_DataGridViewColumn.DataPropertyName = "Расположение корта";
            this.Расположение_корта_DataGridViewColumn.HeaderText = "Расположение корта";
            this.Расположение_корта_DataGridViewColumn.Name = "Расположение_корта_DataGridViewColumn";
            this.Расположение_корта_DataGridViewColumn.Width = 159;
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
            // Справочник_кортов_TableAdapter
            // 
            this.Справочник_кортов_TableAdapter.ClearBeforeFill = true;
            // 
            // catalog_court_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 472);
            this.Controls.Add(this.Справочник_кортов_DataGridView);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "catalog_court_form";
            this.Text = "catalog_court_form";
            this.Load += new System.EventHandler(this.catalog_court_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Справочник_кортов_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_кортовTableAdapter Справочник_кортов_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_корта_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_корта_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Расположение_корта_DataGridViewColumn;
    }
}