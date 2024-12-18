using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tolip
{
    internal class DatabaseHelper
    {
        private readonly SqlConnection _connection;

        public DatabaseHelper(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        // Generic method to execute SELECT queries and return DataTable
        public DataTable GetData(string query)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
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

        // Method to display data and search in DataGridView
        public void DisplayAndSearch(string query, DataGridView gridView)
        {
            DataTable data = GetData(query);
            if (data != null)
            {
                gridView.DataSource = data;
            }
        }

        // Add a new client
        public bool AddClient(string firstName, string lastName, string phoneNo, string address)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "INSERT INTO Client_Table (Client_FirstName, Client_LastName, Client_Phone, Client_Address) " +
                               "VALUES (@firstName, @lastName, @phoneNo, @address)";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@address", address);

                    return cmd.ExecuteNonQuery() > 0;
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

        // Update a client
        public bool UpdateClient(string id, string firstName, string lastName, string phoneNo, string address)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "UPDATE Client_Table " +
                               "SET Client_FirstName = @firstName, Client_LastName = @lastName, " +
                               "Client_Phone = @phoneNo, Client_Address = @address " +
                               "WHERE Client_ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@address", address);

                    return cmd.ExecuteNonQuery() > 0;
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

        // Delete a client
        public bool DeleteClient(string id)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "DELETE FROM Client_Table WHERE Client_ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0;
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

        // Add a new room
        public bool AddRoom(string type, string phone, string free)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "INSERT INTO Room_Table (Room_Type, Room_Phone, Room_Free) VALUES (@Type, @Phone, @Free)";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Free", free);

                    return cmd.ExecuteNonQuery() > 0;
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

        // Update a room
        public bool UpdateRoom(string roomNo, string type, string phone, string free)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "UPDATE Room_Table " +
                               "SET Room_Type = @Type, Room_Phone = @Phone, Room_Free = @Free " +
                               "WHERE Room_Number = @RoomNo";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Free", free);

                    return cmd.ExecuteNonQuery() > 0;
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

        // Delete a room
        public bool DeleteRoom(string roomNo)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "DELETE FROM Room_Table WHERE Room_Number = @RoomNo";
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo);

                    return cmd.ExecuteNonQuery() > 0;
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
        public bool AddReservation(string reservationType, string reservationNo, string clientID, string reservationIn, string reservationOut)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                // Begin transaction to ensure both queries succeed together
                SqlTransaction transaction = _connection.BeginTransaction();

                string queryInsert = @"INSERT INTO Reservation_Table (Reservation_Room_Type, Reservation_Room_Number, Reservation_Client_ID, Reservation_In, Reservation_Out)
                               VALUES (@RoomType, @RoomNo, @ClientID, @DateIn, @DateOut)";

                using (SqlCommand cmdInsert = new SqlCommand(queryInsert, _connection, transaction))
                {
                    cmdInsert.Parameters.AddWithValue("@RoomType", reservationType);
                    cmdInsert.Parameters.AddWithValue("@RoomNo", reservationNo);
                    cmdInsert.Parameters.AddWithValue("@ClientID", clientID);
                    cmdInsert.Parameters.AddWithValue("@DateIn", reservationIn);
                    cmdInsert.Parameters.AddWithValue("@DateOut", reservationOut);

                    int rowsAffected = cmdInsert.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        transaction.Rollback();  // Rollback if insertion fails
                        return false;
                    }
                }

                // Update Room_Free to 'No' after a successful reservation
                string queryUpdate = @"UPDATE Room_Table 
                               SET Room_Free = 'No' 
                               WHERE Room_Number = @RoomNo AND Room_Type = @RoomType";

                using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, _connection, transaction))
                {
                    cmdUpdate.Parameters.AddWithValue("@RoomNo", reservationNo);
                    cmdUpdate.Parameters.AddWithValue("@RoomType", reservationType);

                    int rowsUpdated = cmdUpdate.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        transaction.Rollback();  // Rollback if updating Room_Free fails
                        return false;
                    }
                }

                // Commit the transaction if both operations are successful
                transaction.Commit();
                return true;
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



        public bool UpdateReservation(string reservationID, string reservationType, string reservationNo, string clientID, string dateIn, string dateOut)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = @"UPDATE Reservation_Table 
                         SET Reservation_Room_Type = @RoomType, 
                             Reservation_Room_Number = @RoomNo, 
                             Reservation_Client_ID = @ClientID, 
                             Reservation_In = @DateIn, 
                             Reservation_Out = @DateOut 
                         WHERE Reservation_ID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@RoomType", reservationType);
                    cmd.Parameters.AddWithValue("@RoomNo", reservationNo);
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    cmd.Parameters.AddWithValue("@DateIn", dateIn);
                    cmd.Parameters.AddWithValue("@DateOut", dateOut);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if at least one row is updated
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

        public bool DeleteReservation(string reservationNo, string roomType, string roomNo)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                // Begin transaction to ensure both queries succeed together
                SqlTransaction transaction = _connection.BeginTransaction();

                // Delete the reservation
                string queryDelete = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationNo";
                using (SqlCommand cmdDelete = new SqlCommand(queryDelete, _connection, transaction))
                {
                    cmdDelete.Parameters.AddWithValue("@ReservationNo", reservationNo);
                    int rowsDeleted = cmdDelete.ExecuteNonQuery();
                    if (rowsDeleted == 0)
                    {
                        transaction.Rollback();  // Rollback if deletion fails
                        return false;
                    }
                }

                // Update the Room_Free status to 'Yes' after the reservation is deleted
                string queryUpdateRoom = "UPDATE Room_Table SET Room_Free = 'Yes' WHERE Room_Number = @RoomNo AND Room_Type = @RoomType";
                using (SqlCommand cmdUpdateRoom = new SqlCommand(queryUpdateRoom, _connection, transaction))
                {
                    cmdUpdateRoom.Parameters.AddWithValue("@RoomNo", roomNo);
                    cmdUpdateRoom.Parameters.AddWithValue("@RoomType", roomType);

                    int rowsUpdated = cmdUpdateRoom.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        transaction.Rollback();  // Rollback if updating Room_Free fails
                        return false;
                    }
                }

                // Commit the transaction if both operations are successful
                transaction.Commit();
                return true;
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


        public void RoomTypeAndNo(string roomType, ComboBox comboBox)
        {
            string query = "SELECT Room_Number FROM Room_Table WHERE Room_Type = @RoomType AND Room_Free = 'YES' ORDER BY Room_Number";
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@RoomType", roomType);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Clear previous items
                comboBox.Items.Clear();

                // Add room numbers to comboBox
            
                foreach (DataRow row in dt.Rows)
                {
                    string roomNumber = row["Room_Number"].ToString().Trim();  // Trim spaces before adding to comboBox
                    comboBox.Items.Add(roomNumber);
                    Console.WriteLine($"Room Number added: {roomNumber}");  // Debugging
                }
            }
        }


        public void RoomTypeAndNo1(string roomType, ComboBox comboBox)
        {
            string query = "SELECT Room_Number FROM Room_Table WHERE Room_Type = @RoomType AND Room_Free = 'No' ORDER BY Room_Number";
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@RoomType", roomType);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Clear previous items
                comboBox.Items.Clear();

                // Add room numbers to comboBox

                foreach (DataRow row in dt.Rows)
                {
                    string roomNumber = row["Room_Number"].ToString().Trim();  // Trim spaces before adding to comboBox
                    comboBox.Items.Add(roomNumber);
                    Console.WriteLine($"Room Number added: {roomNumber}");  // Debugging
                }
            }
        }



        public int CountClient()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT COUNT(*) FROM Client_Table";  // Assuming the table name is "Clint_Table"
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public int CountRoom()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT COUNT(*) FROM Room_Table";  // Assuming the table name is "Clint_Table"
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public int CountUser()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT COUNT(*) FROM User_Table";  // Assuming the table name is "Clint_Table"
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
