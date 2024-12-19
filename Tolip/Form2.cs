using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // Get logger instance
            Logger logger = Logger.GetInstance();

            
            string connectionString = "Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;";

            
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Log("Attempted login with missing username or password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    logger.Log("Database connection opened successfully.");

                    string query = "SELECT COUNT(1) FROM User_Table WHERE User_Name = @Username AND User_Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        logger.Log($"Login query executed for user: {textBoxUsername.Text}");

                        if (count == 1)
                        {
                            // Successful login
                            Home fd = new Home();
                            fd.Username = textBoxUsername.Text;
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();
                            logger.Log($"User '{fd.Username}' logged in successfully.");
                            fd.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Failed login
                            MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            logger.Log($"Invalid login attempt for user: {textBoxUsername.Text}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Log($"Error during login attempt: {ex.Message}");
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
