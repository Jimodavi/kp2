namespace kp2_2
{
    partial class main_form
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
        /// 
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Schedule_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Draws_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.List_participants_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalogs_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalog_category_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalog_system_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalog_etap_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalog_court_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Catalog_players_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Турниры_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_турнира_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_категории_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_катерогий_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Код_системы_проведения_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_систем_проведения_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Количество_участников_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Разряд_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Количество_групп_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_начала_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_конца_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_кортов_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_корта_DataGridViewColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_кортов_BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Код_корта_DataGridViewColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_кортов_BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Код_корта_DataGridViewColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_кортов_BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Время_начала_проведения_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_конца_проведения_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Длительность_матча_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО_директора_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон_директора_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_сеянных_участников_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Турниры_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Турниры_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.ТурнирыTableAdapter();
            this.Справочник_катерогий_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_катерогийTableAdapter();
            this.Справочник_систем_проведения_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter();
            this.Справочник_кортов_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_кортовTableAdapter();
            this.main_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Турниры_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_катерогий_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Турниры_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Schedule_MenuItem,
            this.Draws_MenuItem,
            this.List_participants_MenuItem,
            this.Catalogs_MenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(1274, 24);
            this.main_menuStrip.TabIndex = 0;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // Schedule_MenuItem
            // 
            this.Schedule_MenuItem.Name = "Schedule_MenuItem";
            this.Schedule_MenuItem.Size = new System.Drawing.Size(84, 20);
            this.Schedule_MenuItem.Text = "Расписание";
            this.Schedule_MenuItem.Click += new System.EventHandler(this.Schedule_MenuItem_Click);
            // 
            // Draws_MenuItem
            // 
            this.Draws_MenuItem.Name = "Draws_MenuItem";
            this.Draws_MenuItem.Size = new System.Drawing.Size(50, 20);
            this.Draws_MenuItem.Text = "Сетка";
            // 
            // List_participants_MenuItem
            // 
            this.List_participants_MenuItem.Name = "List_participants_MenuItem";
            this.List_participants_MenuItem.Size = new System.Drawing.Size(77, 20);
            this.List_participants_MenuItem.Text = "Участники";
            this.List_participants_MenuItem.Click += new System.EventHandler(this.List_participants_MenuItem_Click);
            // 
            // Catalogs_MenuItem
            // 
            this.Catalogs_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Catalog_category_MenuItem,
            this.Catalog_system_MenuItem,
            this.Catalog_etap_MenuItem,
            this.Catalog_court_MenuItem,
            this.Catalog_players_MenuItem});
            this.Catalogs_MenuItem.Name = "Catalogs_MenuItem";
            this.Catalogs_MenuItem.Size = new System.Drawing.Size(94, 20);
            this.Catalogs_MenuItem.Text = "Справочники";
            // 
            // Catalog_category_MenuItem
            // 
            this.Catalog_category_MenuItem.Name = "Catalog_category_MenuItem";
            this.Catalog_category_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_category_MenuItem.Text = "Справочник категорий";
            this.Catalog_category_MenuItem.Click += new System.EventHandler(this.Catalog_category_MenuItem_Click);
            // 
            // Catalog_system_MenuItem
            // 
            this.Catalog_system_MenuItem.Name = "Catalog_system_MenuItem";
            this.Catalog_system_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_system_MenuItem.Text = "Справочник систем проведения";
            this.Catalog_system_MenuItem.Click += new System.EventHandler(this.Catalog_system_MenuItem_Click);
            // 
            // Catalog_etap_MenuItem
            // 
            this.Catalog_etap_MenuItem.Name = "Catalog_etap_MenuItem";
            this.Catalog_etap_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_etap_MenuItem.Text = "Справочник этапов проведения";
            this.Catalog_etap_MenuItem.Click += new System.EventHandler(this.Catalog_etap_MenuItem_Click);
            // 
            // Catalog_court_MenuItem
            // 
            this.Catalog_court_MenuItem.Name = "Catalog_court_MenuItem";
            this.Catalog_court_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_court_MenuItem.Text = "Справочник кортов";
            // 
            // Catalog_players_MenuItem
            // 
            this.Catalog_players_MenuItem.Name = "Catalog_players_MenuItem";
            this.Catalog_players_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_players_MenuItem.Text = "Справочник игроков";
            // 
            // Турниры_DataGridView
            // 
            this.Турниры_DataGridView.AutoGenerateColumns = false;
            this.Турниры_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Турниры_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_турнира_DataGridViewColumn,
            this.Наименование_DataGridViewColumn,
            this.Код_категории_DataGridViewColumn,
            this.Код_системы_проведения_DataGridViewColumn,
            this.Количество_участников_DataGridViewColumn,
            this.Разряд_DataGridViewColumn,
            this.Количество_групп_DataGridViewColumn,
            this.Дата_начала_DataGridViewColumn,
            this.Дата_конца_DataGridViewColumn,
            this.Количество_кортов_DataGridViewColumn,
            this.Код_корта_DataGridViewColumn1,
            this.Код_корта_DataGridViewColumn2,
            this.Код_корта_DataGridViewColumn3,
            this.Время_начала_проведения_DataGridViewColumn,
            this.Время_конца_проведения_DataGridViewColumn,
            this.Длительность_матча_DataGridViewColumn,
            this.ФИО_директора_DataGridViewColumn,
            this.Телефон_директора_DataGridViewColumn,
            this.Количество_сеянных_участников_DataGridViewColumn});
            this.Турниры_DataGridView.DataSource = this.Турниры_BindingSource;
            this.Турниры_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Турниры_DataGridView.Location = new System.Drawing.Point(0, 24);
            this.Турниры_DataGridView.Name = "Турниры_DataGridView";
            this.Турниры_DataGridView.ShowCellErrors = false;
            this.Турниры_DataGridView.ShowRowErrors = false;
            this.Турниры_DataGridView.Size = new System.Drawing.Size(1274, 337);
            this.Турниры_DataGridView.TabIndex = 1;
            this.Турниры_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Турниры_DataGridView_CellBeginEdit);
            this.Турниры_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Турниры_DataGridView_CellEndEdit);
            this.Турниры_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Турниры_DataGridView_CellMouseClick);
            this.Турниры_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Турниры_DataGridView_DataError);
            this.Турниры_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Турниры_DataGridView_UserAddedRow);
            // 
            // Код_турнира_DataGridViewColumn
            // 
            this.Код_турнира_DataGridViewColumn.DataPropertyName = "Код турнира";
            this.Код_турнира_DataGridViewColumn.HeaderText = "Код турнира";
            this.Код_турнира_DataGridViewColumn.Name = "Код_турнира_DataGridViewColumn";
            this.Код_турнира_DataGridViewColumn.ReadOnly = true;
            // 
            // Наименование_DataGridViewColumn
            // 
            this.Наименование_DataGridViewColumn.DataPropertyName = "Наименование";
            this.Наименование_DataGridViewColumn.HeaderText = "Наименование турнира";
            this.Наименование_DataGridViewColumn.Name = "Наименование_DataGridViewColumn";
            // 
            // Код_категории_DataGridViewColumn
            // 
            this.Код_категории_DataGridViewColumn.DataPropertyName = "Код категории";
            this.Код_категории_DataGridViewColumn.DataSource = this.Справочник_катерогий_BindingSource;
            this.Код_категории_DataGridViewColumn.DisplayMember = "Название категории";
            this.Код_категории_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Код_категории_DataGridViewColumn.HeaderText = "Категория";
            this.Код_категории_DataGridViewColumn.Name = "Код_категории_DataGridViewColumn";
            this.Код_категории_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_категории_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_категории_DataGridViewColumn.ValueMember = "Код категории";
            this.Код_категории_DataGridViewColumn.Width = 63;
            // 
            // Справочник_катерогий_BindingSource
            // 
            this.Справочник_катерогий_BindingSource.DataMember = "Справочник катерогий";
            this.Справочник_катерогий_BindingSource.DataSource = this.кп2_BindingSource;
            // 
            // кп2_BindingSource
            // 
            this.кп2_BindingSource.DataSource = this.кп2_DataSet;
            this.кп2_BindingSource.Position = 0;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Код_системы_проведения_DataGridViewColumn
            // 
            this.Код_системы_проведения_DataGridViewColumn.DataPropertyName = "Код системы проведения";
            this.Код_системы_проведения_DataGridViewColumn.DataSource = this.Справочник_систем_проведения_BindingSource;
            this.Код_системы_проведения_DataGridViewColumn.DisplayMember = "Название системы";
            this.Код_системы_проведения_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Код_системы_проведения_DataGridViewColumn.HeaderText = "Система проведения";
            this.Код_системы_проведения_DataGridViewColumn.Name = "Код_системы_проведения_DataGridViewColumn";
            this.Код_системы_проведения_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_системы_проведения_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_системы_проведения_DataGridViewColumn.ValueMember = "Код системы";
            this.Код_системы_проведения_DataGridViewColumn.Width = 110;
            // 
            // Справочник_систем_проведения_BindingSource
            // 
            this.Справочник_систем_проведения_BindingSource.DataMember = "Справочник систем проведения";
            this.Справочник_систем_проведения_BindingSource.DataSource = this.кп2_BindingSource;
            // 
            // Количество_участников_DataGridViewColumn
            // 
            this.Количество_участников_DataGridViewColumn.DataPropertyName = "Количество участников";
            this.Количество_участников_DataGridViewColumn.HeaderText = "Количество участников";
            this.Количество_участников_DataGridViewColumn.Name = "Количество_участников_DataGridViewColumn";
            // 
            // Разряд_DataGridViewColumn
            // 
            this.Разряд_DataGridViewColumn.DataPropertyName = "Разряд";
            this.Разряд_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Разряд_DataGridViewColumn.HeaderText = "Разряд";
            this.Разряд_DataGridViewColumn.Items.AddRange(new object[] {
            "Одиночный женский",
            "Парный женский",
            "Одиночный мужской",
            "Парный мужской",
            "Смешанный парный"});
            this.Разряд_DataGridViewColumn.Name = "Разряд_DataGridViewColumn";
            this.Разряд_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Разряд_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Разряд_DataGridViewColumn.Width = 115;
            // 
            // Количество_групп_DataGridViewColumn
            // 
            this.Количество_групп_DataGridViewColumn.DataPropertyName = "Количество групп";
            this.Количество_групп_DataGridViewColumn.HeaderText = "Количество групп";
            this.Количество_групп_DataGridViewColumn.Name = "Количество_групп_DataGridViewColumn";
            // 
            // Дата_начала_DataGridViewColumn
            // 
            this.Дата_начала_DataGridViewColumn.DataPropertyName = "Дата начала";
            this.Дата_начала_DataGridViewColumn.HeaderText = "Дата начала";
            this.Дата_начала_DataGridViewColumn.Name = "Дата_начала_DataGridViewColumn";
            // 
            // Дата_конца_DataGridViewColumn
            // 
            this.Дата_конца_DataGridViewColumn.DataPropertyName = "Дата конца";
            this.Дата_конца_DataGridViewColumn.HeaderText = "Дата конца";
            this.Дата_конца_DataGridViewColumn.Name = "Дата_конца_DataGridViewColumn";
            // 
            // Количество_кортов_DataGridViewColumn
            // 
            this.Количество_кортов_DataGridViewColumn.DataPropertyName = "Количество кортов";
            this.Количество_кортов_DataGridViewColumn.HeaderText = "Количество кортов";
            this.Количество_кортов_DataGridViewColumn.Name = "Количество_кортов_DataGridViewColumn";
            // 
            // Код_корта_DataGridViewColumn1
            // 
            this.Код_корта_DataGridViewColumn1.DataPropertyName = "Код корта 1";
            this.Код_корта_DataGridViewColumn1.DataSource = this.Справочник_кортов_BindingSource1;
            this.Код_корта_DataGridViewColumn1.DisplayMember = "Название корта";
            this.Код_корта_DataGridViewColumn1.DisplayStyleForCurrentCellOnly = true;
            this.Код_корта_DataGridViewColumn1.HeaderText = "Название корта 1";
            this.Код_корта_DataGridViewColumn1.Name = "Код_корта_DataGridViewColumn1";
            this.Код_корта_DataGridViewColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_корта_DataGridViewColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_корта_DataGridViewColumn1.ValueMember = "Код корта";
            // 
            // Справочник_кортов_BindingSource1
            // 
            this.Справочник_кортов_BindingSource1.DataMember = "Справочник кортов";
            this.Справочник_кортов_BindingSource1.DataSource = this.кп2_BindingSource;
            // 
            // Код_корта_DataGridViewColumn2
            // 
            this.Код_корта_DataGridViewColumn2.DataPropertyName = "Код корта 2";
            this.Код_корта_DataGridViewColumn2.DataSource = this.Справочник_кортов_BindingSource2;
            this.Код_корта_DataGridViewColumn2.DisplayMember = "Название корта";
            this.Код_корта_DataGridViewColumn2.DisplayStyleForCurrentCellOnly = true;
            this.Код_корта_DataGridViewColumn2.HeaderText = "Название корта 2";
            this.Код_корта_DataGridViewColumn2.Name = "Код_корта_DataGridViewColumn2";
            this.Код_корта_DataGridViewColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_корта_DataGridViewColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_корта_DataGridViewColumn2.ValueMember = "Код корта";
            // 
            // Справочник_кортов_BindingSource2
            // 
            this.Справочник_кортов_BindingSource2.DataMember = "Справочник кортов";
            this.Справочник_кортов_BindingSource2.DataSource = this.кп2_BindingSource;
            // 
            // Код_корта_DataGridViewColumn3
            // 
            this.Код_корта_DataGridViewColumn3.DataPropertyName = "Код корта 3";
            this.Код_корта_DataGridViewColumn3.DataSource = this.Справочник_кортов_BindingSource3;
            this.Код_корта_DataGridViewColumn3.DisplayMember = "Название корта";
            this.Код_корта_DataGridViewColumn3.DisplayStyleForCurrentCellOnly = true;
            this.Код_корта_DataGridViewColumn3.HeaderText = "Название корта 3";
            this.Код_корта_DataGridViewColumn3.Name = "Код_корта_DataGridViewColumn3";
            this.Код_корта_DataGridViewColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_корта_DataGridViewColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_корта_DataGridViewColumn3.ValueMember = "Код корта";
            // 
            // Справочник_кортов_BindingSource3
            // 
            this.Справочник_кортов_BindingSource3.DataMember = "Справочник кортов";
            this.Справочник_кортов_BindingSource3.DataSource = this.кп2_BindingSource;
            // 
            // Время_начала_проведения_DataGridViewColumn
            // 
            this.Время_начала_проведения_DataGridViewColumn.DataPropertyName = "Время начала проведения";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.Время_начала_проведения_DataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.Время_начала_проведения_DataGridViewColumn.HeaderText = "Время начала проведения";
            this.Время_начала_проведения_DataGridViewColumn.Name = "Время_начала_проведения_DataGridViewColumn";
            // 
            // Время_конца_проведения_DataGridViewColumn
            // 
            this.Время_конца_проведения_DataGridViewColumn.DataPropertyName = "Время конца проведения";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.Время_конца_проведения_DataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.Время_конца_проведения_DataGridViewColumn.HeaderText = "Время конца проведения";
            this.Время_конца_проведения_DataGridViewColumn.Name = "Время_конца_проведения_DataGridViewColumn";
            // 
            // Длительность_матча_DataGridViewColumn
            // 
            this.Длительность_матча_DataGridViewColumn.DataPropertyName = "Длительность матча";
            this.Длительность_матча_DataGridViewColumn.HeaderText = "Длительность матча";
            this.Длительность_матча_DataGridViewColumn.Name = "Длительность_матча_DataGridViewColumn";
            // 
            // ФИО_директора_DataGridViewColumn
            // 
            this.ФИО_директора_DataGridViewColumn.DataPropertyName = "ФИО директора";
            this.ФИО_директора_DataGridViewColumn.HeaderText = "ФИО директора";
            this.ФИО_директора_DataGridViewColumn.Name = "ФИО_директора_DataGridViewColumn";
            // 
            // Телефон_директора_DataGridViewColumn
            // 
            this.Телефон_директора_DataGridViewColumn.DataPropertyName = "Телефон директора";
            this.Телефон_директора_DataGridViewColumn.HeaderText = "Телефон директора";
            this.Телефон_директора_DataGridViewColumn.Name = "Телефон_директора_DataGridViewColumn";
            // 
            // Количество_сеянных_участников_DataGridViewColumn
            // 
            this.Количество_сеянных_участников_DataGridViewColumn.DataPropertyName = "Количество сеянных участников";
            this.Количество_сеянных_участников_DataGridViewColumn.HeaderText = "Количество сеянных участников";
            this.Количество_сеянных_участников_DataGridViewColumn.Name = "Количество_сеянных_участников_DataGridViewColumn";
            // 
            // Турниры_BindingSource
            // 
            this.Турниры_BindingSource.DataMember = "Турниры";
            this.Турниры_BindingSource.DataSource = this.кп2_BindingSource;
            // 
            // Турниры_TableAdapter
            // 
            this.Турниры_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_катерогий_TableAdapter
            // 
            this.Справочник_катерогий_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_систем_проведения_TableAdapter
            // 
            this.Справочник_систем_проведения_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_кортов_TableAdapter
            // 
            this.Справочник_кортов_TableAdapter.ClearBeforeFill = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 361);
            this.Controls.Add(this.Турниры_DataGridView);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "main_form";
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Турниры_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_катерогий_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_систем_проведения_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_кортов_BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Турниры_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Schedule_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Draws_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem List_participants_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalogs_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_category_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_system_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_etap_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_court_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_players_MenuItem;
        private System.Windows.Forms.DataGridView Турниры_DataGridView;
        private System.Windows.Forms.BindingSource кп2_BindingSource;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Турниры_BindingSource;
        public  кп2_DataSetTableAdapters.ТурнирыTableAdapter Турниры_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_катерогий_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_катерогийTableAdapter Справочник_катерогий_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_систем_проведения_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_систем_проведенияTableAdapter Справочник_систем_проведения_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource1;
        private кп2_DataSetTableAdapters.Справочник_кортовTableAdapter Справочник_кортов_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource2;
        private System.Windows.Forms.BindingSource Справочник_кортов_BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_турнира_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_категории_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_системы_проведения_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_участников_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Разряд_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_групп_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_начала_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_конца_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_кортов_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_корта_DataGridViewColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_корта_DataGridViewColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_корта_DataGridViewColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_начала_проведения_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_конца_проведения_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Длительность_матча_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_директора_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон_директора_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_сеянных_участников_DataGridViewColumn;
    }
}