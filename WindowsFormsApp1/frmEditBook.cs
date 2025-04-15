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
    public partial class frmEditBook : Form
    {
        int ID;
        private string _Title, _writer, _publisher, _ISBN, _Tags, _Description;

        private void frmEditBook_Load(object sender, EventArgs e)
        {
            txtTitle.KeyDown += EditBook_textBoxs_keyDown;
            txtWriter.KeyDown += EditBook_textBoxs_keyDown;
            txtPublisher.KeyDown += EditBook_textBoxs_keyDown;
            txtPublishedYear.KeyDown += EditBook_textBoxs_keyDown;
            txtISBN.KeyDown += EditBook_textBoxs_keyDown;
            txtTags.KeyDown += EditBook_textBoxs_keyDown;
            txtDescription.KeyDown  += EditBook_textBoxs_keyDown;
        }

        SQLiteConnection conn;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        private void EditBook() 
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام کتاب را وارد کنید");
                return;
            }


            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"UPDATE  Books 
                                SET Name = $Name, Writer =  $Writer, Publisher=  $Publisher, PublishedYear =  $PublishedYear,
                                Description =  $Description, Tags = $Tags , ISBN =  $ISBN , Isdonated = $Isdonated 
                                where Id = $Id";

            cmd.Parameters.AddWithValue("$Name", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("$Writer", txtWriter.Text.Trim() == "" ? null : txtWriter.Text.Trim());

            cmd.Parameters.AddWithValue("$Publisher", txtPublisher.Text.Trim() == "" ? null : txtPublisher.Text.Trim());
            cmd.Parameters.AddWithValue("$PublishedYear", txtPublishedYear.Text.Trim() == "" ? null : txtPublishedYear.Text.Trim());
            cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim() == "" ? null : txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("$Tags", txtTags.Text.Trim() == "" ? null : txtTags.Text.Trim());
            cmd.Parameters.AddWithValue("$ISBN", txtISBN.Text.Trim() == "" ? null : txtISBN.Text.Trim());
            cmd.Parameters.AddWithValue("$Id", ID);
            cmd.Parameters.AddWithValue("$Isdonated", rdDonated.Checked == true ? 1 : 0);

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            lblSavedStatus.Visible = true;

            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t)=> lblSavedStatus.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
        }

        int _PublishedYear;


        public frmEditBook(int _ID)
        {

            conn = new SQLiteConnection("Data Source=./Book.db");

            InitializeComponent();
            ID = _ID;

           
            var con = new SQLiteConnection(@"Data Source=./Book.db");


            con.Open();

            string stm = "SELECT * FROM Books  where Id = " + ID;

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ID = rdr.GetInt32(0);
                
                txtTitle.Text = rdr.GetString(1);
                txtWriter.Text = rdr.GetValue(2).ToString();
                txtPublisher.Text = rdr.GetValue(3).ToString();
                txtPublishedYear.Text = rdr.GetValue(4).ToString();
                txtDescription.Text = rdr.GetValue(5).ToString();
                txtTags.Text = rdr.GetValue(6).ToString();
                txtISBN.Text  = rdr.GetValue(7).ToString();
                int IsDonated = rdr.GetInt32(8);

                if (IsDonated == 0)
                    rdNotDonated.Checked = true;
                else
                    rdDonated.Checked = true;
            }
            con.Close();

             
        }


        private void frmEditBook_Shown(object sender, EventArgs e)
        {
        }

        private void EditBook_textBoxs_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditBook();
        }


    }
}
