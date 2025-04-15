using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmKanon : Form
    {
        SQLiteConnection conn;

        public frmKanon()
        {
            InitializeComponent();

            conn = new SQLiteConnection("Data Source=./Book.db");

            Search();
        }

        private void btnAddKanon_Click(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into Kanon (Name, AdminName, AdminPhone, Address)  " +
                                " VALUES ($Name , $AdminName, $AdminPhone, $Address)";

            cmd.Parameters.AddWithValue("$Name", txtKanonName.Text.Trim());
            cmd.Parameters.AddWithValue("$AdminName", txtkanonAdminName.Text.Trim());
            cmd.Parameters.AddWithValue("$AdminPhone", txtKanonAdminPhone.Text.Trim());
            cmd.Parameters.AddWithValue("$Address", txtKanonAddress.Text.Trim());

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            ClearTextBoxs();

            Search();
        }

       private void ClearTextBoxs()
       {
            txtkanonAdminName.Text = "";
            txtKanonName.Text = "";
            txtKanonAdminPhone.Text = "";
            txtKanonAddress.Text = "";
       }

        private void txtSearchKanonId_TextChanged(object sender, EventArgs e)
        {
            Search(WhereOption.Id, txtSearchKanonId.Text.Trim());
        }


        private void Search(WhereOption whereOption = WhereOption.none , string value = "")
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtKanons.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"select Id, Name, AdminName, AdminPhone,  Address from Kanon " + Where(whereOption, value) + 
                                " order by Id desc";
                                
            
            //+ 
                                //"where Writer like $t ORDER by Name ASC";
            //cmd.CommandText = "select * from Books where Name like  '%ن%'"; 
            //cmd.Parameters.AddWithValue("$t", "%" + txtSearchByWriter.Text.Trim() + "%");


            ad = new SQLiteDataAdapter(cmd);

            dtKanons.AutoGenerateColumns = false; 
            ad.Fill(dt);

            conn.Close();
        }


        enum WhereOption  {
            Id,
            KanonName,
            KanonAdminName,
            none
        }

        private string Where(WhereOption whereOption = WhereOption.none , string value = "") {

            string WhreClause = "where ";

            if (value == "")
                return "";

            switch (whereOption)
            {
                case WhereOption.Id:


                   
                    return WhreClause + "Id = " + value;
                case WhereOption.KanonName:
                    return WhreClause + "Name like '%" + value + "%'";

                case WhereOption.KanonAdminName:
                    return WhreClause + "AdminName like '%" + value + "%'";

                default:
                    return "";
            }
        }

        private void txtSearchKanonName_TextChanged(object sender, EventArgs e)
        {
            Search(WhereOption.KanonAdminName, txtSearchKanonName.Text.Trim());
        }

        private void txtSearchKanonAdmin_TextChanged(object sender, EventArgs e)
        {
            Search(WhereOption.KanonAdminName, txtSearchKanonAdmin.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dtKanons.SelectedRows.Count == 0 || dtKanons.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("ابتدا کانون مورد نظر را انتخاب کنید");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("این کانون حذف خواهد شد. آیا مطئنید؟", "حذف کانون", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                string Id = dtKanons.SelectedRows[0].Cells[0].Value.ToString().Trim();

                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Kanon WHERE Id = " + Id;
                cmd.ExecuteNonQuery();

                conn.Close();

                Search();

            }
            catch(Exception ex)
            {

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtKanons.SelectedRows.Count == 0 || dtKanons.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("ابتدا کانون مورد نظر را انتخاب کنید");
                    return;
                }

                string Id = dtKanons.SelectedRows[0].Cells[0].Value.ToString().Trim();

                Form frmEditKanon = new frmEditKanon(Id);

                frmEditKanon.ShowDialog();

                Search();

            }
            catch(Exception ex) { 
            }
        }

        private void btnBarrowBookToKanon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtKanons.SelectedRows.Count == 0 || dtKanons.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("ابتدا کانون مورد نظر را انتخاب کنید");
                    return;
                }

                string Id = dtKanons.SelectedRows[0].Cells[0].Value.ToString().Trim();

                Form frmBarrowBookToKanon = new frmKanonBookBarrow(Id);

                frmBarrowBookToKanon.ShowDialog();

            }
            catch (Exception ex)
            {
                int i = 0;
            }
        }

        private void txtSearchKanonId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
