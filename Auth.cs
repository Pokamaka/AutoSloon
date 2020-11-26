using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSloon
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        DateBase db = new DateBase();

        private string UserLogin = "";
        private string UserPassword = "";

        private void btn_auth_Click(object sender, EventArgs e)
        {
            tb_UserLogin.Enabled = false;
            tb_UserPassword.Enabled = false;
            try
            {
                UserLogin = tb_UserLogin.Text;
                UserPassword = tb_UserPassword.Text;              
            }
            catch
            {
                MessageBox.Show("Не коректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IEnumerable<Accounts> users = db.GetAccounts(1, UserLogin, UserPassword);

            if (users != null)
            {
                foreach (var b in users)
                {
                    if (b.Login == UserLogin && b.Password == UserPassword)
                    {
                        MessageBox.Show("Вы смогли авторизоваться", "Удачно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main M = new Main();
                        this.Hide();
                        M.Show();
                    }
                    else
                    {
                        MessageBox.Show("Вы не смогли авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не смогли авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_UserLogin.Enabled = true;
            tb_UserPassword.Enabled = true;
        }

        private void btn_closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
