
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Сетки_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Сетки_DataGridView
            // 
            this.Сетки_DataGridView.AllowUserToAddRows = false;
            this.Сетки_DataGridView.AllowUserToDeleteRows = false;
            this.Сетки_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Сетки_DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.Сетки_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Сетки_DataGridView.EnableHeadersVisualStyles = false;
            this.Сетки_DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Сетки_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Сетки_DataGridView.Name = "Сетки_DataGridView";
            this.Сетки_DataGridView.ReadOnly = true;
            this.Сетки_DataGridView.Size = new System.Drawing.Size(800, 450);
            this.Сетки_DataGridView.TabIndex = 0;
            // 
            // draws_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Сетки_DataGridView);
            this.Name = "draws_form";
            this.Text = "draws_form";
            this.Load += new System.EventHandler(this.draws_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Сетки_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Сетки_DataGridView;
    }
}