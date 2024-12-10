using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tolip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all field.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (check)
                {
                    Home fd = new Home();
                    fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    fd.Show();
                }
                else
                    MessageBox.Show("Invalid Username or Passwod.", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBox2.Show();
        }
       

        

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Hide Password");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBox3.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Show Password");
        }
    }
}
