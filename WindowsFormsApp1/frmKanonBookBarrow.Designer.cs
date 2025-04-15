namespace WindowsFormsApp1
{
    partial class frmKanonBookBarrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddBookById = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lstBookNames = new System.Windows.Forms.ListBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.chOnlyNotReterned = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.dtBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSaved);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAddBookById);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBookId);
            this.groupBox2.Controls.Add(this.btnDeleteBook);
            this.groupBox2.Controls.Add(this.lstBookNames);
            this.groupBox2.Controls.Add(this.txtBookTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearchBook);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1274, 360);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کتاب جدید";
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSaved.Location = new System.Drawing.Point(623, 297);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSaved.Size = new System.Drawing.Size(73, 34);
            this.lblSaved.TabIndex = 25;
            this.lblSaved.Text = "ثبت شد";
            this.lblSaved.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(724, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 49);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddBookById
            // 
            this.btnAddBookById.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookById.Location = new System.Drawing.Point(724, 45);
            this.btnAddBookById.Name = "btnAddBookById";
            this.btnAddBookById.Size = new System.Drawing.Size(54, 46);
            this.btnAddBookById.TabIndex = 23;
            this.btnAddBookById.Text = "+";
            this.btnAddBookById.UseVisualStyleBackColor = true;
            this.btnAddBookById.Click += new System.EventHandler(this.btnAddBookById_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(1078, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 41);
            this.label9.TabIndex = 22;
            this.label9.Text = "کد یا عنوان کتاب";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("B Nazanin", 15.2F);
            this.txtBookId.Location = new System.Drawing.Point(784, 45);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookId.Size = new System.Drawing.Size(254, 45);
            this.txtBookId.TabIndex = 21;
            this.txtBookId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookId_KeyDown);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(894, 289);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(137, 49);
            this.btnDeleteBook.TabIndex = 20;
            this.btnDeleteBook.Text = "حذف";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lstBookNames
            // 
            this.lstBookNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBookNames.FormattingEnabled = true;
            this.lstBookNames.ItemHeight = 29;
            this.lstBookNames.Location = new System.Drawing.Point(723, 105);
            this.lstBookNames.Name = "lstBookNames";
            this.lstBookNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBookNames.Size = new System.Drawing.Size(526, 178);
            this.lstBookNames.TabIndex = 19;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(124, 87);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookTitle.Size = new System.Drawing.Size(254, 36);
            this.txtBookTitle.TabIndex = 11;
            this.txtBookTitle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(468, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "عنوان کتاب";
            this.label1.Visible = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(64, 86);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(54, 41);
            this.btnSearchBook.TabIndex = 17;
            this.btnSearchBook.Text = "...";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.chOnlyNotReterned);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchBooks);
            this.groupBox1.Controls.Add(this.dtBorrowedBooks);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1274, 662);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کتاب‌های در امانت";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1123, 607);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 49);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "برگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // chOnlyNotReterned
            // 
            this.chOnlyNotReterned.AutoSize = true;
            this.chOnlyNotReterned.Checked = true;
            this.chOnlyNotReterned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chOnlyNotReterned.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chOnlyNotReterned.Location = new System.Drawing.Point(952, 144);
            this.chOnlyNotReterned.Name = "chOnlyNotReterned";
            this.chOnlyNotReterned.Size = new System.Drawing.Size(308, 45);
            this.chOnlyNotReterned.TabIndex = 24;
            this.chOnlyNotReterned.Text = "فقط در بین کتاب‌های در امانت";
            this.chOnlyNotReterned.UseVisualStyleBackColor = true;
            this.chOnlyNotReterned.CheckedChanged += new System.EventHandler(this.chOnlyNotReterned_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1120, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 41);
            this.label2.TabIndex = 23;
            this.label2.Text = "عنوان کتاب";
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Font = new System.Drawing.Font("B Nazanin", 15.2F);
            this.txtSearchBooks.Location = new System.Drawing.Point(1006, 88);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(254, 45);
            this.txtSearchBooks.TabIndex = 22;
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            // 
            // dtBorrowedBooks
            // 
            this.dtBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BookName,
            this.BarrowedDate,
            this.ReturnedDate});
            this.dtBorrowedBooks.Location = new System.Drawing.Point(16, 203);
            this.dtBorrowedBooks.Name = "dtBorrowedBooks";
            this.dtBorrowedBooks.ReadOnly = true;
            this.dtBorrowedBooks.RowHeadersWidth = 51;
            this.dtBorrowedBooks.RowTemplate.Height = 24;
            this.dtBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtBorrowedBooks.Size = new System.Drawing.Size(1244, 398);
            this.dtBorrowedBooks.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.BookName.DefaultCellStyle = dataGridViewCellStyle13;
            this.BookName.HeaderText = "نام کتاب";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 210;
            // 
            // BarrowedDate
            // 
            this.BarrowedDate.DataPropertyName = "BarrowedDateJalali";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.BarrowedDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.BarrowedDate.HeaderText = "تاریخ امانت";
            this.BarrowedDate.MinimumWidth = 6;
            this.BarrowedDate.Name = "BarrowedDate";
            this.BarrowedDate.ReadOnly = true;
            this.BarrowedDate.Width = 135;
            // 
            // ReturnedDate
            // 
            this.ReturnedDate.DataPropertyName = "ReturnedDateJalali";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.ReturnedDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.ReturnedDate.HeaderText = "تاریخ برگشت";
            this.ReturnedDate.MinimumWidth = 6;
            this.ReturnedDate.Name = "ReturnedDate";
            this.ReturnedDate.ReadOnly = true;
            this.ReturnedDate.Width = 135;
            // 
            // frmKanonBookBarrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmKanonBookBarrow";
            this.Text = "مدیریت کانون";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrowedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBookById;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.ListBox lstBookNames;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtBorrowedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.CheckBox chOnlyNotReterned;
        private System.Windows.Forms.Button btnReturn;
    }
}