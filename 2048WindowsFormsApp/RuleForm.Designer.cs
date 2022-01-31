namespace _2048WindowsFormsApp
{
    partial class RuleForm
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
            this.rulesTextLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rulesTextLabel
            // 
            this.rulesTextLabel.AutoSize = true;
            this.rulesTextLabel.Location = new System.Drawing.Point(12, 13);
            this.rulesTextLabel.Name = "rulesTextLabel";
            this.rulesTextLabel.Size = new System.Drawing.Size(323, 13);
            this.rulesTextLabel.TabIndex = 0;
            this.rulesTextLabel.Text = "1. В каждом раунде появляется плитка номинала «2» или «4»";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(456, 13);
            this.label.TabIndex = 1;
            this.label.Text = "2. Нажатием клавиш игрок может переместить все плитки в соответствующую сторону";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "3. Если рядом расположенные ячейки имеют одинаковый номинал их значение суммирует" +
    "ся";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "4. За каждое соединение игровые очки увеличиваются на номинал получившейся плитки" +
    ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "5. Игра заканчивается поражением, если после очередного хода невозможно совершить" +
    " действие.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "6. Игра заканчивается победой, если игрок получил плитку номиналом 2048.";
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 110);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rulesTextLabel);
            this.Name = "RuleForm";
            this.Text = "Правила игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rulesTextLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}