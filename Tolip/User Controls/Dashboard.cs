using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolip.User_Controls
{
    public partial class Dashboard : UserControl
    {
        private DatabaseHelper dbHelper;

        public Dashboard()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;");

        }
        public void User()
        {
            LabelUserCount.Text = dbHelper.CountUser().ToString();
        }
        public void Client()
        {
            labelClientCount.Text = dbHelper.CountClient().ToString();
        }
        public void Room()
        {
            labelRoomCount.Text = dbHelper.CountRoom().ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }
    }
}
