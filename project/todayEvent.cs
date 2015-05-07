using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class todayEvent : Form
    {
        public todayEvent(string todayEventList)
        {
            InitializeComponent();
            if (todayEventList == "") textBoxEventsList.Text = "На сегодняшний день нет событий";
            else textBoxEventsList.Text = todayEventList;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
