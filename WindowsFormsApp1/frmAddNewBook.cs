using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.ConstrainedExecution;

namespace WindowsFormsApp1
{
    public partial class frmAddNewBook : Form
    {
        public bool IsDialog { get; set; } = false;

        public int BookId { get; set; } = 0;
        public string BookName { get; set; }
        
        SQLiteConnection conn;
        public frmAddNewBook()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db");
            txtSearch.Focus();

            txtTitle.KeyDown += AddNewBook_keyDown;
            txtWriter.KeyDown += AddNewBook_keyDown;
            txtPublisher.KeyDown += AddNewBook_keyDown;
            txtPublishedYear.KeyDown += AddNewBook_keyDown;
            txtISBN.KeyDown += AddNewBook_keyDown;
            txtTags.KeyDown += AddNewBook_keyDown;
            txtDescription.KeyDown += AddNewBook_keyDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AddNewBook()
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("لطفا عنوان کتاب را وارد کنید");
                return;
            }

            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into Books (Name, Writer, Publisher, PublishedYear, Description, Tags, ISBN) " +
                "VALUES ($Name, $Writer, $Publisher, $PublishedYear, $Description, $Tags , $ISBN)";

            cmd.Parameters.AddWithValue("$Name", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("$Writer", txtWriter.Text.Trim());
            cmd.Parameters.AddWithValue("$Publisher", txtPublisher.Text.Trim());
            cmd.Parameters.AddWithValue("$PublishedYear", txtPublishedYear.Text.Trim());
            cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("$Tags", txtTags.Text.Trim());
            cmd.Parameters.AddWithValue("$ISBN", txtISBN.Text.Trim());

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            clearTextBoxes();
            search();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtBooks.CurrentRow == null)
                return;

            i = dtBooks.CurrentRow.Index;

            if (e.KeyCode == Keys.Down)
            {
                if(i < dtBooks.RowCount -2 )
                    dtBooks.CurrentCell = dtBooks[0, ++i];
            }

            if(e.KeyCode == Keys.Up)
            {
                if (i > 0)
                    dtBooks.CurrentCell = dtBooks[0, --i];
            }

