namespace _2048WindowsFormsApp
{
    partial class NameForm
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
            this.titleNameTextLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.acceptNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleNameTextLabel
            // 
            this.titleNameTextLabel.AutoSize = true;
            this.titleNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleNameTextLabel.Location = new System.Drawing.Point(12, 9);
            this.titleNameTextLabel.Name = "titleNameTextLabel";
            this.titleNameTextLabel.Size = new System.Drawing.Size(144, 24);
            this.titleNameTextLabel.TabIndex = 0;
            this.titleNameTextLabel.Text = "Введите имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // acceptNameButton
            // 
            this.acceptNameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptNameButton.Location = new System.Drawing.Point(16, 64);
            this.acceptNameButton.Name = "acceptNameButton";
            this.acceptNameButton.Size = new System.Drawing.Size(140, 23);
            this.acceptNameButton.TabIndex = 2;
            this.acceptNameButton.Text = "OK";
            this.acceptNameButton.UseVisualStyleBackColor = true;
            this.acceptNameButton.Click += new System.EventHandler(this.acceptNameButton_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 101);
            this.Controls.Add(this.acceptNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.titleNameTextLabel);
            this.Name = "NameForm";
            this.Text = "Имя пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleNameTextLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button acceptNameButton;
    }
}