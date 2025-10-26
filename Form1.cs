using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_handler_project
{
    public partial class Form1 : Form
    {
        private DateTime eventDateTime;
        private Timer Timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtEventDate.Text, out eventDateTime))
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid date and time.");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = eventDateTime - DateTime.Now;

            if (timeRemaining.TotalSeconds <= 0)
            {
                timer.Stop();
                lblTimeRemaining.Text = "Event started!";
                NotifyUser("The event has started!");
            }
            else
            {
                lblTimeRemaining.Text = timeRemaining.ToString("dd\\:hh\\:mm\\:ss");

                if (timeRemaining.TotalMinutes <= 1)
                {
                    NotifyUser("The event is starting in less than a minute!");
                }
            }

        }
        private void NotifyUser(string message)
        {
            // Show a notification to the user
            MessageBox.Show(message, "Event Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
