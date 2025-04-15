using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAddNewBook = new frmAddNewBook();
            frmAddNewBook.WindowState =FormWindowState.Maximized;
            frmAddNewBook.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Form frmBorrow = new frmBorrow();
            frmBorrow.WindowState = FormWindowState.Maximized;
            frmBorrow.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Form frmMeber = new frmMembers();
            frmMeber.WindowState = FormWindowState.Maximized;
            frmMeber.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnDelayedBooks_Click(object sender, EventArgs e)
        {
            Form frmDelayedBooks = new frmDelayedBooks();
            frmDelayedBooks.WindowState = FormWindowState.Maximized;
            frmDelayedBooks.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Form frmStatistics = new frmStatistics();
            frmStatistics.Show();
        }

        private void btnAddKanon_Click(object sender, EventArgs e)
        {
            Form frmAddKanon = new frmKanon();
            frmAddKanon.Show();
        }

        private void btnKannonBookBarrow_Click(object sender, EventArgs e)
        {
            Form _frmKanonBookBarrow = new frmKanonBookBarrow();
            _frmKanonBookBarrow.Show();
        }
    }
}
