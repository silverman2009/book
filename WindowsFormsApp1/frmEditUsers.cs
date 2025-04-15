using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEditUsers : Form
    {
        SQLiteConnection conn;
        int UserID = -1;

        public frmEditUsers()
        {
            InitializeComponent();
        }

        private void frmEditUsers_Load(object sender, EventArgs e)
        {

        }

        public frmEditUsers (int _userId)
        {
            conn = new SQLiteConnection("Data Source=./Book.db");

            InitializeComponent();

            UserID  = _userId;


            var con = new SQLiteConnection(@"Data Source=./Book.db");


            con.Open();

            string stm = "SELECT * FROM tblMembers  where Id = " + UserID;

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                

                txtFirstName.Text = rdr.GetString(1);
                txtLastName.Text = rdr.GetValue(2).ToString();
                txtPhoneNumber.Text = rdr.GetValue(3).ToString();
                txtNationalCode.Text = rdr.GetValue(4).ToString();
                txtDescription.Text = rdr.GetValue(5).ToString();                 
            }
            con.Close();

        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();


            cmd.CommandText = @"UPDATE  tblMembers 
                                SET FirstName = $FirstName, LastName = $LastName, Phone = $Phone, NationalCode = $NationalCode, Description = $Description
                                where Id = $Id";

            cmd.Parameters.AddWithValue("$FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("$Phone", txtPhoneNumber.Text.Trim());
            cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("$NationalCode", txtNationalCode.Text.Trim());
            cmd.Parameters.AddWithValue("$Id", UserID);

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            lblEditedStatus.Visible = true;

            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t) => lblEditedStatus.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
