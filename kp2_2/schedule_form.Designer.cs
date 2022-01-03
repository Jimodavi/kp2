
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
            this.Расписание_DataGridView = new System.Windows.Forms.DataGridView();
            this.Сетки_DataGridView = new System.Windows.Forms.DataGridView();
            this.Участник1_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Участник2_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_матча_DataGridViewColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_турнира_DataGridViewColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_участника1_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_участника2_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счёт_первого_сета_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счёт_второго_сета_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счёт_третьего_сета_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Победитель_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Этап_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Место_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сетки_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Код_матча_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_турнира_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Корт_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_кортов_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Время_начала_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расписание_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Расписание_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.РасписаниеTableAdapter();
            this.Справочник_кортов_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_кортовTableAdapter();
            this.Сетки_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.СеткиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Расписание_DataGridView
            // 
            this.Расписание_DataGridView.AllowUserToAddRows = false;
            this.Расписание_DataGridView.AllowUserToDeleteRows = false;
            this.Расписание_DataGridView.AutoGenerateColumns = false;
            this.Расписание_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Расписание_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_матча_DataGridViewColumn,
            this.Код_турнира_DataGridViewColumn,
            this.Корт_DataGridViewColumn,
            this.Время_начала_DataGridViewColumn});
            this.Расписание_DataGridView.DataSource = this.Расписание_BindingSource;
            this.Расписание_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Расписание_DataGridView.Name = "Расписание_DataGridView";
            this.Расписание_DataGridView.Size = new System.Drawing.Size(443, 361);
            this.Расписание_DataGridView.TabIndex = 0;
            this.Расписание_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Расписание_DataGridView_CellBeginEdit);
            this.Расписание_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Расписание_DataGridView_CellEndEdit);
            this.Расписание_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Расписание_DataGridView_DataError);
            // 
            // Сетки_DataGridView
            // 
            this.Сетки_DataGridView.AllowUserToAddRows = false;
            this.Сетки_DataGridView.AllowUserToDeleteRows = false;
            this.Сетки_DataGridView.AutoGenerateColumns = false;
            this.Сетки_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Сетки_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_матча_DataGridViewColumn2,
            this.Код_турнира_DataGridViewColumn2,
            this.Участник1_DataGridViewColumn,
            this.Участник2_DataGridViewColumn,
            this.Код_участника1_DataGridViewColumn,
            this.Код_участника2_DataGridViewColumn,
            this.Счёт_первого_сета_DataGridViewColumn,
            this.Счёт_второго_сета_DataGridViewColumn,
            this.Счёт_третьего_сета_DataGridViewColumn,
            this.Победитель_DataGridViewColumn,
            this.Этап_DataGridViewColumn,
            this.Место_DataGridViewColumn});
            this.Сетки_DataGridView.DataSource = this.Сетки_BindingSource;
            this.Сетки_DataGridView.Location = new System.Drawing.Point(449, 0);
            this.Сетки_DataGridView.Name = "Сетки_DataGridView";
            this.Сетки_DataGridView.Size = new System.Drawing.Size(734, 361);
            this.Сетки_DataGridView.TabIndex = 1;
            this.Сетки_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Сетки_DataGridView_CellBeginEdit);
            this.Сетки_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Сетки_DataGridView_CellEndEdit);
            this.Сетки_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Сетки_DataGridView_DataError);
            // 
            // Участник1_DataGridViewColumn
            // 
            this.Участник1_DataGridViewColumn.HeaderText = "Участник 1";
            this.Участник1_DataGridViewColumn.Name = "Участник1_DataGridViewColumn";
            this.Участник1_DataGridViewColumn.ReadOnly = true;
            // 
            // Участник2_DataGridViewColumn
            // 
            this.Участник2_DataGridViewColumn.HeaderText = "Участник 2";
            this.Участник2_DataGridViewColumn.Name = "Участник2_DataGridViewColumn";
            this.Участник2_DataGridViewColumn.ReadOnly = true;
            // 
            // Код_матча_DataGridViewColumn2
            // 
            this.Код_матча_DataGridViewColumn2.DataPropertyName = "Код матча";
            this.Код_матча_DataGridViewColumn2.HeaderText = "Код матча";
            this.Код_матча_DataGridViewColumn2.Name = "Код_матча_DataGridViewColumn2";
            this.Код_матча_DataGridViewColumn2.ReadOnly = true;
            this.Код_матча_DataGridViewColumn2.Width = 90;
            // 
            // Код_турнира_DataGridViewColumn2
            // 
            this.Код_турнира_DataGridViewColumn2.DataPropertyName = "Код турнира";
            this.Код_турнира_DataGridViewColumn2.HeaderText = "Код турнира";
            this.Код_турнира_DataGridViewColumn2.Name = "Код_турнира_DataGridViewColumn2";
            this.Код_турнира_DataGridViewColumn2.Visible = false;
            // 
            // Код_участника1_DataGridViewColumn
            // 
            this.Код_участника1_DataGridViewColumn.DataPropertyName = "Код участника 1";
            this.Код_участника1_DataGridViewColumn.HeaderText = "Код участника 1";
            this.Код_участника1_DataGridViewColumn.Name = "Код_участника1_DataGridViewColumn";
            this.Код_участника1_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_участника1_DataGridViewColumn.Visible = false;
            // 
            // Код_участника2_DataGridViewColumn
            // 
            this.Код_участника2_DataGridViewColumn.DataPropertyName = "Код участника 2";
            this.Код_участника2_DataGridViewColumn.HeaderText = "Код участника 2";
            this.Код_участника2_DataGridViewColumn.Name = "Код_участника2_DataGridViewColumn";
            this.Код_участника2_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_участника2_DataGridViewColumn.Visible = false;
            // 
            // Счёт_первого_сета_DataGridViewColumn
            // 
            this.Счёт_первого_сета_DataGridViewColumn.DataPropertyName = "Счёт первого сета";
            this.Счёт_первого_сета_DataGridViewColumn.HeaderText = "Счёт первого сета";
            this.Счёт_первого_сета_DataGridViewColumn.Name = "Счёт_первого_сета_DataGridViewColumn";
            // 
            // Счёт_второго_сета_DataGridViewColumn
            // 
            this.Счёт_второго_сета_DataGridViewColumn.DataPropertyName = "Счёт второго сета";
            this.Счёт_второго_сета_DataGridViewColumn.HeaderText = "Счёт второго сета";
            this.Счёт_второго_сета_DataGridViewColumn.Name = "Счёт_второго_сета_DataGridViewColumn";
            // 
            // Счёт_третьего_сета_DataGridViewColumn
            // 
            this.Счёт_третьего_сета_DataGridViewColumn.DataPropertyName = "Счёт третьего сета";
            this.Счёт_третьего_сета_DataGridViewColumn.HeaderText = "Счёт третьего сета";
            this.Счёт_третьего_сета_DataGridViewColumn.Name = "Счёт_третьего_сета_DataGridViewColumn";
            // 
            // Победитель_DataGridViewColumn
            // 
            this.Победитель_DataGridViewColumn.DataPropertyName = "Победитель";
            this.Победитель_DataGridViewColumn.HeaderText = "Победитель";
            this.Победитель_DataGridViewColumn.Name = "Победитель_DataGridViewColumn";
            this.Победитель_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Этап_DataGridViewColumn
            // 
            this.Этап_DataGridViewColumn.DataPropertyName = "Этап";
            this.Этап_DataGridViewColumn.HeaderText = "Этап";
            this.Этап_DataGridViewColumn.Name = "Этап_DataGridViewColumn";
            this.Этап_DataGridViewColumn.Visible = false;
            // 
            // Место_DataGridViewColumn
            // 
            this.Место_DataGridViewColumn.DataPropertyName = "Место";
            this.Место_DataGridViewColumn.HeaderText = "Место";
            this.Место_DataGridViewColumn.Name = "Место_DataGridViewColumn";
            this.Место_DataGridViewColumn.Visible = false;
            // 
            // Сетки_BindingSource
            // 
            this.Сетки_BindingSource.DataMember = "Сетки";
            this.Сетки_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Код_матча_DataGridViewColumn
            // 
            this.Код_матча_DataGridViewColumn.DataPropertyName = "Код матча";
            this.Код_матча_DataGridViewColumn.HeaderText = "Код матча";
            this.Код_матча_DataGridViewColumn.Name = "Код_матча_DataGridViewColumn";
            this.Код_матча_DataGridViewColumn.ReadOnly = true;
            this.Код_матча_DataGridViewColumn.Width = 90;
            // 
            // Код_турнира_DataGridViewColumn
            // 
            this.Код_турнира_DataGridViewColumn.DataPropertyName = "Код турнира";
            this.Код_турнира_DataGridViewColumn.HeaderText = "Код турнира";
            this.Код_турнира_DataGridViewColumn.Name = "Код_турнира_DataGridViewColumn";
            this.Код_турнира_DataGridViewColumn.Visible = false;
            // 
            // Корт_DataGridViewColumn
            // 
            this.Корт_DataGridViewColumn.DataPropertyName = "Корт";
            this.Корт_DataGridViewColumn.DataSource = this.Справочник_кортов_BindingSource;
            this.Корт_DataGridViewColumn.DisplayMember = "Название корта";
            this.Корт_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Корт_DataGridViewColumn.HeaderText = "Корт";
            this.Корт_DataGridViewColumn.Name = "Корт_DataGridViewColumn";
            this.Корт_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Корт_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Корт_DataGridViewColumn.ValueMember = "Код корта";
            this.Корт_DataGridViewColumn.Width = 200;
            // 
            // Справочник_кортов_BindingSource
            // 
            this.Справочник_кортов_BindingSource.DataMember = "Справочник кортов";
            this.Справочник_кортов_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // Время_начала_DataGridViewColumn
            // 
            this.Время_начала_DataGridViewColumn.DataPropertyName = "Время начала";
            this.Время_начала_DataGridViewColumn.HeaderText = "Время начала";
            this.Время_начала_DataGridViewColumn.Name = "Время_начала_DataGridViewColumn";
            this.Время_начала_DataGridViewColumn.Width = 110;
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
            // Сетки_TableAdapter
            // 
            this.Сетки_TableAdapter.ClearBeforeFill = true;
            // 
            // schedule_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 460);
            this.Controls.Add(this.Сетки_DataGridView);
            this.Controls.Add(this.Расписание_DataGridView);
            this.Name = "schedule_form";
            this.Text = "schedule_form";
            this.Load += new System.EventHandler(this.schedule_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Расписание_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.DataGridView Сетки_DataGridView;
        private System.Windows.Forms.BindingSource Расписание_BindingSource;
        private кп2_DataSetTableAdapters.РасписаниеTableAdapter Расписание_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_кортовTableAdapter Справочник_кортов_TableAdapter;
        private кп2_DataSetTableAdapters.СеткиTableAdapter Сетки_TableAdapter;
        private System.Windows.Forms.BindingSource Сетки_BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_матча_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_турнира_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Корт_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_начала_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_матча_DataGridViewColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_турнира_DataGridViewColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Участник1_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Участник2_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_участника1_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_участника2_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счёт_первого_сета_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счёт_второго_сета_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счёт_третьего_сета_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Победитель_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Этап_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Место_DataGridViewColumn;
    }
}