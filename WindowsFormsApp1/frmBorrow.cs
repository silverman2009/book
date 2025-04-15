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
using System.Globalization;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class frmBorrow : Form
    {
        SQLiteConnection conn;


        public int BorrowerId = -1;
        public int BookId = -1;

        SearchBy LastTimeSearchedBy;

        enum SearchBy
        {
            BookId,
            RegisteratinID,
            FirstName,
            LastName,
            BookName,
            Phone
        }

        public frmBorrow()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db");
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            frmMembers frmSearchMembersDialog = new frmMembers();
            frmSearchMembersDialog.isDialog = true;

             
            if (frmSearchMembersDialog.ShowDialog() == DialogResult.OK)
            {
                txtBorrower.Text = frmSearchMembersDialog.PersonName;
                this.BorrowerId = frmSearchMembersDialog.Id;
                btnSave.Focus();
            }
        }

        List<int> BookIds = new List<int>();

        Dictionary<int, string> books = new Dictionary<int, string>();

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

            frmAddNewBook frmSearchBookDialog = new frmAddNewBook();
            frmSearchBookDialog.IsDialog = true;

            if (frmSearchBookDialog.ShowDialog() == DialogResult.OK)
            {

                AddBook(frmSearchBookDialog.BookId, frmSearchBookDialog.BookName);
            }
        }

        private void AddBook(int BookId ,String BookName)
        {

            /*
            frmAddNewBook frmSearchBookDialog = new frmAddNewBook();
            frmSearchBookDialog.IsDialog = true;

            if (frmSearchBookDialog.ShowDialog() == DialogResult.OK)
            {*/

            var isExsit = books.Where(x => x.Key == BookId);

            if (isExsit.Count() > 0)
            {
                MessageBox.Show("این کتاب قبلا اضافه شده است");
                return;
            }


            //this.BookId = frmSearchBookDialog.BookId;
            txtBookTitle.Text = BookName;

            books.Add(BookId, BookName);
            //BookIds.Add(frmSearchBookDialog.BookId);
            lstBookNames.Items.Add(BookName);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BorrowerId == -1)
            {
                MessageBox.Show("لطفا امانت گیرنده را انتخاب کنید");
                return;
            }

            if (lstBookNames.Items.Count == 0)
            {
                MessageBox.Show("لطفا کتاب مورد نظر را انتخاب کنید");
                txtBookId.Focus();
                return;
            }


            PersianCalendar pc = new PersianCalendar();

            long now = DateTime.Now.Ticks;

            //SQLiteConnection conn = new SQLiteConnection("Data Source=./Book.db");

            /*
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into tblBorrows (Book, Borrower, BorrowedDate , Description, BrowwedDate_jalai) VALUES ($Book, $Borrower, $BorrowedDate, $Description, $BrrowedDate_jalali)";

            cmd.Parameters.AddWithValue("$Book", BookId);
            cmd.Parameters.AddWithValue("$Borrower", BorrowerId);
            cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("$BorrowedDate",now);
            cmd.Parameters.AddWithValue("$BrrowedDate_jalali", getPersinaDate());
            

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            clearTextBoxes();
            ShowLast10();*/


            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();

            cmd = conn.CreateCommand();

            var transaction = conn.BeginTransaction();

            foreach (var item in books)
            {
                cmd.CommandText = "insert into tblBorrows (Book, Borrower, BorrowedDate , Description, BrowwedDate_jalai) VALUES ($Book, $Borrower, $BorrowedDate, $Description, $BrrowedDate_jalali)";

                cmd.Parameters.AddWithValue("$Book", item.Key);
                cmd.Parameters.AddWithValue("$Borrower", BorrowerId);
                cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("$BorrowedDate", now);
                cmd.Parameters.AddWithValue("$BrrowedDate_jalali", getPersinaDate());

                cmd.ExecuteNonQuery();
            }

            foreach (var item in books)
            {
                cmd.CommandText = "UPDATE Books SET Status ='در امانت' WHERE  Id = " + item.Key;
                cmd.ExecuteNonQuery();
            }

            transaction.Commit();

            conn.Close();

            txtSearchByBookId.Text = "";
            txtBorrower.Text = "";
            txtBookTitle.Text = "";
            lstBookNames.Items.Clear();
            txtBorrower.Text = "";
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtRegisterationId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";


            books.Clear();


            LastTimeSearchedBy = SearchBy.BookName;
            SearchByLast();

            BorrowerId = -1;

            MessageBox.Show("ثبت شد");
        }

        private void clearTextBoxes()
        {
            txtBookTitle.Text = "";
            txtBorrower.Text = "";
            txtDescription.Text = "";
        }

        private void ShowLast10()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtBorrows.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT tblBorrows.Id, Books.Name as BookName, Books.Id as BookID tblMembers.FirstName, tblMembers.LastName, tblMembers.Phone, tblBorrows.BrowwedDate_jalai, tblBorrows.Reterned_data_jalali 
                                    from tblBorrows 
                                    INNER JOIN tblMembers  
                                    on tblBorrows.Borrower = tblMembers.Id join Books on tblBorrows.Book = Books.Id
                                    where tblBorrows.ReternedDate is  NULL
                                    ORDER BY tblBorrows.Id DESC
                                    limit 10";


            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            RenameCloums(dt);

            //dt.Columns["Name"].ColumnName = "عنوان";
            //dt.Columns["PublishedYear"].ColumnName = "سال انتشار";
            //dt.Columns["Description"].ColumnName = "توضیحات";

            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search();
        }

       private void search( SearchBy searchby , string q)
       {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            //string q = txtSearch.Text.Trim();

            conn.Open();
            dtBorrows.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            string commmandStr = @"SELECT tblBorrows.Id,  Books.Name as BookName, Books.Id as BookId, tblMembers.Id, tblMembers.FirstName, tblMembers.LastName, 
                                    tblMembers.Phone, tblBorrows.BrowwedDate_jalai, tblBorrows.Reterned_data_jalali 
                                    from tblBorrows 
                                    INNER JOIN tblMembers  
                                    on tblBorrows.Borrower = tblMembers.Id join Books on tblBorrows.Book = Books.Id";
             

            switch (searchby)
            {
                case SearchBy.RegisteratinID:
                    try
                    {
                        int.Parse(txtRegisterationId.Text.Trim());
                        if (txtRegisterationId.Text.Trim() != "")
                        {
                            commmandStr += " " + @"and tblMembers.Id = " + q;
                        }
                    }
                    catch (Exception ex)
                    {
                        //conn.Close();
                        //MessageBox.Show("لطفا عدد وارد کنید");
                        //return;
                    }
                    break;
                case SearchBy.FirstName:
                    commmandStr += " " + @"and (  tblMembers.FirstName like $q)";
                    break;
                case SearchBy.LastName:
                    commmandStr += " " + @"and (  tblMembers.LastName like $q)";
                    break;
                case SearchBy.BookName:
                    commmandStr += " " + @"and (  Books.Name like $q)";
                    break;
                case SearchBy.Phone:
                    commmandStr += " " + @"and ( tblMembers.Phone like $q)";
                    break;
                case SearchBy.BookId:
                    try
                    {
                        int.Parse(txtSearchByBookId.Text.Trim());

                        commmandStr += " " + "and BookId = " + txtSearchByBookId.Text.Trim();

                    }
                    catch(Exception ex) { 
                    }
                    break;
                default:
                    break;
            }

            if (chOnlyNotReterned.Checked) // فقط در کتاب هایی که در امانت هستند جستجو اتجام گیرد
            {
                commmandStr += onlyInNotReturned();
            }

            /*

            if (rbOther.Checked)
            {
                commmandStr +=" " + @"and ( Books.name like $q or  
                                            tblMembers.FirstName like $q or 
                                            tblMembers.FirstName like $q or 
                                            tblMembers.Phone like $q)";
            }
            else
            {
                try
                {
                    int.Parse(txtSearch.Text.Trim());
                    if (txtSearch.Text.Trim() != "")
                    {
                        commmandStr += " " + @"and tblBorrows.Id = " + q;
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    //MessageBox.Show("لطفا عدد وارد کنید");
                    return;
                } 
            }


            */

            commmandStr += addOederBy();


            cmd.CommandText = commmandStr;

            cmd.Parameters.AddWithValue("$q", "%" + q + "%");

            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            RenameCloums(dt);
            /*
            dt.Columns["id"].ColumnName = "کد";
            dt.Columns["FirstName"].ColumnName = "نام";
            dt.Columns["LastName"].ColumnName = "نام خانوادگی";
            dt.Columns["Phone"].ColumnName = "تلفن";
            dt.Columns["BookName"].ColumnName = "نام کتاب";
            dt.Columns["BrowwedDate_jalai"].ColumnName = " تاریخ امانت";
            dt.Columns["Reterned_data_jalali"].ColumnName = " تاریخ برگشت";
            */
            conn.Close();

            dtBorrows.Columns["BookId"].Visible = false;


            dtBorrows.Columns[0].Width = 65;  // ردیف
            dtBorrows.Columns[1].Width = 210; // نام کتاب
            dtBorrows.Columns[6].Width = 130; // شماره تماس
            dtBorrows.Columns[3].Width = 120;  // کد عضویت
        }

        private string addOederBy()
        {
            return " ORDER BY tblBorrows.Id DESC";
        }

        private string onlyInNotReturned()
        {
            return " " + @"where tblBorrows.ReternedDate is NULL";
        }

        private void dtBorrows_SelectionChanged(object sender, EventArgs e)
        {
            if(dtBorrows.SelectedRows.Count == 1)
            {
               btnReterned.Visible = true;
               btnExtend.Visible = true;
            }
        }

        private void btnReterned_Click(object sender, EventArgs e)
        {
            if (dtBorrows.SelectedRows.Count == 0)
                return;

            int id = int.Parse(dtBorrows.SelectedRows[0].Cells[0].Value.ToString());



            ReturnBook(id, dtBorrows.SelectedRows[0].Cells["BookID"].Value.ToString());
            
            /*
            OpenConnection();

            var transaction = conn.BeginTransaction();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"update tblBorrows SET ReternedDate = $reternedDate, Reterned_data_jalali = $reternedDate_jalali
                                    where Id = $id";
            cmd.Parameters.AddWithValue("$reternedDate", DateTime.Now.Ticks);
            cmd.Parameters.AddWithValue("$reternedDate_jalali", getPersinaDate());
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();


            cmd.CommandText = "UPDATE Books SET Status ='موجود' WHERE  Id = " + dtBorrows.SelectedRows[0].Cells["BookID"].Value.ToString();
            cmd.ExecuteNonQuery();

            transaction.Commit();

            conn.Close();*/

            //LastTimeSearchedBy = SearchBy.BookName;
            SearchByLast();

            lblReternedStatus.Visible = true;
            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t) => lblReternedStatus.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
        }


        private void ReturnBook(int BorrowId, string BookId)
        {
            OpenConnection();

            var transaction = conn.BeginTransaction();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"update tblBorrows SET ReternedDate = $reternedDate, Reterned_data_jalali = $reternedDate_jalali
                                    where Id = $id";
            cmd.Parameters.AddWithValue("$reternedDate", DateTime.Now.Ticks);
            cmd.Parameters.AddWithValue("$reternedDate_jalali", getPersinaDate());
            cmd.Parameters.AddWithValue("$id", BorrowId);

            cmd.ExecuteNonQuery();


            cmd.CommandText = "UPDATE Books SET Status ='موجود' WHERE  Id = " + BookId;
            cmd.ExecuteNonQuery();

            transaction.Commit();

            conn.Close();
        }

        private void OpenConnection(){
            conn.Open();
        }

        private string getPersinaDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime _now = DateTime.Now;
            return pc.GetYear(_now) + "-" + string.Format("{0:00}", pc.GetMonth(_now)) + "-" + string.Format("{0:00}", pc.GetDayOfMonth(_now));
        }

        private void RenameCloums (DataTable dt)
        {
            dt.Columns["id"].ColumnName = "ردیف";
            dt.Columns["id1"].ColumnName = "کد عضویت";
            dt.Columns["FirstName"].ColumnName = "نام";
            dt.Columns["LastName"].ColumnName = "نام خانوادگی";
            dt.Columns["Phone"].ColumnName = "تلفن";
            dt.Columns["BookName"].ColumnName = "نام کتاب";
            dt.Columns["BrowwedDate_jalai"].ColumnName = " تاریخ امانت";
            dt.Columns["Reterned_data_jalali"].ColumnName = " تاریخ برگشت";
            
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            //search();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
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

            var book = books.FirstOrDefault(x => x.Value == lstBookNames.SelectedItems[0].ToString());
            books.Remove(book.Key);
            lstBookNames.Items.RemoveAt(lstBookNames.SelectedIndex);

            txtBookTitle.Text = "";
        }

        private void txtRegisterationId_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.RegisteratinID;
            SearchByLast();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.FirstName;
            //search(SearchBy.FirstName, txtFirstName.Text);
            SearchByLast();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.LastName;
            ///search(SearchBy.LastName, txtLastName.Text);
            SearchByLast();
        }

        private void chOnlyNotReterned_CheckedChanged(object sender, EventArgs e)
        {
            SearchByLast();
        }

        private void SearchByLast()
        {
            switch (LastTimeSearchedBy)
            {
                case SearchBy.FirstName:
                    search(SearchBy.FirstName, txtFirstName.Text.Trim());
                    break;
                case SearchBy.LastName:
                    search(SearchBy.LastName, txtLastName.Text.Trim());
                    break;
                case SearchBy.RegisteratinID:
                    search(SearchBy.RegisteratinID, txtRegisterationId.Text.Trim());
                    break;
                case SearchBy.BookName:
                    search(SearchBy.BookName, txtBookName.Text.Trim());
                    break;
                case SearchBy.Phone:
                    search(SearchBy.Phone, txtPhone.Text.Trim());
                    break;
                case SearchBy.BookId: 
                    search(SearchBy.BookId, txtSearchByBookId.Text.Trim());
                    break;

                default:
                    break;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.Phone;
            //search(SearchBy.Phone, txtPhone.Text.Trim());

            SearchByLast();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookName;
            SearchByLast();
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookName;
            search(SearchBy.BookName, "");
        }

        private void frmBorrow_Shown(object sender, EventArgs e)
        {
            btnSearchBook.Focus();
        }

        private void txtBookId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBookId.Text.Trim() != "")
            {
                bool IsBookAdded =  AddBookById();
                if(IsBookAdded)
                    txtBookId.Text = "";
            }

            if (e.KeyCode == Keys.Down)
                if(lstBookNames.Items.Count > 0 && lstBookNames.SelectedIndex < lstBookNames.Items.Count-1 )
                    lstBookNames.SelectedIndex += 1;
            
            if(e.KeyCode == Keys.Up)
                if(lstBookNames.Items.Count > 0 &&  lstBookNames.SelectedIndex>0)
                    lstBookNames.SelectedIndex -= 1;

            if (e.KeyCode == Keys.Delete)
                DeleteSelectedBook();
        }

        private bool AddBookById()
        {
            try
            {
                int.Parse(txtBookId.Text.Trim());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("لطفا فقط عدد وارد کنید");
                return false;
            }

            bool result =  AddBookToList();

            return result;
        }

        private Boolean AddBookToList()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            //dtBooks.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select Id, Name, Writer, Publisher, Description from Books where Name like $t";
            cmd.CommandText = @"SELECT Books.Id
                                from tblBorrows 
                                INNER JOIN tblMembers  
                                on tblBorrows.Borrower = tblMembers.Id join Books on tblBorrows.Book = Books.Id
                                where Status = 'در امانت' and Books.Id =  " + txtBookId.Text.Trim();
            //cmd.CommandText = "select * from Books where Name like  '%ن%'"; 
            //cmd.Parameters.AddWithValue("$t", "%" + txtBookId.Text.Trim() + "%");


            ad = new SQLiteDataAdapter(cmd);

            //dtBooks.AutoGenerateColumns = false;/////////////
            ad.Fill(dt);
            conn.Close();
            if (dt.Rows.Count >= 1)
            {
                //lstBookNames.Items.Add(dt.Rows[0].ItemArray[0].ToString().Trim());

                MessageBox.Show("این کتاب قبلا امانت داده شده است");
               
                return false;
            }
            else
            {
                conn.Open();

                cmd.CommandText = @"select Id, Name, Status from Books 
                                where Id =" + txtBookId.Text.Trim();

                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);

                if (dt.Rows.Count == 1)
                    AddBook(int.Parse(dt.Rows[0].ItemArray[0].ToString().Trim()), dt.Rows[0].ItemArray[1].ToString().Trim());
                else
                { }
            }
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

            return true;
        }

        private void btnAddBookById_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text.Trim() != "")
            {
                AddBookById();
                txtBookId.Text = "";
            }
          
        }

        private void AddBorrowerById()
        {
            int id = -1;
            try
            {
                id = int.Parse(txtBorrowerId.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("لطفا فقط عدد وارد کنید");
                return;
            }


            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();


            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = @"select Id, FirstName, LastName  from tblMembers 
                                where  Id = " +  txtBorrowerId.Text.Trim();
            

            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                txtBorrower.Text = dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString();
                this.BorrowerId = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                btnSave.Focus();
            }
            
            conn.Close();
            txtRegisterationId.Text = this.BorrowerId.ToString();
        }

        private void btnAddBorrowerById_Click(object sender, EventArgs e)
        {
            AddBorrowerById();
        }

        private void txtBorrowerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBorrowerId.Text.Trim() != "")
            {
                AddBorrowerById();
                txtBorrowerId.Text = "";
            }
        }

        private void txtSearchByBookId_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookId;
            SearchByLast();
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (dtBorrows.SelectedRows.Count == 0)
                return;

            BorrowerId = int.Parse(dtBorrows.SelectedRows[0].Cells[3].Value.ToString());

            int BorrowId = int.Parse(dtBorrows.SelectedRows[0].Cells[0].Value.ToString());

            int BookId = int.Parse(dtBorrows.SelectedRows[0].Cells[2].Value.ToString());


            ReturnBook(BorrowId, BookId.ToString());

            lstBookNames.Items.Add(BookId);
            books.Add(BookId, "");

            btnSave_Click(sender, e);

            
        }

        private void btnDeleteAllText_Click(object sender, EventArgs e)
        {
            txtSearchByBookId.Text = "";
            txtBookTitle.Text = "";
            lstBookNames.Items.Clear();
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtRegisterationId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtSearchByBookId.Focus();
        }

        private void lstBookNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedBook();
            }
        }
    }
}
