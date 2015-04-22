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
                                            "pwd=qwerty;database=mnepizdec;";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;

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
        


        private void buttonSend_Click(object sender, EventArgs e)
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
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: {0}" + ex.ToString());
                }
                buttonClear.PerformClick();
                MainForm.Show();
                this.Hide();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Show();  
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            textBoxDescription.Clear();
            comboBoxHours.SelectedIndex = 0;
            comboBoxMinutes.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 1;
            comboBoxType.SelectedIndex = 0;
        }

    }
}
