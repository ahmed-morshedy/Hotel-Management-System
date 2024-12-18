using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolip.User_Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tolip
{

    public partial class Home : Form
    {
        public string Username;
        public Home()
        {
            InitializeComponent();
        }


        private void MovePanel(Control btn)
        {
            panelSlider.Top = btn.Top;
            panelSlider.Height = btn.Height;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to log out?", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDataTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void Home_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            MovePanel(btnDash);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            dashboard1.Client();
            dashboard1.User();
            dashboard1.Room();
            dashboard1.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
            userControlSetting1.Hide();
            userControlClient1.Show();
            userControlReservation1.Hide();
            dashboard1.Hide();
            userControlRoom1.Hide();

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlReservation1.Hide();
            dashboard1.Hide();
            userControlRoom1.Show();


        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            MovePanel(btnReserve);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();
            dashboard1.Hide();
            userControlSetting1.Hide();

        }

       

    

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fd = new Form2();
            fd.Show();
            this.Hide();
        }


        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            MovePanel(btnSetting);

            userControlSetting1.Clear();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            dashboard1.Hide();
            userControlSetting1.Show();
        }


        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                timer1.Stop();

                
                Username = string.Empty;
                this.Hide();
                
                Form2 loginForm = new Form2(); 
                loginForm.Show();

                
                this.Close();
            }
        }

       
    }
}