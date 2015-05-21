using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace project
{
    public struct User
    {
        public int id;
        public string login;
        public string password;
        public bool isAdmin;
    }

    public partial class authorisation : Form
    {
        User user = new User();

        static string myConnectionString = "server=172.18.12.55;uid=admin;" +
                                            "pwd=admin;database=kpodb;";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;



        main MainForm;
        public authorisation()
        {
            InitializeComponent();

            // автологин админом
            textBoxLogin.Text = "admin";
            textBoxPassword.Text = "admin";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (CheckAccess())
            {
                conn.Close();
                MainForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Неверный логин/пароль", "Ошибка авторизации");
        }

        public bool CheckAccess()
        {
            bool flag = false;
            string stm = "SELECT * FROM accounts";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            try
            {
                rdr = cmd.ExecuteReader();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка: Невозможно связаться с удаленным сервером");
                this.Close();
                Environment.Exit(1);
            }
            while (rdr.Read())
            {
                if (textBoxLogin.Text == rdr.GetString("Login") && textBoxPassword.Text == rdr.GetString("Password"))
                {
                    user.id = rdr.GetInt32("ID_user");
                    user.login = textBoxLogin.Text;
                    user.password = textBoxPassword.Text;
                    if (rdr.GetInt16("IsAdmin") == 1) user.isAdmin = true;
                    else user.isAdmin = false;
                    MainForm = new main(user);
                    flag = true;
                }
            }
            rdr.Close();
            return flag;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) textBoxPassword.UseSystemPasswordChar = true;
            if(checkBox1.Checked) textBoxPassword.UseSystemPasswordChar = false; 
        }

        // для тестов
        // для тестов
        // для тестов

        public void setLoginPass(string name,string password)
        {
            textBoxLogin.Text = name;
            textBoxPassword.Text = password;
        }
        public bool authorisationVisible()
        {
            return this.Visible;
        }
    }
}
