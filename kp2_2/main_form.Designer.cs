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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courtDS = new System.Windows.Forms.BindingSource(this.components);
            this.kp2DataSet = new kp2_2.kp2DataSet();
            this.справочникКортовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_кортовTableAdapter = new kp2_2.kp2DataSetTableAdapters.Справочник_кортовTableAdapter();
            this.справочникКортовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справочникКортовBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Category_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_DataSet = new kp2_2.Category_DataSet();
            this.справочникКатерогийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_катерогийTableAdapter = new kp2_2.Category_DataSetTableAdapters.Справочник_катерогийTableAdapter();
            this.кодТурнираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоУчастниковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разрядDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоГруппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаКонцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоКортовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.времяНачалаПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяКонцаПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длительностьМатчаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОДиректораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонДиректораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСеянныхУчастниковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.турнирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournaments_Dataset = new kp2_2.Tournaments_Dataset();
            this.турнирыTableAdapter = new kp2_2.Tournaments_DatasetTableAdapters.ТурнирыTableAdapter();
            this.main_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКатерогийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнирыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournaments_Dataset)).BeginInit();
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
            this.main_menuStrip.Size = new System.Drawing.Size(1440, 24);
            this.main_menuStrip.TabIndex = 0;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // Schedule_MenuItem
            // 
            this.Schedule_MenuItem.Name = "Schedule_MenuItem";
            this.Schedule_MenuItem.Size = new System.Drawing.Size(85, 20);
            this.Schedule_MenuItem.Text = "Расписиние";
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
            // 
            // Catalog_etap_MenuItem
            // 
            this.Catalog_etap_MenuItem.Name = "Catalog_etap_MenuItem";
            this.Catalog_etap_MenuItem.Size = new System.Drawing.Size(252, 22);
            this.Catalog_etap_MenuItem.Text = "Справочник этапов проведения";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТурнираDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.количествоУчастниковDataGridViewTextBoxColumn,
            this.разрядDataGridViewTextBoxColumn,
            this.количествоГруппDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаКонцаDataGridViewTextBoxColumn,
            this.количествоКортовDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.времяНачалаПроведенияDataGridViewTextBoxColumn,
            this.времяКонцаПроведенияDataGridViewTextBoxColumn,
            this.длительностьМатчаDataGridViewTextBoxColumn,
            this.фИОДиректораDataGridViewTextBoxColumn,
            this.телефонДиректораDataGridViewTextBoxColumn,
            this.количествоСеянныхУчастниковDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.турнирыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1428, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // courtDS
            // 
            this.courtDS.DataSource = this.kp2DataSet;
            this.courtDS.Position = 0;
            // 
            // kp2DataSet
            // 
            this.kp2DataSet.DataSetName = "kp2DataSet";
            this.kp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочникКортовBindingSource
            // 
            this.справочникКортовBindingSource.DataMember = "Справочник кортов";
            this.справочникКортовBindingSource.DataSource = this.courtDS;
            // 
            // справочник_кортовTableAdapter
            // 
            this.справочник_кортовTableAdapter.ClearBeforeFill = true;
            // 
            // справочникКортовBindingSource1
            // 
            this.справочникКортовBindingSource1.DataMember = "Справочник кортов";
            this.справочникКортовBindingSource1.DataSource = this.courtDS;
            // 
            // справочникКортовBindingSource2
            // 
            this.справочникКортовBindingSource2.DataMember = "Справочник кортов";
            this.справочникКортовBindingSource2.DataSource = this.courtDS;
            // 
            // Category_bindingSource
            // 
            this.Category_bindingSource.DataSource = this.category_DataSet;
            this.Category_bindingSource.Position = 0;
            // 
            // category_DataSet
            // 
            this.category_DataSet.DataSetName = "Category_DataSet";
            this.category_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочникКатерогийBindingSource
            // 
            this.справочникКатерогийBindingSource.DataMember = "Справочник катерогий";
            this.справочникКатерогийBindingSource.DataSource = this.Category_bindingSource;
            // 
            // справочник_катерогийTableAdapter
            // 
            this.справочник_катерогийTableAdapter.ClearBeforeFill = true;
            // 
            // кодТурнираDataGridViewTextBoxColumn
            // 
            this.кодТурнираDataGridViewTextBoxColumn.DataPropertyName = "Код турнира";
            this.кодТурнираDataGridViewTextBoxColumn.HeaderText = "Код турнира";
            this.кодТурнираDataGridViewTextBoxColumn.Name = "кодТурнираDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код категории";
            this.dataGridViewTextBoxColumn1.DataSource = this.справочникКатерогийBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Название категории";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код категории";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Код категории";
            // 
            // количествоУчастниковDataGridViewTextBoxColumn
            // 
            this.количествоУчастниковDataGridViewTextBoxColumn.DataPropertyName = "Количество участников";
            this.количествоУчастниковDataGridViewTextBoxColumn.HeaderText = "Количество участников";
            this.количествоУчастниковDataGridViewTextBoxColumn.Name = "количествоУчастниковDataGridViewTextBoxColumn";
            // 
            // разрядDataGridViewTextBoxColumn
            // 
            this.разрядDataGridViewTextBoxColumn.DataPropertyName = "Разряд";
            this.разрядDataGridViewTextBoxColumn.HeaderText = "Разряд";
            this.разрядDataGridViewTextBoxColumn.Name = "разрядDataGridViewTextBoxColumn";
            // 
            // количествоГруппDataGridViewTextBoxColumn
            // 
            this.количествоГруппDataGridViewTextBoxColumn.DataPropertyName = "Количество групп";
            this.количествоГруппDataGridViewTextBoxColumn.HeaderText = "Количество групп";
            this.количествоГруппDataGridViewTextBoxColumn.Name = "количествоГруппDataGridViewTextBoxColumn";
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            // 
            // датаКонцаDataGridViewTextBoxColumn
            // 
            this.датаКонцаDataGridViewTextBoxColumn.DataPropertyName = "Дата конца";
            this.датаКонцаDataGridViewTextBoxColumn.HeaderText = "Дата конца";
            this.датаКонцаDataGridViewTextBoxColumn.Name = "датаКонцаDataGridViewTextBoxColumn";
            // 
            // количествоКортовDataGridViewTextBoxColumn
            // 
            this.количествоКортовDataGridViewTextBoxColumn.DataPropertyName = "Количество кортов";
            this.количествоКортовDataGridViewTextBoxColumn.HeaderText = "Количество кортов";
            this.количествоКортовDataGridViewTextBoxColumn.Name = "количествоКортовDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код корта 1";
            this.dataGridViewTextBoxColumn3.DataSource = this.справочникКортовBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Название корта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код корта 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код корта";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код корта 2";
            this.dataGridViewTextBoxColumn4.DataSource = this.справочникКортовBindingSource1;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Название корта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код корта 2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Код корта";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код корта 3";
            this.dataGridViewTextBoxColumn5.DataSource = this.справочникКортовBindingSource2;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Название корта";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код корта 3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Код корта";
            // 
            // времяНачалаПроведенияDataGridViewTextBoxColumn
            // 
            this.времяНачалаПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Время начала проведения";
            this.времяНачалаПроведенияDataGridViewTextBoxColumn.HeaderText = "Время начала проведения";
            this.времяНачалаПроведенияDataGridViewTextBoxColumn.Name = "времяНачалаПроведенияDataGridViewTextBoxColumn";
            // 
            // времяКонцаПроведенияDataGridViewTextBoxColumn
            // 
            this.времяКонцаПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Время конца проведения";
            this.времяКонцаПроведенияDataGridViewTextBoxColumn.HeaderText = "Время конца проведения";
            this.времяКонцаПроведенияDataGridViewTextBoxColumn.Name = "времяКонцаПроведенияDataGridViewTextBoxColumn";
            // 
            // длительностьМатчаDataGridViewTextBoxColumn
            // 
            this.длительностьМатчаDataGridViewTextBoxColumn.DataPropertyName = "Длительность матча";
            this.длительностьМатчаDataGridViewTextBoxColumn.HeaderText = "Длительность матча";
            this.длительностьМатчаDataGridViewTextBoxColumn.Name = "длительностьМатчаDataGridViewTextBoxColumn";
            // 
            // фИОДиректораDataGridViewTextBoxColumn
            // 
            this.фИОДиректораDataGridViewTextBoxColumn.DataPropertyName = "ФИО директора";
            this.фИОДиректораDataGridViewTextBoxColumn.HeaderText = "ФИО директора";
            this.фИОДиректораDataGridViewTextBoxColumn.Name = "фИОДиректораDataGridViewTextBoxColumn";
            // 
            // телефонДиректораDataGridViewTextBoxColumn
            // 
            this.телефонДиректораDataGridViewTextBoxColumn.DataPropertyName = "Телефон директора";
            this.телефонДиректораDataGridViewTextBoxColumn.HeaderText = "Телефон директора";
            this.телефонДиректораDataGridViewTextBoxColumn.Name = "телефонДиректораDataGridViewTextBoxColumn";
            // 
            // количествоСеянныхУчастниковDataGridViewTextBoxColumn
            // 
            this.количествоСеянныхУчастниковDataGridViewTextBoxColumn.DataPropertyName = "Количество сеянных участников";
            this.количествоСеянныхУчастниковDataGridViewTextBoxColumn.HeaderText = "Количество сеянных участников";
            this.количествоСеянныхУчастниковDataGridViewTextBoxColumn.Name = "количествоСеянныхУчастниковDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код системы проведения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код системы проведения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // турнирыBindingSource
            // 
            this.турнирыBindingSource.DataMember = "Турниры";
            this.турнирыBindingSource.DataSource = this.tournaments_Dataset;
            // 
            // tournaments_Dataset
            // 
            this.tournaments_Dataset.DataSetName = "Tournaments_Dataset";
            this.tournaments_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // турнирыTableAdapter
            // 
            this.турнирыTableAdapter.ClearBeforeFill = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "main_form";
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКортовBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникКатерогийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнирыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournaments_Dataset)).EndInit();
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
        private Tournaments_Dataset tournaments_Dataset;
        private System.Windows.Forms.BindingSource турнирыBindingSource;
        private Tournaments_DatasetTableAdapters.ТурнирыTableAdapter турнирыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСистемыПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКорта1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКорта2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКорта3DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem Catalog_etap_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_court_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Catalog_players_MenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courtDS;
        private kp2DataSet kp2DataSet;
        private System.Windows.Forms.BindingSource справочникКортовBindingSource;
        private kp2DataSetTableAdapters.Справочник_кортовTableAdapter справочник_кортовTableAdapter;
        private System.Windows.Forms.BindingSource справочникКортовBindingSource1;
        private System.Windows.Forms.BindingSource справочникКортовBindingSource2;
        private System.Windows.Forms.BindingSource Category_bindingSource;
        private Category_DataSet category_DataSet;
        private System.Windows.Forms.BindingSource справочникКатерогийBindingSource;
        private Category_DataSetTableAdapters.Справочник_катерогийTableAdapter справочник_катерогийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТурнираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоУчастниковDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разрядDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоГруппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаКонцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоКортовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНачалаПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяКонцаПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длительностьМатчаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОДиректораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонДиректораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСеянныхУчастниковDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}