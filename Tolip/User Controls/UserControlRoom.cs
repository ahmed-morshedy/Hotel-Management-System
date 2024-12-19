using System;
using System.Windows.Forms;

namespace Tolip.User_Controls
{
    public partial class UserControlRoom : UserControl
    {
        private string No = "", Free = "";
        private DatabaseHelper dbHelper;

        public UserControlRoom()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;");
        }

        public void clear()
        {
            comboBoxType.SelectedIndex = 0;
            textBoxPhoneNo.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;

            tabControl1.SelectedTab = tabPageAddRoom;
        }

        private void clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            textBoxPhoneNo1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            No = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Free = radioButtonYes.Checked ? "Yes" : radioButtonNo.Checked ? "No" : "";

            if (comboBoxType.SelectedIndex == 0 || string.IsNullOrWhiteSpace(textBoxPhoneNo.Text) || Free == "")
            {
                MessageBox.Show("Please fill out all fields.", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool check = dbHelper.AddRoom(comboBoxType.SelectedItem.ToString(), textBoxPhoneNo.Text.Trim(), Free);
                if (check)
                {
                    MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewRoom);
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            dbHelper.DisplayAndSearch($"SELECT * FROM Room_Table WHERE Room_Number LIKE '%{textBoxSearchRoomNo.Text}%'", dataGridViewRoom);
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Free = radioButtonYes1.Checked ? "Yes" : radioButtonNo1.Checked ? "No" : "";

            if (!string.IsNullOrEmpty(No))
            {
                if (comboBoxType1.SelectedIndex == 0 || string.IsNullOrWhiteSpace(textBoxPhoneNo1.Text) || Free == "")
                {
                    MessageBox.Show("Please fill out all fields.", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool check = dbHelper.UpdateRoom(No, comboBoxType1.SelectedItem.ToString(), textBoxPhoneNo1.Text.Trim(), Free);
                    if (check)
                    {
                        MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            clear1();
            clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string free = radioButtonYes.Checked ? "Yes" : radioButtonNo.Checked ? "No" : "";

            if (comboBoxType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxPhoneNo.Text) || free == "")
            {
                MessageBox.Show("Please fill out all fields.", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
               
                string roomType = comboBoxType.SelectedItem.ToString();

                // Create a room using the factory
                Room room = RoomFactory.CreateRoom(roomType, textBoxPhoneNo.Text.Trim(), free);

                
                bool success = dbHelper.AddRoom(room.RoomType, room.PhoneNumber, room.Free);

                if (success)
                {
                    MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridViewRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();

                if (Free == "Yes") radioButtonYes1.Checked = true;
                else if (Free == "No") radioButtonNo1.Checked = true;
            }
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(No))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool check = dbHelper.DeleteRoom(No);
                    if (check)
                    {
                        MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
