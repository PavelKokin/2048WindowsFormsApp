namespace _2048WindowsFormsApp
{
    partial class InputMapSizeForm
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
            this.titleTextLabel = new System.Windows.Forms.Label();
            this.mapSizeTextBox = new System.Windows.Forms.TextBox();
            this.acceptMapSizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextLabel
            // 
            this.titleTextLabel.AutoSize = true;
            this.titleTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextLabel.Location = new System.Drawing.Point(13, 13);
            this.titleTextLabel.Name = "titleTextLabel";
            this.titleTextLabel.Size = new System.Drawing.Size(284, 25);
            this.titleTextLabel.TabIndex = 0;
            this.titleTextLabel.Text = "Введите размерность поля";
            // 
            // mapSizeTextBox
            // 
            this.mapSizeTextBox.Location = new System.Drawing.Point(18, 42);
            this.mapSizeTextBox.Name = "mapSizeTextBox";
            this.mapSizeTextBox.Size = new System.Drawing.Size(274, 20);
            this.mapSizeTextBox.TabIndex = 1;
            // 
            // acceptMapSizeButton
            // 
            this.acceptMapSizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptMapSizeButton.Location = new System.Drawing.Point(18, 69);
            this.acceptMapSizeButton.Name = "acceptMapSizeButton";
            this.acceptMapSizeButton.Size = new System.Drawing.Size(274, 23);
            this.acceptMapSizeButton.TabIndex = 2;
            this.acceptMapSizeButton.Text = "OK";
            this.acceptMapSizeButton.UseVisualStyleBackColor = true;
            this.acceptMapSizeButton.Click += new System.EventHandler(this.acceptMapSizeButton_Click);
            // 
            // InputMapSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 106);
            this.Controls.Add(this.acceptMapSizeButton);
            this.Controls.Add(this.mapSizeTextBox);
            this.Controls.Add(this.titleTextLabel);
            this.Name = "InputMapSizeForm";
            this.Text = "Размер поля";
            this.Load += new System.EventHandler(this.InputMapSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTextLabel;
        private System.Windows.Forms.TextBox mapSizeTextBox;
        private System.Windows.Forms.Button acceptMapSizeButton;
    }
}