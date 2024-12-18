using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tolip.User_Controls
{
    public partial class UserControlSetting : UserControl
    {
        private SqlConnection db; 
        private DatabaseHelper dbHelper;
        string connectionString = "Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;";

        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            db = new SqlConnection(connectionString);
            dbHelper = new DatabaseHelper(connectionString);
        }
        public class DatabaseHelper
        {
            private readonly SqlConnection _connection;

            public DatabaseHelper(string connectionString)
            {
                _connection = new SqlConnection(connectionString);
            }

            public bool AddUser(string username, string password)
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    string query = "INSERT INTO User_Table (User_name, User_Password) VALUES (@Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if at least one row is affected
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();
                }
            }
            public DataTable GetData(string query)
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, _connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();
                }
            }

            public bool DeleteUser(string id)
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    string query = "DELETE FROM User_Table WHERE User_ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if at least one row is affected
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();
                }
            }


            public bool UpdateUser(string id, string username, string password)
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    string query = "UPDATE User_Table SET User_Name = @Username, User_Password = @Password WHERE User_ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if at least one row is affected
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();
                }
            }
        }


        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            UpdateAndDelete.SelectedTab = tabPageAddUser;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }


        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }


        private void tabControlUser_Enter(object sender, EventArgs e)
        {

            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }

            DisplayAndSearchUser("SELECT * FROM User_Table", dataGridViewUser);
        }

        public void DisplayAndSearchUser(string query, DataGridView grid)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void tabControlUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }


        private void tabPageUpdateandDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID))
            {
                if (string.IsNullOrWhiteSpace(textBoxUsername1.Text) || string.IsNullOrWhiteSpace(textBoxPassword1.Text))
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool check = dbHelper.UpdateUser(ID, textBoxUsername1.Text.Trim(), textBoxPassword1.Text.Trim());
                    if (check)
                    {
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                        DisplayAndSearchUser("SELECT * FROM User_Table", dataGridViewUser); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select a row from the table.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "User delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool check = dbHelper.DeleteUser(ID);
                    if (check)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                        DisplayAndSearchUser("SELECT * FROM User_Table", dataGridViewUser); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select a row from the table.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
            }
        }
        

        //Add User
        private void tabControlUser_Leave_1(object sender, EventArgs e)
        {
           Clear();
            Clear1();
        }


        // Search
        private void tabControlUser_Enter_1(object sender, EventArgs e)
        {
            try
            {
                // Query to select only User_Name and User_Password
                string query = "SELECT User_ID,User_Name, User_Password FROM User_Table";

                // Get data from the database
                DataTable userData = dbHelper.GetData(query);

                // Bind the data to the DataGridView
                if (userData != null)
                {
                    dataGridViewUser.DataSource = userData;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Search
        private void tabControlUser_Leave_2(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();

        }

        private void UpdateAndDelete_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateAndDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool check = dbHelper.AddUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                if (check)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBoxSearchUsername.Text.Trim();

                // Create a SQL query to filter by User_Name
                string query;
                if (string.IsNullOrEmpty(searchValue))
                {
                    query = "SELECT User_Name, User_Password FROM User_Table"; // No filter, show all
                }
                else
                {
                    query = "SELECT User_Name, User_Password FROM User_Table WHERE User_Name LIKE @SearchValue";
                }

                using (SqlCommand cmd = new SqlCommand(query, db))
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the filtered data to the DataGridView
                        dataGridViewUser.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

