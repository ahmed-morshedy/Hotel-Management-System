using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            labelUsername.Text = Username;
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            MovePanel(btnDash);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            MovePanel(btnReserve);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            MovePanel(btnService);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MovePanel(btnPayment);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            MovePanel(btnReview);
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fd = new Form2();
            fd.Show();
            this.Hide();
        }

    }
}