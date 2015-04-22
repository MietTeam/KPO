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

    public partial class main : Form
    {
        static string myConnectionString = "server=172.18.12.55;uid=admin;" +
                                            "pwd=qwerty;database=mnepizdec;";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        bool flag = true;
        NewEvent NewEventForm;
        int j = 0, i = 0;

        User userMainForm = new User();
        public main(User user)
        {
            InitializeComponent();
            userMainForm = user;
            NewEventForm = new NewEvent(this, userMainForm);
            timer1.Interval = 3000;
            
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
            catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        // предотвращает мигание вкладок при их переключении
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 
        
        private void main_Load(object sender, EventArgs e)
        {
            buttonUpdate.PerformClick();
            checkIfAdmin(userMainForm);
            dataGridAcceptedEvents.ClearSelection();
            timer1.Start();
            
        }

        public void checkIfAdmin(User user)
        {
            if (!user.isAdmin)
            {
                dataGridNewEvents.Columns[7].Visible = false;
                dataGridNewEvents.Columns[8].Visible = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
        private void CheckEvents()
        {
            for (int m = 0; m < 6; m++)
            {
                if (dataGridAcceptedEvents.Rows[m].Cells["Data"].Value.ToString() == DateTime.Now.ToString("dd/MM/yyyy"))
                {
                    MessageBox.Show("Сегодня событие " + dataGridAcceptedEvents.Rows[m].Cells[i++].Value.ToString());
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridAcceptedEvents.Rows.Clear();
            dataGridNewEvents.Rows.Clear();
            dataGridMessages.Rows.Clear();
            dataGridMessages.RowTemplate.Height = 50;
            
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM events";
                rdr = cmd.ExecuteReader();
                String events = "";
                i = 0;
                while (rdr.Read())
                {
                    if (rdr.GetInt16("Accepted") == 1)
                    {
                        int m = dataGridAcceptedEvents.Rows.Add();
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetInt32("ID_event");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Title");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Type");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Priority");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetMySqlDateTime("Date");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Hours") + ":" + rdr.GetString("Minutes");
                        dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Description");
                        if (flag)
                        {
                            if (dataGridAcceptedEvents.Rows[m].Cells["Data"].Value.ToString() == DateTime.Now.ToString("dd/MM/yyyy"))
                            {
                                events += dataGridAcceptedEvents.Rows[m].Cells[1].Value.ToString() + "\n";
                            }
                        }
                            i = 0;
                    }
                    else
                    {
                        int n = dataGridNewEvents.Rows.Add();
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetInt32("ID_event");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Title");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Type");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Priority");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetMySqlDateTime("Date");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Hours") + ":" + rdr.GetString("Minutes"); ;
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Description");
                        dataGridNewEvents.Rows[n].Cells["ID_user"].Value = rdr.GetString("IDUser");
                        j = 0;
                    }
                }
                if(flag)
                {
                    MessageBox.Show("Сегодня события: \n" + events);
                }
                flag = false;
                rdr.Close();
                cmd.CommandText = "SELECT * FROM messages WHERE ID_user = '" + userMainForm.id + "'";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int k = dataGridMessages.Rows.Add();
                    dataGridMessages.Rows[k].Cells[0].Value = rdr.GetDateTime("Date").ToString();
                    dataGridMessages.Rows[k].Cells[1].Value = rdr.GetString("Message");
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}" + ex.ToString());

            }
            finally
            {
                if (rdr != null) rdr.Close();
            }
        }

        // кнопки "приянть" и "отклонить"
        private void dataGridNewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eventID = dataGridNewEvents.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string eventStatus = "";
                if (e.ColumnIndex == 7)
                {
                    cmd.CommandText = "UPDATE events SET Accepted='1' WHERE ID_event='" + eventID + "'";
                    cmd.ExecuteNonQuery();
                    eventStatus = "принята.";
                }
                if (e.ColumnIndex == 8)
                {
                    cmd.CommandText = "DELETE FROM events WHERE ID_event='" + eventID + "'";
                    cmd.ExecuteNonQuery();
                    eventStatus = "отклонена.";
                }
                cmd.CommandText = "INSERT INTO messages (ID_user, Message, Date) VALUES ('" + dataGridNewEvents.Rows[e.RowIndex].Cells["ID_user"].Value.ToString() + "', '" +
                                        "Ваша заявка № " + dataGridNewEvents.Rows[e.RowIndex].Cells[0].Value.ToString() +
                                        " на добавление события " + dataGridNewEvents.Rows[e.RowIndex].Cells[1].Value.ToString() +
                                        " " + eventStatus + "', '" + DateTime.Now.ToString() + "')";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}" + ex.ToString());
            }
            buttonUpdate.PerformClick();
        }

        private void tabChanged()
        {
            if (dataGridMessages.RowCount == 0) textBoxNoNewMessages.Visible = true;
            else textBoxNoNewMessages.Visible = false;

            if (dataGridNewEvents.RowCount == 0) textBoxNoNewEvents.Visible = true;
            else textBoxNoNewEvents.Visible = false;

            if (dataGridAcceptedEvents.RowCount == 0) textBoxNoAcceptedEvents.Visible = true;
            else textBoxNoNewEvents.Visible = false;

            if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                buttonDeleteMessages.Enabled = true;
            }
            else buttonDeleteMessages.Enabled = false;
        }

        // появление кнопки "удалить все сообщения"
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabChanged();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            NewEventForm.Show();
            this.Hide();
        }

        // смена пользователя
        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorisation auth = new authorisation();
            auth.Show();
            this.Hide();
        }

        private void buttonDeleteMessages_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM messages WHERE ID_user='" + userMainForm.id + "'";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}" + ex.ToString());
            }
            buttonUpdate.PerformClick();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Электронный секретарь\n" +
                            "Версия: 1.0\n\n" +
                            "Жигулин Вячеслав Станиславович\n" +
                            "Мухамадиев Юрий Олегович\n" +
                            "Тимофеев Александр Сергеевич\n\n" +
                            "МИЭТ, 2015\n", "О программе");
        }

        private void dataGridAcceptedEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteAcceptedEvent.Enabled = true;
        }

        private void buttonDeleteAcceptedEvent_Click(object sender, EventArgs e)
        {
            int rowIndexToDelete = dataGridAcceptedEvents.SelectedCells[0].RowIndex;


            string eventID = dataGridAcceptedEvents.Rows[rowIndexToDelete].Cells[0].Value.ToString();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM events WHERE ID_event='" + eventID + "'";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}" + ex.ToString());
            }
            buttonUpdate.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonUpdate.PerformClick();
            
        }
    }
}
