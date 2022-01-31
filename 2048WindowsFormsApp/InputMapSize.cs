using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class InputMapSizeForm : Form
    {
        public int MapSize;
        public InputMapSizeForm(int MapSize)
        {
            InitializeComponent();
            this.MapSize = MapSize;
            return;
        }
        private void InputMapSizeForm_Load(object sender, EventArgs e)
        {

        }
        private void acceptMapSizeButton_Click(object sender, EventArgs e)
        {
            var userInput = mapSizeTextBox.Text;
            if (!int.TryParse(userInput, out int correctUserAnswer))
            {
                MessageBox.Show("Ошибка ввода. Введите число!");
            }
            else
            {
                MapSize = correctUserAnswer;
                this.Close();
            }
        }
        public int GetMapSize()
        {
            return MapSize;
        }
    }
}
