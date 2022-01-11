
namespace kp2_2
{
    partial class draws_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Сетки_DataGridView = new System.Windows.Forms.DataGridView();
            this.кп2_DataSet = new kp2_2.кп2_DataSet();
            this.Сетки_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Сетки_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.СеткиTableAdapter();
            this.Расписание_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Расписание_TableAdapter = new kp2_2.кп2_DataSetTableAdapters.РасписаниеTableAdapter();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Сетки_DataGridView
            // 
            this.Сетки_DataGridView.AllowUserToAddRows = false;
            this.Сетки_DataGridView.AllowUserToDeleteRows = false;
            this.Сетки_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Сетки_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Сетки_DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.Сетки_DataGridView.EnableHeadersVisualStyles = false;
            this.Сетки_DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Сетки_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Сетки_DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.Сетки_DataGridView.Name = "Сетки_DataGridView";
            this.Сетки_DataGridView.ReadOnly = true;
            this.Сетки_DataGridView.Size = new System.Drawing.Size(1067, 512);
            this.Сетки_DataGridView.TabIndex = 0;
            // 
            // кп2_DataSet
            // 
            this.кп2_DataSet.DataSetName = "кп2_DataSet";
            this.кп2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Сетки_BindingSource
            // 
            this.Сетки_BindingSource.DataMember = "Сетки";
            this.Сетки_BindingSource.DataSource = this.кп2_DataSet;
            // 
            // Сетки_TableAdapter
            // 
            this.Сетки_TableAdapter.ClearBeforeFill = true;
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
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 519);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(241, 40);
            this.button.TabIndex = 1;
            this.button.Text = "Обновить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // draws_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Сетки_DataGridView);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "draws_form";
            this.Load += new System.EventHandler(this.draws_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кп2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Расписание_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Сетки_DataGridView;
        private кп2_DataSet кп2_DataSet;
        private System.Windows.Forms.BindingSource Сетки_BindingSource;
        private кп2_DataSetTableAdapters.СеткиTableAdapter Сетки_TableAdapter;
        private System.Windows.Forms.BindingSource Расписание_BindingSource;
        private кп2_DataSetTableAdapters.РасписаниеTableAdapter Расписание_TableAdapter;
        private System.Windows.Forms.Button button;
    }
}