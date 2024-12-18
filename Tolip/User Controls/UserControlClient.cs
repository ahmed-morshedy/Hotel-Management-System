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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Tolip.User_Controls.UserControlSetting;

namespace Tolip.User_Controls
{
    public partial class UserControlClient : UserControl
    {
        private string ID = "";
        private DatabaseHelper dbHelper;

        public UserControlClient()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;");
        }

        // Method to clear input fields and reset the tab
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Trim() == string.Empty
                || textBoxLastName.Text.Trim() == string.Empty
                || textBoxPhoneNo.Text.Trim() == string.Empty
                || textBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool check = dbHelper.AddClient(
                    textBoxFirstName.Text.Trim(),
                    textBoxLastName.Text.Trim(),
                    textBoxPhoneNo.Text.Trim(),
                    textBoxAddress.Text.Trim()
                );

                if (check)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        private void tabpageSearchclient_Enter(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewClient);
        }

        
       
       

        

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                bool check = dbHelper.UpdateClient(
                    ID,
                    textBoxFirstName1.Text.Trim(),
                    textBoxLastName1.Text.Trim(),
                    textBoxPhoneNo1.Text.Trim(),
                    textBoxAddress1.Text.Trim()
                );

                if (check)
                {
                    MessageBox.Show("Client updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear1();
                }
                else
                {
                    MessageBox.Show("Failed to update client.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool check = dbHelper.DeleteClient(ID);

                    if (check)
                    {
                        MessageBox.Show("Client deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to deleted.", "Deleted Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhoneNo.Clear();
        }

        private void textBoxSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch("select * from Client_Table Where Client_Phone LIKE '%" + textBoxSearchPhoneNo.Text + "%'",dataGridViewClient);
        }

        private void tabPageUpdateandDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
