namespace _2048WindowsFormsApp
{
    partial class ResultTableForm
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
            this.userResultDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultDataGridView
            // 
            this.userResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.userScoreColumn});
            this.userResultDataGridView.Location = new System.Drawing.Point(13, 13);
            this.userResultDataGridView.Name = "userResultDataGridView";
            this.userResultDataGridView.Size = new System.Drawing.Size(303, 159);
            this.userResultDataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Имя";
            this.userNameColumn.Name = "userNameColumn";
            // 
            // userScoreColumn
            // 
            this.userScoreColumn.HeaderText = "Результат";
            this.userScoreColumn.Name = "userScoreColumn";
            // 
            // ResultTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 195);
            this.Controls.Add(this.userResultDataGridView);
            this.Name = "ResultTableForm";
            this.Text = "История игр";
            this.Load += new System.EventHandler(this.ResultTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userScoreColumn;
    }
}