using Kursova.Class;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova
{
    public partial class LogForm : Form
    {
        private string path = "Save.json";
        public LogForm()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Login = BoxLogin.Text;
            string password1 = Password1.Text;
            string password2 = Password2.Text;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            if (BoxLogin.Text.Length != 10)
            {
                MessageBox.Show("Ваш Login повинен мати вигляд 0682932409");
                BoxLogin.Text = "";
                Password1.Text = "";
                Password2.Text = "";
                return;
            }
            else
            {
                if (password1 != password2)
                {
                    MessageBox.Show("Password mismatch!!!");
                    Password1.Text = "";
                    Password2.Text = "";
                }
                else
                {
                    try
                    {
                        UserRepos userRepos = new UserRepos();
                        userRepos.RegisterUser(Login, password1);
                        UserRepos.SaveUsers(path);

                        MessageBox.Show("Регистрация прошла успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HomeForm form3 = new HomeForm();
                        form3.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(BoxLogin.Text, out _))
            {
                BoxLogin.Text = string.Empty;
            }
        }
    }
}
