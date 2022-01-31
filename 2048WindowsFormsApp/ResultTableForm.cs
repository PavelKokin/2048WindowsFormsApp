using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class ResultTableForm : Form
    {
        public ResultTableForm()
        {
            InitializeComponent();
        }

        private void ResultTableForm_Load(object sender, EventArgs e)
        {
            var users = UserResultStorage.GetUserResults();
            foreach (var user in users)
            {
                userResultDataGridView.Rows.Add(user.Name, user.Score);
            }
            var max = 0;
            var indexMaxResultRow = 0;
            for (int i=0; i<userResultDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(userResultDataGridView.Rows[i].Cells[1].Value) > max)
                {
                    indexMaxResultRow = i;
                    max = Convert.ToInt32(userResultDataGridView.Rows[i].Cells[1].Value);
                }
            }
            userResultDataGridView.Rows[indexMaxResultRow].DefaultCellStyle.Font = new Font(userResultDataGridView.DefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
