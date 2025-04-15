using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using Font = iTextSharp.text.Font;

namespace WindowsFormsApp1
{
    public partial class frmDelayedBooks : Form
    {
        SQLiteConnection conn;
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

        public frmDelayedBooks()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db");
        }

        private void ShowBorrow()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtBorrows.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT  ,Books.Name as BookName,   tblMembers.FirstName, tblMembers.LastName, tblMembers.Phone, tblBorrows.BrowwedDate_jalai, tblBorrows.Reterned_data_jalali 
                                    from tblBorrows 
                                    INNER JOIN tblMembers  
                                    on tblBorrows.Borrower = tblMembers.Id join Books on tblBorrows.Book = Books.Id
                                    where tblBorrows.ReternedDate is  NULL
                                    ORDER BY tblBorrows.Id DESC
                                    limit 10";


            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            RenameCloums(dt);
            conn.Close();
        }

        private void RenameCloums(DataTable dt)
        {
            dt.Columns["id"].ColumnName = "ردیف";
            dt.Columns["id1"].ColumnName = "کد عضویت";
            dt.Columns["FirstName"].ColumnName = "نام";
            dt.Columns["LastName"].ColumnName = "نام خانوادگی";
            dt.Columns["Phone"].ColumnName = "تلفن";
            dt.Columns["BookName"].ColumnName = "نام کتاب";
            dt.Columns["BrowwedDate_jalai"].ColumnName = " تاریخ امانت";
            
        }

        private void frmDelayedBooks_Load(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookName;
            search(SearchBy.BookName, "");
        }

        private void search(SearchBy searchby, string q)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            //string q = txtSearch.Text.Trim();

            conn.Open();
            dtBorrows.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            string commmandStr = @"SELECT tblBorrows.Id,  Books.Name as BookName, tblMembers.Id, tblMembers.FirstName, tblMembers.LastName, 
                                    tblMembers.Phone, tblBorrows.BrowwedDate_jalai 
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
                    catch (Exception ex)
                    {
                    }
                    break;
                default:
                    break;
            }
             
            commmandStr += onlyInNotReturned();
            commmandStr += addOederBy();

            cmd.CommandText = commmandStr;

            cmd.Parameters.AddWithValue("$q", "%" + q + "%");

            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            RenameCloums(dt);
            conn.Close();

        }

        private string addOederBy()
        {
            return " ORDER BY tblBorrows.Id DESC";
        }

        private string onlyInNotReturned()
        {
            return " " + @"where tblBorrows.ReternedDate is  NULL AND BorrowedDate <=" + DateTime.Now.AddMonths(-1).Ticks;
        }

        private void txtSearchByBookId_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookId;
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

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.BookName;
            SearchByLast();
        }

        private void txtRegisterationId_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.RegisteratinID;
            SearchByLast();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.FirstName;
            SearchByLast();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.LastName;
            SearchByLast();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            LastTimeSearchedBy = SearchBy.Phone;
            SearchByLast();
        }

        private void btnReterned_Click(object sender, EventArgs e)
        {
            if (dtBorrows.SelectedRows.Count == 0)
                return;

            int id = int.Parse(dtBorrows.SelectedRows[0].Cells[0].Value.ToString());

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


            cmd.CommandText = "UPDATE  Books SET Status ='موجود' WHERE  Id = " + dtBorrows.SelectedRows[0].Cells["BookID"].Value.ToString();
            cmd.ExecuteNonQuery();

            transaction.Commit();

            conn.Close();

            SearchByLast();

            lblReternedStatus.Visible = true;
            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith((t) => lblReternedStatus.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void OpenConnection()
        {
            conn.Open();
        }

        private string getPersinaDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime _now = DateTime.Now;
            return pc.GetYear(_now) + "-" + string.Format("{0:00}", pc.GetMonth(_now)) + "-" + string.Format("{0:00}", pc.GetDayOfMonth(_now));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print(); 
        }

        private void print()
        {

            string PdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\تاخیری ها-"+getPersinaDate()+ ".pdf" ;
            // مسیر فایل فونت فارسی


            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "BNazanin.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(baseFont, 12);

            FontSelector fontSelector = new FontSelector();

            fontSelector.AddFont(font);

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(PdfFilePath, FileMode.Create));
            document.Open();

            PdfPTable pdfTable = new PdfPTable(dtBorrows.Columns.Count);
            pdfTable.WidthPercentage = 100;

            pdfTable.SetWidths(new float[] { 1.2f , 1.7f , 1 , 1 , 0.5f , 4 , 0.7f });


            // تنظیم جهت راست به چپ برای جدول
            pdfTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            // اضافه کردن سرفصل‌ها
            foreach (DataGridViewColumn column in dtBorrows.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; // راست به چپ کردن متن در سلول
                pdfTable.AddCell(cell);
            }

            // اضافه کردن ردیف‌ها

            bool isGray = false;
            foreach (DataGridViewRow row in dtBorrows.Rows)
            {
                foreach (DataGridViewCell gridCell in row.Cells)
                {
                    //PdfPCell pdfCell = new PdfPCell(new Phrase(gridCell.Value?.ToString(), font));

                    var pdfCell = new PdfPCell { RunDirection = PdfWriter.RUN_DIRECTION_RTL, Border = 0 };
                    pdfCell.Phrase = fontSelector.Process(gridCell.Value == null ? "" : gridCell.Value.ToString());
                    pdfCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; // راست به چپ کردن متن در سلول
                    pdfCell.Border = PdfPCell.BOX;

                    pdfCell.Padding = 2f;

                    if (isGray)
                    {
                        pdfCell.BackgroundColor = new BaseColor(230, 230, 230);  // رنگ خاکستری روشن
                    }


                    pdfTable.AddCell(pdfCell);

                    
                }

                isGray = !isGray;
            }

            document.Add(pdfTable);
            document.Close();


            /*using (FileStream stream = new FileStream("1.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);



                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }*/
        }



    }


}
