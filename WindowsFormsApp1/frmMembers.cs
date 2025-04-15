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
    public partial class frmMembers : Form
    {

        enum SearchBy
        {
            FirstName,
            LastName,
            Phone,
            Nothing
        }

        SQLiteConnection conn;
        public bool isDialog { get; set; }

        public string PersonName { get; set; } = "";
        public int Id { get; set; } = 0;

        public frmMembers()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=./Book.db");
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            AddNewMember();
        }

        private void AddNewMember()
        {
            bool isOk = checkFields();

            if (!isOk)
                return;


            /*if(IsMemeberExist(txtPhoneNumber.Text.Trim())){

            }*/

            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into tblMembers (FirstName, LastName, Phone, Description, NationalCode) VALUES ($firstName, $lastName, $phone, $Description, $NationalCode)";

            cmd.Parameters.AddWithValue("$firstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("$lastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("$phone", txtPhoneNumber.Text.Trim());
            cmd.Parameters.AddWithValue("$Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("$NationalCode", txtNationalCode.Text.Trim());

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            clearTextBoxes();
            ShowLast10();
            //txtFirstName.Focus();
            btnSelect.Focus();
        }


        private Boolean IsMemeberExist(string phone)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            cmd.CommandText = "select phone from tblMembers where Phone=" + "\"" + phone + "\"";
            

            cmd.Connection = conn;
            var count = cmd.ExecuteScalar();
            conn.Close();

            return int.Parse(count.ToString()) >0;

        }

        private bool checkFields()
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام عضو را وارد کنید");
                return false;
            }

            return true;
        }

        private void clearTextBoxes()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text= "";
            txtNationalCode.Text = "";
            txtDescription.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectMember();
        }

        private void SelectMember()
        {
            if (dtMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفا فرد مورد نظر را انتخاب کنید");
            }
            else
            {
                this.PersonName = dtMembers.SelectedRows[0].Cells["نام"].Value.ToString() + " " + dtMembers.SelectedRows[0].Cells["نام خانوادگی"].Value.ToString();
                this.Id = int.Parse(dtMembers.SelectedRows[0].Cells["کد عضویت"].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        int i = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //i = 0;
            //search();
        }

        SearchBy LastSearch;

        private void search(SearchBy searchBy)
        {
            LastSearch = searchBy;

            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            string q = txtSearchFirstName.Text.Trim();

            conn.Open();
            dtMembers.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();

            int id = -1;
            try
            {
                id = int.Parse(q);
            }
            catch (Exception ex) {
            }

            if (id > 0 && id <= 9999 & txtSearchFirstName.Text.Length <= 4 && !txtSearchFirstName.Text.StartsWith("0"))
            {
                cmd.CommandText = @"select Id, FirstName, LastName, Phone , Description from tblMembers 
                                    where  Id like $t";
            }
            else {

                cmd.CommandText = @"select Id, FirstName, LastName, Phone, NationalCode, Description from tblMembers";
                                    

                switch(searchBy)
                {
                    case SearchBy.FirstName:
                        cmd.CommandText += " where FirstName like '%" + txtSearchFirstName.Text.Trim()+"%'";
                        break;

                    case SearchBy.LastName:
                        cmd.CommandText += " where LastName like '%" + txtSearchLastName.Text.Trim()+"%'";
                        break;
                    case SearchBy.Phone:
                        cmd.CommandText += " where Phone like '%" + txtSearchPhone.Text.Trim()+"%'";
                        break;

                    default:
                        break;
                }

                cmd.CommandText +=" ORDER BY Id DESC";
            }

            //cmd.Parameters.AddWithValue("$t", "%" + q + "%");

            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);
            conn.Close();

            RenameCloums(dt);
        }

        private void RenameCloums(DataTable dt)
        {
            dt.Columns["Id"].ColumnName = "کد عضویت";
            dt.Columns["FirstName"].ColumnName = "نام";
            dt.Columns["LastName"].ColumnName = "نام خانوادگی";
            dt.Columns["Phone"].ColumnName = "تلفن";
            dt.Columns["NationalCode"].ColumnName = "کد ملی";
            dt.Columns["Description"].ColumnName = "توضیح";
        }

        private void ShowLast10()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            conn.Open();
            dtMembers.DataSource = dt;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT Id, FirstName, LastName, Phone,NationalCode, Description, DelayCount from tblMembers 
                                ORDER BY Id DESC";

            

            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);

            //dt.Columns["Name"].ColumnName = "عنوان";
            //dt.Columns["PublishedYear"].ColumnName = "سال انتشار";
            //dt.Columns["Description"].ColumnName = "توضیحات";
            
            conn.Close();

            RenameCloums(dt);
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            if (this.isDialog)
            {
                btnSelect.Visible = true;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtMembers.CurrentRow == null)
                return;

            i = dtMembers.CurrentRow.Index;

            if(e.KeyCode == Keys.Enter)
            {
                //search();
            }

            if (e.KeyCode == Keys.Down)
            {
                if(i< dtMembers.RowCount-2)
                    dtMembers.CurrentCell = dtMembers[0, ++i];
            }

            if (e.KeyCode == Keys.Up)
            {
                if (i > 0)
                    dtMembers.CurrentCell = dtMembers[0, --i];
            }

            if (e.KeyCode == Keys.Delete)
            {
                DeleteMember();
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search(SearchBy.FirstName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMember();
        }

        private void DeleteMember()
        {
            if (dtMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("ابتدا عضو مورد نظر را انتخاب کنید");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("این عضو حذف خواهد شد. آیا مطئنید؟", "حذف عضو", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM tblMembers WHERE Id = " + dtMembers.SelectedRows[0].Cells["کد عضویت"].Value.ToString().Trim();
            cmd.ExecuteNonQuery();

            conn.Close();

            search(SearchBy.Nothing);
        }

        private void dtMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteMember();
            }

            if (!isDialog)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                SelectMember();
            }
        }

        private void dtMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtMembers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dtMembers.SelectedRows.Count == 0 || dtMembers.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("ابتدا کاربر مورد نظر را انتخاب کنید");
                return;
            }

            string Id = dtMembers.SelectedRows[0].Cells[0].Value.ToString().Trim();

            /*
            string Title  = 1dtBooks.SelectedRows[0].Cells["clBookName"].Value.ToString().Trim();
            string Writer  = dtBooks.SelectedRows[0].Cells["clWriter"].Value.ToString().Trim();
            string Publisher  = dtBooks.SelectedRows[0].Cells["clPublisher"].Value.ToString().Trim();
            string PublishedYear = dtBooks.SelectedRows[0].Cells["clPublishedYear"].Value.ToString().Trim();
            */
            Form frmEditMember = new frmEditUsers(int.Parse(Id));
            frmEditMember.ShowDialog();
            search(LastSearch);
        }

        private void frmMembers_Shown(object sender, EventArgs e)
        {
            search(SearchBy.Nothing);
            txtFirstName.Focus();
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewMember();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewMember();
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewMember();
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewMember();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //txtSearch.Text = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //txtSearch.Text = txtLastName.Text;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length == 11 )   
                txtSearchPhone.Text = txtPhoneNumber.Text;
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = txtFirstName.Text;
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = txtLastName.Text;
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSearchLastName_TextChanged(object sender, EventArgs e)
        {
            search(SearchBy.LastName);
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            search(SearchBy.Phone);
        }
    }
}
