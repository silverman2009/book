using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmKanonBookBarrow : Form
    {
        SQLiteConnection conn;

        String KanonId;

        List<string> Books = new List<string>();

        public frmKanonBookBarrow()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db"); 
        }

        public frmKanonBookBarrow(string Id)
        {
            conn = new SQLiteConnection("Data Source=./Book.db");
           
            InitializeComponent();

            KanonId = Id;

            dtBorrowedBooks.Columns["Id"].Visible = false;

            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if(Books.Count == 0)
            {
                MessageBox.Show("ابتدا کتاب‌های مورد نظر را اضافه کنید");
                return;
            }
                
            
            PersianCalendar pc = new PersianCalendar();
            long now = DateTime.Now.Ticks;


            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();

            cmd = conn.CreateCommand();
    

            foreach (var book in Books)
            {
                cmd.CommandText = "insert into tblKanonBookBarrow (BookName, BarrowedDate, BarrowedDateJalali, BarrowedKanonId) " +
                    "VALUES ($BookName,  $BarrowedDate, $BarrowedDateJalali, $BarrowedKanonId)";

                cmd.Parameters.AddWithValue("$BookName", book);
                cmd.Parameters.AddWithValue("$BarrowedDate", now);
                cmd.Parameters.AddWithValue("$BarrowedDateJalali", getPersinaDate());
                cmd.Parameters.AddWithValue("$BarrowedKanonId", KanonId);
                

                cmd.ExecuteNonQuery();
            }

            conn.Close();

            lblSaved.Visible = true;
            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t) => lblSaved.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());

            Search();

            txtBookTitle.Text = "";
            txtBookId.Text = "";
            lstBookNames.Items.Clear();
        }

        private string getPersinaDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime _now = DateTime.Now;
            return pc.GetYear(_now) + "-" + string.Format("{0:00}", pc.GetMonth(_now)) + "-" + string.Format("{0:00}", pc.GetDayOfMonth(_now));
        }

        private void btnAddBookById_Click(object sender, EventArgs e)
        {
           Boolean isAdded =  AddBook();

            if(isAdded)
                txtBookId.Text = "";
        }

        private bool AddBook()
        {
            if (txtBookId.Text.Trim() != "")
            {
                try
                {
                   int id = int.Parse(txtBookId.Text.Trim());
                   Boolean added =  AddBookToList(id.ToString());
                   return added;
                }
                catch(Exception ex)
                {
                    Boolean added = AddBook(txtBookId.Text.Trim());
                    return added;
                }
            }

            return false;
        }

        private Boolean AddBookToList(string Id)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            
            cmd.CommandText = @"SELECT Books.Id
                                from tblBorrows 
                                INNER JOIN tblMembers  
                                on tblBorrows.Borrower = tblMembers.Id join Books on tblBorrows.Book = Books.Id
                                where Status = 'در امانت' and Books.Id =  " + txtBookId.Text.Trim();
            

            ad = new SQLiteDataAdapter(cmd);

           
            ad.Fill(dt);
            conn.Close();

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("این کتاب قبلا امانت داده شده است");
                return false;
            }else{
                conn.Open();

                cmd.CommandText = @"select Id, Name, Status from Books 
                                where Id =" + txtBookId.Text.Trim();

                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);

                if (dt.Rows.Count == 1)
                    AddBook(dt.Rows[0].ItemArray[1].ToString().Trim());
                else
                { 
                }
            }
        
            conn.Close();

            return true;
        }

        private bool AddBook(String BookName)
        { 
            var isExsit = Books.Where(x => x == BookName);

            if (isExsit.Count() > 0)
            {
                MessageBox.Show("این کتاب قبلا اضافه شده است");
                return false;
            }
           
            txtBookTitle.Text = BookName;

            Books.Add(  BookName);
            
            lstBookNames.Items.Add(BookName);

            return true;
        }

        private void txtBookId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBookId.Text.Trim() != "")
            {
                bool IsBookAdded = AddBook();

                if (IsBookAdded)
                    txtBookId.Text = "";
            }

            if (e.KeyCode == Keys.Down)
                if (lstBookNames.Items.Count > 0 && lstBookNames.SelectedIndex < lstBookNames.Items.Count - 1)
                    lstBookNames.SelectedIndex += 1;

            if (e.KeyCode == Keys.Up)
                if (lstBookNames.Items.Count > 0 && lstBookNames.SelectedIndex > 0)
                    lstBookNames.SelectedIndex -= 1;

            if (e.KeyCode == Keys.Delete)
                DeleteSelectedBook();
        }


        private void DeleteSelectedBook()
        {
            if (lstBookNames.SelectedItems.Count == 0)
            {
                MessageBox.Show("لطفا کتاب مورد نظر را انتخاب کنید");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("این کتاب حذف خواهد شد. آیا مطئنید؟", "حذف کتاب", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var book = Books.FirstOrDefault(x => x == lstBookNames.SelectedItems[0].ToString());
            Books.Remove(book);
            lstBookNames.Items.RemoveAt(lstBookNames.SelectedIndex);

            txtBookTitle.Text = "";
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteSelectedBook();
        }

        
        private void Search(string BookName = "")
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            

            conn.Open();
            dtBorrowedBooks.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"select Id, BookName, BarrowedDateJalali, ReturnedDateJalali from tblKanonBookBarrow 
                                where BarrowedKanonId = " + KanonId ;


            if(BookName != "")
                cmd.CommandText +=  " and BookName like '%" + BookName + "%'";


            if (chOnlyNotReterned.Checked)
                cmd.CommandText += " and ReturnedDate is null";


            cmd.CommandText += " order by id desc";

            ad = new SQLiteDataAdapter(cmd);

            dtBorrowedBooks.AutoGenerateColumns = false;
            ad.Fill(dt);

            conn.Close();
        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearchBooks.Text.Trim());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dtBorrowedBooks.SelectedRows.Count == 0)
                return;

            int id = int.Parse(dtBorrowedBooks.SelectedRows[0].Cells[0].Value.ToString());



            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"update tblKanonBookBarrow SET ReturnedDate = $reternedDate, ReturnedDateJalali = $reternedDate_jalali
                                    where Id = $id";
            cmd.Parameters.AddWithValue("$reternedDate", DateTime.Now.Ticks);
            cmd.Parameters.AddWithValue("$reternedDate_jalali", getPersinaDate());
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();

            conn.Close();

            Search();
        }

        private void chOnlyNotReterned_CheckedChanged(object sender, EventArgs e)
        {
            Search(txtSearchBooks.Text.ToString().Trim());
        }
    }
}
