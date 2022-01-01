
namespace kp2_2
{
    partial class catalog_players_form
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
            this.Справочник_игроков_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_игрока_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчетсво_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Город_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мобильный_телефон_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рейтинг_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Справочник_игроков_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Справочник_игроков_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_игроковTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Справочник_игроков_DataGridView
            // 
            this.Справочник_игроков_DataGridView.AutoGenerateColumns = false;
            this.Справочник_игроков_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Справочник_игроков_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_игрока_DataGridViewColumn,
            this.Фамилия_DataGridViewColumn,
            this.Имя_DataGridViewColumn,
            this.Отчетсво_DataGridViewColumn,
            this.Дата_рождения_DataGridViewColumn,
            this.Город_DataGridViewColumn,
            this.Мобильный_телефон_DataGridViewColumn,
            this.Рейтинг_DataGridViewColumn});
            this.Справочник_игроков_DataGridView.DataSource = this.Справочник_игроков_BindingSource;
            this.Справочник_игроков_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Справочник_игроков_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Справочник_игроков_DataGridView.Name = "Справочник_игроков_DataGridView";
            this.Справочник_игроков_DataGridView.Size = new System.Drawing.Size(893, 361);
            this.Справочник_игроков_DataGridView.TabIndex = 0;
            this.Справочник_игроков_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Справочник_игроков_DataGridView_CellBeginEdit);
            this.Справочник_игроков_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Справочник_игроков_DataGridView_CellEndEdit);
            this.Справочник_игроков_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Справочник_игроков_DataGridView_CellMouseClick);
            this.Справочник_игроков_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Справочник_игроков_DataGridView_DataError);
            this.Справочник_игроков_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Справочник_игроков_DataGridView_UserAddedRow);
            // 
            // Код_игрока_DataGridViewColumn
            // 
            this.Код_игрока_DataGridViewColumn.DataPropertyName = "Код игрока";
            this.Код_игрока_DataGridViewColumn.HeaderText = "Код игрока";
            this.Код_игрока_DataGridViewColumn.Name = "Код_игрока_DataGridViewColumn";
            this.Код_игрока_DataGridViewColumn.ReadOnly = true;
            this.Код_игрока_DataGridViewColumn.Width = 90;
            // 
            // Фамилия_DataGridViewColumn
            // 
            this.Фамилия_DataGridViewColumn.DataPropertyName = "Фамилия";
            this.Фамилия_DataGridViewColumn.HeaderText = "Фамилия";
            this.Фамилия_DataGridViewColumn.Name = "Фамилия_DataGridViewColumn";
            // 
            // Имя_DataGridViewColumn
            // 
            this.Имя_DataGridViewColumn.DataPropertyName = "Имя";
            this.Имя_DataGridViewColumn.HeaderText = "Имя";
            this.Имя_DataGridViewColumn.Name = "Имя_DataGridViewColumn";
            // 
            // Отчетсво_DataGridViewColumn
            // 
            this.Отчетсво_DataGridViewColumn.DataPropertyName = "Отчетсво";
            this.Отчетсво_DataGridViewColumn.HeaderText = "Отчетсво";
            this.Отчетсво_DataGridViewColumn.Name = "Отчетсво_DataGridViewColumn";
            // 
            // Дата_рождения_DataGridViewColumn
            // 
            this.Дата_рождения_DataGridViewColumn.DataPropertyName = "Дата рождения";
            this.Дата_рождения_DataGridViewColumn.HeaderText = "Дата рождения";
            this.Дата_рождения_DataGridViewColumn.Name = "Дата_рождения_DataGridViewColumn";
            this.Дата_рождения_DataGridViewColumn.Width = 120;
            // 
            // Город_DataGridViewColumn
            // 
            this.Город_DataGridViewColumn.DataPropertyName = "Город";
            this.Город_DataGridViewColumn.HeaderText = "Город";
            this.Город_DataGridViewColumn.Name = "Город_DataGridViewColumn";
            // 
            // Мобильный_телефон_DataGridViewColumn
            // 
            this.Мобильный_телефон_DataGridViewColumn.DataPropertyName = "Мобильный телефон";
            this.Мобильный_телефон_DataGridViewColumn.HeaderText = "Мобильный телефон";
            this.Мобильный_телефон_DataGridViewColumn.Name = "Мобильный_телефон_DataGridViewColumn";
            this.Мобильный_телефон_DataGridViewColumn.Width = 140;
            // 
            // Рейтинг_DataGridViewColumn
            // 
            this.Рейтинг_DataGridViewColumn.DataPropertyName = "Рейтинг";
            this.Рейтинг_DataGridViewColumn.HeaderText = "Рейтинг";
            this.Рейтинг_DataGridViewColumn.Name = "Рейтинг_DataGridViewColumn";
            // 
            // Справочник_игроков_BindingSource
            // 
            this.Справочник_игроков_BindingSource.DataMember = "Справочник игроков";
            this.Справочник_игроков_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Справочник_игроков_TableAdapter
            // 
            this.Справочник_игроков_TableAdapter.ClearBeforeFill = true;
            // 
            // catalog_players_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 361);
            this.Controls.Add(this.Справочник_игроков_DataGridView);
            this.Name = "catalog_players_form";
            this.Text = "catalog_players_form";
            this.Load += new System.EventHandler(this.catalog_players_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Справочник_игроков_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Справочник_игроков_BindingSource;
        private кп2_DataSetTableAdapters.Справочник_игроковTableAdapter Справочник_игроков_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_игрока_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчетсво_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Город_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мобильный_телефон_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Рейтинг_DataGridViewColumn;
    }
}