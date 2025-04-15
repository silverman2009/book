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
    public partial class frmStatistics : Form
    {
        SQLiteConnection conn;

        public frmStatistics()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db");
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

            ThisWeek();
            ThisMonth();
            ThisYear();
            TotlaOfNotReturnedBooks();
            delayedBooks();
        }

        private void ThisWeek()
        {
            var startOfThisWeekDate = (new DateTime(DateTime.Now.Ticks)).AddDays(-1 * getDayOfWeek((int)DateTime.Now.DayOfWeek));

            long startOfThisWeekTick = new DateTime(startOfThisWeekDate.Year, startOfThisWeekDate.Month, startOfThisWeekDate.Day).Ticks;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = @"select count(*) from tblBorrows where BorrowedDate >= " + startOfThisWeekTick;

            var Count = cmd.ExecuteScalar();

            lblCountOfBorrowedBookThisWeek.Text = Count.ToString();
            conn.Close();
        }

        private void ThisMonth()
        {
            PersianCalendar pc = new PersianCalendar();

            long StartOfMonth = (new DateTime(DateTime.Now.Ticks)).AddDays(-1 * pc.GetDayOfMonth(DateTime.Now)).Ticks;

            var s = (new DateTime(DateTime.Now.Ticks));


            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = @"select count(*) from tblBorrows where BorrowedDate >= " + StartOfMonth;

            var Count = cmd.ExecuteScalar();

            lblCountOfBorrowedBookThisMonth.Text = Count.ToString();
            conn.Close();
        }

        private void ThisYear()
        {
            PersianCalendar pc = new PersianCalendar();

            long StartOfYear = (new DateTime(DateTime.Now.Ticks)).AddDays(-1 * pc.GetDayOfYear(DateTime.Now)).Ticks;
             

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = @"select count(*) from tblBorrows where BorrowedDate >= " + StartOfYear;

            var Count = cmd.ExecuteScalar();

            lblCountOfBorrowedBookThisYear.Text = Count.ToString();
            conn.Close();
        }

        private void TotlaOfNotReturnedBooks()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = @"select count(*) from  tblBorrows where ReternedDate is null";

            var Count = cmd.ExecuteScalar();
            
            conn.Close();

            lblBookNotReturned.Text = Count.ToString();
        }


        private void delayedBooks()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = @"select count(*) from  tblBorrows where  ReternedDate is null and BorrowedDate <=" + DateTime.Now.StartOfDay().AddDays(-30).Ticks; ;


            var Count = cmd.ExecuteScalar();

            conn.Close();

            lblbDelayedBooksCount.Text = Count.ToString();
        }

        private int getDayOfWeek (int dayOfWeek_miladi)
        {
            switch (dayOfWeek_miladi)
            {
                    case 6: 
                        return 0;
                    case 7: 
                        return 1;
                    case 1:
                        return 2;
                    case 2: 
                        return 3;
                    case 3:
                        return 4;
                    case 4:
                        return 5;
                    case 5: 
                        return 6;
                default:
                    return -1;
            }
        }
    }
}
