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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tolip.User_Controls
{
    public partial class UserControlReservation : UserControl
    {

        private DatabaseHelper dbHelper;


        private string RID = "", NO;
        public UserControlReservation()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;");
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = -1;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;

        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = -1;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;

            RID = "";

        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;

          
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0 || comboBoxNo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxClientID.Text) || string.IsNullOrWhiteSpace(textBoxClientID.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool check = dbHelper.AddReservation(comboBoxType.SelectedItem.ToString(), comboBoxNo.SelectedItem.ToString(), textBoxClientID.Text, dateTimePickerIn.Text, dateTimePickerOut.Text);
                if (check)
                {
                    MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add Reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch("SELECT * FROM Reservation_Table", dataGridViewReservation);

        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch("select * from Reservation_Table Where Reservation_Client_Phone LIKE '%" + textBoxSearchClientID.Text + "%'", dataGridViewReservation);

        }

       private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
{
    // Ensure the row index is valid
    if (e.RowIndex >= 0 && e.RowIndex < dataGridViewReservation.Rows.Count)
    {
        // Access the clicked row
        DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];

        // Example: Fill fields with row data
        RID = row.Cells[0].Value.ToString();
        comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
        comboBoxNo1.SelectedItem = row.Cells[2].Value.ToString();
        textBoxClientID1.Text = row.Cells[3].Value.ToString();
        dateTimePickerIn1.Text = row.Cells[4].Value.ToString();
        dateTimePickerOut1.Text = row.Cells[5].Value.ToString();
    }
}


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RID))
            {
                bool check = dbHelper.UpdateReservation(
                    RID, comboBoxType1.SelectedItem.ToString(), comboBoxNo1.SelectedItem.ToString(), textBoxClientID1.Text, dateTimePickerIn1.Text, dateTimePickerOut1.Text
                );
                if (check)
                {
                    MessageBox.Show("Reservation updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear1();
                }
                else
                {
                    MessageBox.Show("Failed to update Reservation.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Reservation to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RID))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool check = dbHelper.DeleteReservation(RID , comboBoxType1.SelectedItem.ToString(), comboBoxNo1.SelectedItem.ToString());

                    if (check)
                    {
                        MessageBox.Show("Reservation deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Reservation to Delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxType1.SelectedItem != null)
            {


                dbHelper.RoomTypeAndNo1(comboBoxType1.SelectedItem.ToString(), comboBoxNo1);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null)
            {
                string selectedRoomType = comboBoxType.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(selectedRoomType))
                {
                    MessageBox.Show("Invalid room type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    dbHelper.RoomTypeAndNo(comboBoxType.SelectedItem.ToString(), comboBoxNo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Debug Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No room type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tabPageUpdateAndCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}