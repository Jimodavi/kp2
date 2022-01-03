
namespace kp2_2
{
    partial class list_participants_form
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
            this.Списки_участников_DataGridView = new System.Windows.Forms.DataGridView();
            this.Код_учаcтника_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_турнира_DataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_игрока1_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_игроков_BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Код_игрока2_DataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Справочник_игроков_BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Cписки_участников_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cписки_участников_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Списки_участниковTableAdapter();
            this.Справочник_игроков_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.Справочник_игроковTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Списки_участников_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cписки_участников_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Списки_участников_DataGridView
            // 
            this.Списки_участников_DataGridView.AutoGenerateColumns = false;
            this.Списки_участников_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Списки_участников_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_учаcтника_DataGridViewColumn,
            this.Код_турнира_DataGridViewColumn,
            this.Код_игрока1_DataGridViewColumn,
            this.Код_игрока2_DataGridViewColumn});
            this.Списки_участников_DataGridView.DataSource = this.Cписки_участников_BindingSource;
            this.Списки_участников_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Списки_участников_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Списки_участников_DataGridView.Name = "Списки_участников_DataGridView";
            this.Списки_участников_DataGridView.Size = new System.Drawing.Size(553, 425);
            this.Списки_участников_DataGridView.TabIndex = 0;
            this.Списки_участников_DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Списки_участников_DataGridView_CellBeginEdit);
            this.Списки_участников_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Списки_участников_DataGridView_CellEndEdit);
            this.Списки_участников_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Списки_участников_DataGridView_CellMouseClick);
            this.Списки_участников_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Списки_участников_DataGridView_DataError);
            this.Списки_участников_DataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Списки_участников_DataGridView_UserAddedRow);
            // 
            // Код_учаcтника_DataGridViewColumn
            // 
            this.Код_учаcтника_DataGridViewColumn.DataPropertyName = "Код учаcтника";
            this.Код_учаcтника_DataGridViewColumn.HeaderText = "Код учаcтника";
            this.Код_учаcтника_DataGridViewColumn.Name = "Код_учаcтника_DataGridViewColumn";
            this.Код_учаcтника_DataGridViewColumn.ReadOnly = true;
            this.Код_учаcтника_DataGridViewColumn.Width = 110;
            // 
            // Код_турнира_DataGridViewColumn
            // 
            this.Код_турнира_DataGridViewColumn.DataPropertyName = "Код турнира";
            this.Код_турнира_DataGridViewColumn.HeaderText = "Код турнира";
            this.Код_турнира_DataGridViewColumn.Name = "Код_турнира_DataGridViewColumn";
            this.Код_турнира_DataGridViewColumn.Visible = false;
            // 
            // Код_игрока1_DataGridViewColumn
            // 
            this.Код_игрока1_DataGridViewColumn.DataPropertyName = "Код игрока 1";
            this.Код_игрока1_DataGridViewColumn.DataSource = this.Справочник_игроков_BindingSource1;
            this.Код_игрока1_DataGridViewColumn.DisplayMember = "Фамилия";
            this.Код_игрока1_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Код_игрока1_DataGridViewColumn.HeaderText = "Игрок 1";
            this.Код_игрока1_DataGridViewColumn.Name = "Код_игрока1_DataGridViewColumn";
            this.Код_игрока1_DataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_игрока1_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_игрока1_DataGridViewColumn.ValueMember = "Код игрока";
            this.Код_игрока1_DataGridViewColumn.Width = 200;
            // 
            // Справочник_игроков_BindingSource1
            // 
            this.Справочник_игроков_BindingSource1.DataMember = "Справочник игроков";
            this.Справочник_игроков_BindingSource1.DataSource = this.кп2_DataSet;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Код_игрока2_DataGridViewColumn
            // 
            this.Код_игрока2_DataGridViewColumn.DataPropertyName = "Код игрока 2";
            this.Код_игрока2_DataGridViewColumn.DataSource = this.Справочник_игроков_BindingSource2;
            this.Код_игрока2_DataGridViewColumn.DisplayMember = "Фамилия";
            this.Код_игрока2_DataGridViewColumn.DisplayStyleForCurrentCellOnly = true;
            this.Код_игрока2_DataGridViewColumn.HeaderText = "Игрок 2";
            this.Код_игрока2_DataGridViewColumn.Name = "Код_игрока2_DataGridViewColumn";
            this.Код_игрока2_DataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_игрока2_DataGridViewColumn.ValueMember = "Код игрока";
            this.Код_игрока2_DataGridViewColumn.Width = 200;
            // 
            // Справочник_игроков_BindingSource2
            // 
            this.Справочник_игроков_BindingSource2.DataMember = "Справочник игроков";
            this.Справочник_игроков_BindingSource2.DataSource = this.кп2_DataSet;
            // 
            // Cписки_участников_BindingSource
            // 
            this.Cписки_участников_BindingSource.DataMember = "Списки участников";
            this.Cписки_участников_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // Cписки_участников_TableAdapter
            // 
            this.Cписки_участников_TableAdapter.ClearBeforeFill = true;
            // 
            // Справочник_игроков_TableAdapter
            // 
            this.Справочник_игроков_TableAdapter.ClearBeforeFill = true;
            // 
            // list_participants_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 425);
            this.Controls.Add(this.Списки_участников_DataGridView);
            this.Name = "list_participants_form";
            this.Text = "list_participants_form";
            this.Load += new System.EventHandler(this.list_participants_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Списки_участников_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Справочник_игроков_BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cписки_участников_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Списки_участников_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Cписки_участников_BindingSource;
        private кп2_DataSetTableAdapters.Списки_участниковTableAdapter Cписки_участников_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_игроков_BindingSource1;
        private кп2_DataSetTableAdapters.Справочник_игроковTableAdapter Справочник_игроков_TableAdapter;
        private System.Windows.Forms.BindingSource Справочник_игроков_BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_учаcтника_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_турнира_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_игрока1_DataGridViewColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_игрока2_DataGridViewColumn;
    }
}