using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Kursova.Class;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;

namespace Kursova
{
    public partial class Log : Form
    {
        string filePath = "Save.json";
        public Log()
        {
            InitializeComponent();
        }
        public static List<RegistrUser> registrUsers = null;
        public List<RegistrUser> ReadUserRecords()
        {
            List<RegistrUser>? users = new List<RegistrUser>();
            if (File.ReadLines("Save.json").ToList() == null)
                users = null;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("Save.json").ToList();
                foreach (string line in lines)
                {
                    RegistrUser? user;
                    user = JsonSerializer.Deserialize<RegistrUser>(line);
                    users.Add(user);
                }
            }
            return users;
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            string login = Name1.Text;
            string password = Password.Text;

            registrUsers = ReadUserRecords();

            if (registrUsers != null)
            {
                bool temp = false;
                foreach (RegistrUser user in registrUsers)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp == true)
                {
                    // Вход выполнен успешно
                    MessageBox.Show("Вход выполнен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeForm homeforme = new HomeForm();
                    homeforme.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверные логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (login == "0000000000" && password == "00000")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
            }
        }
            private void linkRegistr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                var Registr = new LogForm();
                Registr.Show();
                this.Hide();
            }

            private void Name_TextChanged(object sender, EventArgs e)
            {
                if (!int.TryParse(Name1.Text, out _))
                {
                    Name1.Text = string.Empty;
                }

            }

            private void button1_Click(object sender, EventArgs e)
            {
                var form = new Form1();
                form.Show();
                this.Hide();
            }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.form1.Close();
            this.Close();
        }
    }
}