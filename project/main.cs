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
                                            "pwd=admin;database=kpodb;";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        NewEvent NewEventForm;

        string todayEventsList;
        todayEvent todayEventForm;
        int j = 0, i = 0;

        User userMainForm;

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
            todayEventForm = new todayEvent(todayEventsList);
            todayEventForm.Show();
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

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridAcceptedEvents.Rows.Clear();
            dataGridNewEvents.Rows.Clear();
            dataGridMessages.Rows.Clear();
            dataGridMessages.RowTemplate.Height = 50;
            todayEventsList = "";
            
            
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM events";
                rdr = cmd.ExecuteReader();
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
                        monthCalendar1.AddBoldedDate(DateTime.ParseExact(dataGridAcceptedEvents.Rows[m].Cells["Data"].Value.ToString(),"dd/MM/yyyy",null));
                        if (dataGridAcceptedEvents.Rows[m].Cells["Data"].Value.ToString() == DateTime.Now.ToString("dd/MM/yyyy"))
                        {
                            todayEventsList += dataGridAcceptedEvents.Rows[m].Cells["NameEvent"].Value.ToString() + " в " +
                                                      dataGridAcceptedEvents.Rows[m].Cells["Time"].Value.ToString() + System.Environment.NewLine;
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
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Hours") + ":" + rdr.GetString("Minutes");
                        dataGridNewEvents.Rows[n].Cells[j++].Value = rdr.GetString("Description");
                        dataGridNewEvents.Rows[n].Cells["ID_user"].Value = rdr.GetString("IDUser");
                        j = 0;
                    }
                }
                monthCalendar1.UpdateBoldedDates();
                tabControl1.TabPages[0].Text = "Утвержденные события (" + dataGridAcceptedEvents.DisplayedRowCount(true).ToString() + ")";
                tabControl1.TabPages[1].Text = "Рассматриваемые события (" + dataGridNewEvents.DisplayedRowCount(true).ToString() + ")";
                tabControl1.TabPages[2].Text = "Сообщения (" + dataGridMessages.DisplayedRowCount(true).ToString() + ")";

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
            if (dataGridMessages.RowCount == 0)
            {
                textBoxNoNewMessages.Visible = true;
                textBoxNoNewMessages.BringToFront();
                dataGridMessages.Enabled = false;
            }
            else
            {
                textBoxNoNewMessages.Visible = false;
                dataGridMessages.Enabled = true;
            }

            if (dataGridNewEvents.RowCount == 0)
            {
                textBoxNoNewEvents.Visible = true;
                textBoxNoNewEvents.BringToFront();
                dataGridNewEvents.Enabled = false;
            }
            else
            {
                textBoxNoNewEvents.Visible = false;
                dataGridNewEvents.Enabled = true;
            }

            if (dataGridAcceptedEvents.RowCount == 0)
            {
                textBoxNoAcceptedEvents.Visible = true;
                textBoxNoAcceptedEvents.BringToFront();
                dataGridAcceptedEvents.Enabled = false;
            }
            else
            {
                textBoxNoAcceptedEvents.Visible = false;
                dataGridAcceptedEvents.Enabled = true;
            }
            

            if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                buttonDeleteMessages.Enabled = true;
            }
            else buttonDeleteMessages.Enabled = false;

            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                deleteEventToolStripMenuItem.Enabled = true;
            }
            else deleteEventToolStripMenuItem.Enabled = false;
        }

        // появление кнопки "удалить все сообщения"
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabChanged();
        }

        // смена пользователя
        public void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
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
            if(userMainForm.isAdmin)
            deleteEventToolStripMenuItem.Enabled = true;
            else deleteEventToolStripMenuItem.Enabled = false;
        }

        private void dataGridAcceptedEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridAcceptedEvents.Rows[e.RowIndex].Cells[1].Value.ToString() + "\n" +
                            "Приоритет:\t" + dataGridAcceptedEvents.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n" +
                            "Тип:\t\t" + dataGridAcceptedEvents.Rows[e.RowIndex].Cells[3].Value.ToString() + "\n" +
                            "Дата:\t\t" + dataGridAcceptedEvents.Rows[e.RowIndex].Cells[4].Value.ToString() + "\n" +
                            "Время:\t\t" + dataGridAcceptedEvents.Rows[e.RowIndex].Cells[5].Value.ToString() + "\n" +
                            "Описание: \n" + dataGridAcceptedEvents.Rows[e.RowIndex].Cells[6].Value.ToString(), "Подробности");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // buttonUpdate.PerformClick();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int count = 0;
            for(int i = 0; i < dataGridAcceptedEvents.RowCount; i++)
            {
                dataGridAcceptedEvents.Rows[i].DefaultCellStyle.BackColor = Color.White;
                if (dataGridAcceptedEvents.Rows[i].Cells["Data"].Value.ToString() == monthCalendar1.SelectionStart.ToString("dd/MM/yyyy"))
                {
                    dataGridAcceptedEvents.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    count++;
                }
            }
            labelSelectedDateEvents.Text = "Событий в выделенный день: " + count.ToString();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEventForm.Show();
            this.Hide();
        }
        

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void todayEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todayEventForm = new todayEvent(todayEventsList);
            todayEventForm.Show();
        } 

        // для тестов
        // для тестов
        // для тестов

        public bool PushButtons()
        {
            return buttonUpdate.IsHandleCreated;
        }

        public string[] getLastEvent()
        {
            string[] str = new string[2];
            int m = dataGridAcceptedEvents.Rows.Count - 1;
            str[0] = dataGridAcceptedEvents.Rows[m].Cells["NameEvent"].Value.ToString();
            //dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Type");
            //dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Priority");
            //dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetMySqlDateTime("Date");
            //dataGridAcceptedEvents.Rows[m].Cells[i++].Value = rdr.GetString("Hours") + ":" + rdr.GetString("Minutes");
            str[1] = dataGridAcceptedEvents.Rows[m].Cells["Discription"].Value.ToString();

            return str;
        }
        
        public void deleteTestEvent()
        {
            string eventID = dataGridAcceptedEvents.Rows[dataGridAcceptedEvents.Rows.Count - 1].Cells[0].Value.ToString();
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

        public bool todayEventsVisible()
        {
            todayEventForm = new todayEvent(todayEventsList);
            todayEventForm.Show();
            return todayEventForm.Visible;
        }

    }
}
