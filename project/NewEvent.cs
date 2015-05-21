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

    public partial class NewEvent : Form
    {

        static string myConnectionString = "server=172.18.12.55;uid=admin;" +
                                            "pwd=admin;database=kpodb;";
        MySqlConnection conn = null;

        User userNewEvent = new User();
        main MainForm;

        public NewEvent(main backForm, User user)
        {
            InitializeComponent();
            userNewEvent = user;
            MainForm = backForm;

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NewEvent_Load(object sender, EventArgs e)
        {
            comboBoxHours.SelectedIndex = 0;
            comboBoxMinutes.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 1;
            comboBoxType.SelectedIndex = 0;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || textBoxDescription.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    string autoAccept = "0";
                    if(userNewEvent.isAdmin) autoAccept = "1";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO events (Title, Type, Date, Hours, Minutes, Priority, Description, Accepted, IDUser) VALUES ('" + 
                                        textBoxTitle.Text          + "', '" + 
                                        comboBoxType.Text          + "', '" +
                                        dateTimePicker1.Text       + "', '" +
                                        comboBoxHours.Text         + "', '" +
                                        comboBoxMinutes.Text       + "', '" +
                                        comboBoxPriority.Text      + "', '" +
                                        textBoxDescription.Text    + "', '" +
                                        autoAccept                 + "', '" +
                                        userNewEvent.id            + "')";
                    cmd.ExecuteNonQuery();
                    if (autoAccept == "0") MessageBox.Show("Информация о мероприятии отправлена на рассмотрение", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else MessageBox.Show("Мероприятие добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: {0}" + ex.ToString());
                }
                buttonClear.PerformClick();
                //MainForm.Show();
                //this.Hide();
            }
        }

        public void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }

        public void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxTitle.Clear();
            textBoxDescription.Clear();
            comboBoxHours.SelectedIndex = 0;
            comboBoxMinutes.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 1;
            comboBoxType.SelectedIndex = 0;
        }

        // для тестов
        // для тестов
        // для тестов

        public string getTitle()
        {
            return textBoxTitle.Text.Trim();
        }
        public string getDescription()
        {
            return textBoxDescription.Text;
        }
        public string getType()
        {
            return comboBoxType.Text;
        }
        public string getPriority()
        {
            return comboBoxPriority.Text;
        }
        public void setTitle(string title)
        {
            textBoxTitle.Text = title;
        }
        public void setDescription(string description)
        {
            textBoxDescription.Text = description;
        }

        public void fillForm(string title, string description)
        {
            setTitle(title);
            setDescription(description);
            comboBoxHours.SelectedIndex = 0;
            comboBoxMinutes.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 1;
            comboBoxType.SelectedIndex = 0;
            dateTimePicker1.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            if (dateTimePicker1.Handle == null)
                System.Threading.Thread.Sleep(0);
            dateTimePicker1.Checked = false;
            DateTime result = dateTimePicker1.Value;
            dateTimePicker1.Text = DateTime.Today.ToString(dateTimePicker1.CustomFormat);
        }
        public bool isMainVisible()
        {
            return MainForm.Visible;
        }
    }
}
