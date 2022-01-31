namespace _2048WindowsFormsApp
{
    partial class MainForm
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
            this.scoreTitleTextLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.bestScoreTitleTextLabel = new System.Windows.Forms.Label();
            this.bestScoreValueLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreTitleTextLabel
            // 
            this.scoreTitleTextLabel.AutoSize = true;
            this.scoreTitleTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTitleTextLabel.Location = new System.Drawing.Point(12, 34);
            this.scoreTitleTextLabel.Name = "scoreTitleTextLabel";
            this.scoreTitleTextLabel.Size = new System.Drawing.Size(64, 24);
            this.scoreTitleTextLabel.TabIndex = 0;
            this.scoreTitleTextLabel.Text = "Счет:";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreValueLabel.Location = new System.Drawing.Point(111, 34);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(21, 24);
            this.scoreValueLabel.TabIndex = 1;
            this.scoreValueLabel.Text = "0";
            // 
            // bestScoreTitleTextLabel
            // 
            this.bestScoreTitleTextLabel.AutoSize = true;
            this.bestScoreTitleTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoreTitleTextLabel.Location = new System.Drawing.Point(12, 62);
            this.bestScoreTitleTextLabel.Name = "bestScoreTitleTextLabel";
            this.bestScoreTitleTextLabel.Size = new System.Drawing.Size(89, 24);
            this.bestScoreTitleTextLabel.TabIndex = 2;
            this.bestScoreTitleTextLabel.Text = "Лучший:";
            // 
            // bestScoreValueLabel
            // 
            this.bestScoreValueLabel.AutoSize = true;
            this.bestScoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoreValueLabel.Location = new System.Drawing.Point(111, 62);
            this.bestScoreValueLabel.Name = "bestScoreValueLabel";
            this.bestScoreValueLabel.Size = new System.Drawing.Size(21, 24);
            this.bestScoreValueLabel.TabIndex = 3;
            this.bestScoreValueLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem,
            this.viewResultTableToolStripMenuItem,
            this.gameRulesToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.restartGameToolStripMenuItem.Text = "Рестарт";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // viewResultTableToolStripMenuItem
            // 
            this.viewResultTableToolStripMenuItem.Name = "viewResultTableToolStripMenuItem";
            this.viewResultTableToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.viewResultTableToolStripMenuItem.Text = "Показать историю игр";
            this.viewResultTableToolStripMenuItem.Click += new System.EventHandler(this.viewResultTableToolStripMenuItem_Click);
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gameRulesToolStripMenuItem.Text = "Правила игры";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitGameToolStripMenuItem.Text = "Выход";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 449);
            this.Controls.Add(this.bestScoreValueLabel);
            this.Controls.Add(this.bestScoreTitleTextLabel);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.scoreTitleTextLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTitleTextLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label bestScoreTitleTextLabel;
        private System.Windows.Forms.Label bestScoreValueLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
    }
}