            if (e.KeyCode == Keys.Enter)
                SelectBook();
        }

        private void search()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtBooks.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select Id, Name, Writer, Publisher, Description from Books where Name like $t";
            cmd.CommandText = @"select Id, Name, Writer, Publisher,  Description, Status, Tags from Books 
                                where Name like $t 
                                ORDER by Name ASC";
            //cmd.CommandText = "select * from Books where Name like  '%ن%'"; 
            cmd.Parameters.AddWithValue("$t", "%" + txtSearch.Text.Trim() + "%");


            ad = new SQLiteDataAdapter(cmd);

            dtBooks.AutoGenerateColumns = false;
            ad.Fill(dt);


            /*
            dt.Columns["Name"].ColumnName = "عنوان";
            dt.Columns["Writer"].ColumnName = "نویسنده";
            dt.Columns["Publisher"].ColumnName = "ناشر";
            //dt.Columns["PublishedYear"].ColumnName = "سال انتشار";
            dt.Columns["Description"].ColumnName = "توضیحات";
            //dt.Columns["ISBN"].ColumnName = "شابک";


            //dtBooks.Columns["Id"].Visible = false;

            */

            conn.Close();
        }

        private void searchByWriter()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtBooks.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select Id, Name, Writer, Publisher, Description from Books where Name like $t";
            cmd.CommandText = @"select Id, Name, Writer, Publisher,  Description, Status, Tags from Books 
                                where Writer like $t ORDER by Name ASC";
            //cmd.CommandText = "select * from Books where Name like  '%ن%'"; 
            cmd.Parameters.AddWithValue("$t", "%" + txtSearchByWriter.Text.Trim() + "%");


            ad = new SQLiteDataAdapter(cmd);

            dtBooks.AutoGenerateColumns = false;/////////////
            ad.Fill(dt);


            /*
            dt.Columns["Name"].ColumnName = "عنوان";
            dt.Columns["Writer"].ColumnName = "نویسنده";
            dt.Columns["Publisher"].ColumnName = "ناشر";
            //dt.Columns["PublishedYear"].ColumnName = "سال انتشار";
            dt.Columns["Description"].ColumnName = "توضیحات";
            //dt.Columns["ISBN"].ColumnName = "شابک";


            //dtBooks.Columns["Id"].Visible = false;

            */

            conn.Close();
        }


        int i = 0;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            i = 0;
            search();
            txtSearch.Focus();
        }

        private void clearTextBoxes()
        {
            txtTitle.Text = "";
            txtWriter.Text = "";
            txtPublisher.Text = "";
            txtPublishedYear.Text = "";
            txtISBN.Text = "";
            txtTags.Text = "";
            txtDescription.Text = "";
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            if (IsDialog)
            {
                btnSelectBook.Visible = true;
            }

            search();
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            SelectBook();
        }

        private void SelectBook()
        {
            if (dtBooks.SelectedRows.Count > 0)
            {


                if (dtBooks.SelectedRows[0].Cells["clId"].Value == null)
                    return;
                if (dtBooks.SelectedRows[0].Cells["clId"].Value.ToString().Trim() == "")
                    return;

                if (dtBooks.SelectedRows[0].Cells["BookStatus"].Value.ToString() == "در امانت")
                {
                    MessageBox.Show("این کتاب قبلا امانت داده شده است");
                    return;
                }

                this.BookId = int.Parse(dtBooks.SelectedRows[0].Cells["clId"].Value.ToString().Trim());
                this.BookName = dtBooks.SelectedRows[0].Cells["clBookName"].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
            i = 0;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void DeleteBook()
        {
            if (dtBooks.SelectedRows.Count == 0 || dtBooks.SelectedRows[0].Cells["clId"].Value == null)
            {
                MessageBox.Show("ابتدا کتاب مورد نظر را انتخاب کنید");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("این کتاب حذف خواهد شد. آیا مطئنید؟", "حذف کتاب", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int _BookId = int.Parse(dtBooks.SelectedRows[0].Cells["clId"].Value.ToString().Trim());
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select Id, Name, Writer, Publisher, Description from Books where Name like $t";
            cmd.CommandText = "delete from Books where Id = $id ";



            cmd.Parameters.AddWithValue("$id", _BookId);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("کتاب با موفقیت حذف شد");
            search();
        }

        private void frmAddNewBook_Shown(object sender, EventArgs e)
        {
            /*
            if (IsDialog)
                txtSearch.Focus();
            else
                txtTitle.Focus();*/
        }

        private void dtBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteBook();

            if (!IsDialog)
                return;

            if (e.KeyCode == Keys.Enter)
                SelectBook();
        }

        private void dtBooks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtBooks.SelectedRows.Count == 0 || dtBooks.SelectedRows[0].Cells["clId"].Value == null)
            {
                MessageBox.Show("ابتدا کتاب مورد نظر را انتخاب کنید");
                return;
            }

            string Id = dtBooks.SelectedRows[0].Cells["clId"].Value.ToString().Trim();

            /*
            string Title  = 1dtBooks.SelectedRows[0].Cells["clBookName"].Value.ToString().Trim();
            string Writer  = dtBooks.SelectedRows[0].Cells["clWriter"].Value.ToString().Trim();
            string Publisher  = dtBooks.SelectedRows[0].Cells["clPublisher"].Value.ToString().Trim();
            string PublishedYear = dtBooks.SelectedRows[0].Cells["clPublishedYear"].Value.ToString().Trim();
            */
            Form frm_Edit = new frmEditBook(int.Parse(Id));
            frm_Edit.Show();

        }

        private void txtSearchByWriter_TextChanged(object sender, EventArgs e)
        {
            searchByWriter();
        }

        private void AddNewBook_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewBook();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook();
        }

        private void txtSearchByTag_TextChanged(object sender, EventArgs e)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtBooks.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select Id, Name, Writer, Publisher, Description from Books where Name like $t";
            cmd.CommandText = @"select Id, Name, Writer, Publisher,  Description, Status, Tags from Books 
                                where Tags like $t ORDER by Name ASC";
            //cmd.CommandText = "select * from Books where Name like  '%ن%'"; 
            cmd.Parameters.AddWithValue("$t", "%" + txtSearchByTag.Text.Trim() + "%");


            ad = new SQLiteDataAdapter(cmd);

            dtBooks.AutoGenerateColumns = false;/////////////
            ad.Fill(dt);


            

            conn.Close();
        }
    }
}
