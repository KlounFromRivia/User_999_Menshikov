using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techno.Context;

namespace Techno.UI
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (var db = new TechnoDBContext())
            {
                var user = db.Users.Include(x => x.Role).FirstOrDefault(x => x.UserLogin == txtLogin.Text
                && x.UserPassword == txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Неверный логин/пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CurrectUser.User = user;
                    MessageBox.Show("Добро пожаловать, " + user.UserFIO, "Авторизация пройдена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainOrderForm mof = new MainOrderForm();
                    mof.Owner = this;
                    this.Hide();
                    mof.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
