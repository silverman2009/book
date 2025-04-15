using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEditKanon : Form
    {

        SQLiteConnection conn;

        string Id = "";
        public frmEditKanon()
        {
            InitializeComponent();
        }

        public frmEditKanon(string Id)
        {
            conn = new SQLiteConnection("Data Source=./Book.db");
            this.Id = Id;

            InitializeComponent();


            var con = new SQLiteConnection(@"Data Source=./Book.db");

            con.Open();

            string stm = "SELECT * FROM Kanon  where Id = " + Id;

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                txtKanonName.Text = rdr.GetString(1);
                txtkanonAdminName.Text = rdr.GetValue(2).ToString();
                txtKanonAdminPhone.Text = rdr.GetValue(3).ToString();
                txtKanonAddress.Text = rdr.GetValue(4).ToString();
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditKanon_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();


                cmd.CommandText = @"UPDATE  Kanon 
                                SET Name = $Name, AdminName = $AdminName, AdminPhone = $AdminPhone, Address = $Address 
                                where Id = $Id";

                cmd.Parameters.AddWithValue("$Name", txtKanonName.Text.Trim());
                cmd.Parameters.AddWithValue("$AdminName", txtkanonAdminName.Text.Trim());
                cmd.Parameters.AddWithValue("$AdminPhone", txtKanonAdminPhone.Text.Trim());
                cmd.Parameters.AddWithValue("$Address", txtKanonAddress.Text.Trim());
                cmd.Parameters.AddWithValue("$Id", Id);

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();

                lblEditedStatus.Visible = true;

                Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t) => lblEditedStatus.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
            }catch(Exception ex)
            {
                int i = 0;
            }
        }
    }
}
