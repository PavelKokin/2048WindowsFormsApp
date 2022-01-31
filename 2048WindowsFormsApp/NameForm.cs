using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class NameForm : Form
    {
        User user;
        public NameForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void acceptNameButton_Click(object sender, EventArgs e)
        {
            var userInput = nameTextBox.Text;
            if (IsValid(userInput))
            {
                user.Name = userInput;
            }
        }
        private bool IsValid(string userInput)
        {

            if (userInput == "")
            {
                MessageBox.Show("Вы не ввели имя! Повторите ввод");
                return false;
            }
            return true;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != (int)' ' && (e.KeyChar < (int)'А' || e.KeyChar > (int)'я'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, используйте только буквы русского алфавита!");
            }
        }
    }
}
