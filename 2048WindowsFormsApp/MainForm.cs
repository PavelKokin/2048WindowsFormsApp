using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        public int MapSize;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore;
        public User user = new User("");
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            NameForm userNameForm = new NameForm(user);
            var result = userNameForm.ShowDialog(this);
            while (user.Name == "" && result != DialogResult.Cancel)
            {
                result = userNameForm.ShowDialog(this);
            }
            if (result != DialogResult.OK)
            {
                this.Close();
                return;
            }
            InputMapSizeForm mapSizeForm = new InputMapSizeForm(MapSize);
            result = mapSizeForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Close();
                return;
            }
            MapSize = mapSizeForm.GetMapSize();
            ClientSize = new Size(15 + 75 * MapSize, 105 + 75 * MapSize);
            InitMap(MapSize);
            bestScore = GetBestScore();
            GenerateNumber();
            UpdateScore();
        }
        private void InitMap(int MapSize)
        {
            labelsMap = new Label[MapSize, MapSize];
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label gameLabel = new Label();
            gameLabel.BackColor = Color.FromArgb(205, 193, 180);
            gameLabel.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gameLabel.Size = new Size(70, 70);
            gameLabel.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 75;
            int y = 100 + indexRow * 75;
            gameLabel.Location = new Point(x, y);
            gameLabel.TextChanged += GameLabel_TextChanged;
            return gameLabel;
        }

        private void GameLabel_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            UpdateLabelBackColor(label);
        }

        private void UpdateLabelBackColor(Label label)
        {
            var exp = 0;
            if (label.Text == string.Empty)
            {
                exp = 0;
            }
            else
            {
                var number = Convert.ToInt32(label.Text);
                exp = (int)Math.Log(number, 2);
            }
            Color[] colors = new Color[12];
            colors[0] = Color.FromArgb(205, 193, 180);
            colors[1] = Color.FromArgb(238, 228, 218);
            colors[2] = Color.FromArgb(239, 223, 197);
            colors[3] = Color.FromArgb(242, 177, 121);
            colors[4] = Color.FromArgb(245, 149, 99);
            colors[5] = Color.FromArgb(246, 124, 95);
            colors[6] = Color.FromArgb(246, 94, 59);
            colors[7] = Color.FromArgb(239, 206, 115);
            colors[8] = Color.FromArgb(239, 202, 99);
            colors[9] = Color.FromArgb(239, 198, 82);
            colors[10] = Color.FromArgb(239, 194, 66);
            colors[11] = Color.FromArgb(239, 194, 99);
            label.BackColor = colors[exp];
        }

        private int GetBestScore()
        {
            bestScore = 0;
            var path = "BestScore.txt";
            var fileBestScore = new FileInfo(path);
            if (fileBestScore.Exists)
            {
                var reader = new StreamReader(path);
                bestScore = int.Parse(reader.ReadToEnd());
                reader.Close();
            }
            return bestScore;
        }
        private void UpdateScore()
        {
            scoreValueLabel.Text = score.ToString();
            if (score > bestScore)
            {
                bestScoreValueLabel.Text = score.ToString();
            }
            else
            {
                bestScoreValueLabel.Text = bestScore.ToString();
            }
        }
        private void GenerateNumber()
        {
            while (true)
            {
                var numberLabel = random.Next(MapSize * MapSize);
                int indexRow = numberLabel / MapSize;
                int indexColumn = numberLabel % MapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var valueCell = random.Next(5);
                    if (valueCell == 4)
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }
                    break;
                }
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }
            bool iSMerged = false;
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var value = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (value * 2).ToString();
                                        iSMerged = true;
                                        score += value * 2;
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, k].Text == labelsMap[i, j].Text)
                                    {
                                        var value = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (value * 2).ToString();
                                        iSMerged = true;
                                        score += value * 2;
                                        labelsMap[i, k].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                    {
                                        var value = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (value * 2).ToString();
                                        iSMerged = true;
                                        score += value * 2;
                                        labelsMap[k, j].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                    {
                                        var value = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (value * 2).ToString();
                                        iSMerged = true;
                                        score += value * 2;
                                        labelsMap[k, j].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            UpdateScore();
            if (IsFullMap() && !iSMerged)
            {
                MessageBox.Show("Конец игры");
                return;
            }
            GenerateNumber();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (score > bestScore)
            {
                var path = "BestScore.txt";
                var writer = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                writer.WriteLine(score);
                writer.Close();
            }
            user.AcceptScore(score);
            UserResultStorage.SaveUserResult(user);
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleForm ruleForm = new RuleForm();
            ruleForm.ShowDialog();
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsFullMap()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void viewResultTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultTableForm userResultForm = new ResultTableForm();
            userResultForm.ShowDialog();
        }
    }
}
