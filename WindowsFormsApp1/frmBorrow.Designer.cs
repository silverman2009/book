namespace WindowsFormsApp1
{
    partial class frmBorrow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnDeleteAllText = new System.Windows.Forms.Button();
            this.lblReternedStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchByBookId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReterned = new System.Windows.Forms.Button();
            this.txtRegisterationId = new System.Windows.Forms.TextBox();
            this.chOnlyNotReterned = new System.Windows.Forms.CheckBox();
            this.dtBorrows = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBorrowerById = new System.Windows.Forms.Button();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddBookById = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lstBookNames = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrows)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.btnExtend);
            this.groupBox1.Controls.Add(this.btnDeleteAllText);
            this.groupBox1.Controls.Add(this.lblReternedStatus);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSearchByBookId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnReterned);
            this.groupBox1.Controls.Add(this.txtRegisterationId);
            this.groupBox1.Controls.Add(this.chOnlyNotReterned);
            this.groupBox1.Controls.Add(this.dtBorrows);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1450, 663);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تحویل کتاب";
            // 
            // btnExtend
            // 
            this.btnExtend.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExtend.Location = new System.Drawing.Point(41, 576);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(169, 53);
            this.btnExtend.TabIndex = 30;
            this.btnExtend.Text = "تمدید";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Visible = false;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnDeleteAllText
            // 
            this.btnDeleteAllText.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAllText.Location = new System.Drawing.Point(18, 114);
            this.btnDeleteAllText.Name = "btnDeleteAllText";
            this.btnDeleteAllText.Size = new System.Drawing.Size(127, 53);
            this.btnDeleteAllText.TabIndex = 28;
            this.btnDeleteAllText.Text = "پاک کردن";
            this.btnDeleteAllText.UseVisualStyleBackColor = true;
            this.btnDeleteAllText.Click += new System.EventHandler(this.btnDeleteAllText_Click);
            // 
            // lblReternedStatus
            // 
            this.lblReternedStatus.AutoSize = true;
            this.lblReternedStatus.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReternedStatus.ForeColor = System.Drawing.Color.Green;
            this.lblReternedStatus.Location = new System.Drawing.Point(1164, 576);
            this.lblReternedStatus.Name = "lblReternedStatus";
            this.lblReternedStatus.Size = new System.Drawing.Size(92, 44);
            this.lblReternedStatus.TabIndex = 24;
            this.lblReternedStatus.Text = "ثبت شد";
            this.lblReternedStatus.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(1327, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "کد کتاب";
            // 
            // txtSearchByBookId
            // 
            this.txtSearchByBookId.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchByBookId.Location = new System.Drawing.Point(1308, 117);
            this.txtSearchByBookId.Name = "txtSearchByBookId";
            this.txtSearchByBookId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchByBookId.Size = new System.Drawing.Size(123, 48);
            this.txtSearchByBookId.TabIndex = 22;
            this.txtSearchByBookId.TextChanged += new System.EventHandler(this.txtSearchByBookId_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(1104, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "عنوان کتاب";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBookName.Location = new System.Drawing.Point(1048, 117);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookName.Size = new System.Drawing.Size(254, 48);
            this.txtBookName.TabIndex = 23;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(221, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "شماره تلفن";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhone.Location = new System.Drawing.Point(151, 117);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(238, 48);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(464, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLastName.Location = new System.Drawing.Point(395, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(254, 48);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(756, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(927, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "کد عضویت";
            // 
            // btnReterned
            // 
            this.btnReterned.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReterned.Location = new System.Drawing.Point(1262, 573);
            this.btnReterned.Name = "btnReterned";
            this.btnReterned.Size = new System.Drawing.Size(169, 53);
            this.btnReterned.TabIndex = 29;
            this.btnReterned.Text = "برگشت";
            this.btnReterned.UseVisualStyleBackColor = true;
            this.btnReterned.Visible = false;
            this.btnReterned.Click += new System.EventHandler(this.btnReterned_Click);
            // 
            // txtRegisterationId
            // 
            this.txtRegisterationId.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRegisterationId.Location = new System.Drawing.Point(915, 117);
            this.txtRegisterationId.Name = "txtRegisterationId";
            this.txtRegisterationId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegisterationId.Size = new System.Drawing.Size(127, 48);
            this.txtRegisterationId.TabIndex = 24;
            this.txtRegisterationId.TextChanged += new System.EventHandler(this.txtRegisterationId_TextChanged);
            // 
            // chOnlyNotReterned
            // 
            this.chOnlyNotReterned.AutoSize = true;
            this.chOnlyNotReterned.Checked = true;
            this.chOnlyNotReterned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chOnlyNotReterned.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chOnlyNotReterned.Location = new System.Drawing.Point(1119, 170);
            this.chOnlyNotReterned.Name = "chOnlyNotReterned";
            this.chOnlyNotReterned.Size = new System.Drawing.Size(308, 45);
            this.chOnlyNotReterned.TabIndex = 6;
            this.chOnlyNotReterned.Text = "فقط در بین کتاب‌های در امانت";
            this.chOnlyNotReterned.UseVisualStyleBackColor = true;
            this.chOnlyNotReterned.CheckedChanged += new System.EventHandler(this.chOnlyNotReterned_CheckedChanged);
            // 
            // dtBorrows
            // 
            this.dtBorrows.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBorrows.Location = new System.Drawing.Point(18, 222);
            this.dtBorrows.Name = "dtBorrows";
            this.dtBorrows.ReadOnly = true;
            this.dtBorrows.RowHeadersWidth = 51;
            this.dtBorrows.RowTemplate.Height = 24;
            this.dtBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtBorrows.Size = new System.Drawing.Size(1413, 345);
            this.dtBorrows.TabIndex = 5;
            this.dtBorrows.SelectionChanged += new System.EventHandler(this.dtBorrows_SelectionChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFirstName.Location = new System.Drawing.Point(655, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(254, 48);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(56, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 48);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMembers.Location = new System.Drawing.Point(373, 54);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(54, 39);
            this.btnSearchMembers.TabIndex = 18;
            this.btnSearchMembers.Text = "...";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(956, 47);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(54, 41);
            this.btnSearchBook.TabIndex = 17;
            this.btnSearchBook.Text = "...";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(373, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(354, 123);
            this.txtDescription.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(756, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "توضیحات";
            // 
            // txtBorrower
            // 
            this.txtBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBorrower.Location = new System.Drawing.Point(433, 55);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.ReadOnly = true;
            this.txtBorrower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBorrower.Size = new System.Drawing.Size(294, 36);
            this.txtBorrower.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(743, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "امانت گیرنده";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(373, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(354, 56);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(1016, 48);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookTitle.Size = new System.Drawing.Size(254, 36);
            this.txtBookTitle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1293, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "عنوان کتاب";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddBorrowerById);
            this.groupBox2.Controls.Add(this.txtBorrowerId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnAddBookById);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBookId);
            this.groupBox2.Controls.Add(this.btnDeleteBook);
            this.groupBox2.Controls.Add(this.lstBookNames);
            this.groupBox2.Controls.Add(this.txtBookTitle);
            this.groupBox2.Controls.Add(this.btnSearchMembers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearchBook);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBorrower);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(13, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1450, 396);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کتاب جدید";
            // 
            // btnAddBorrowerById
            // 
            this.btnAddBorrowerById.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrowerById.Location = new System.Drawing.Point(373, 109);
            this.btnAddBorrowerById.Name = "btnAddBorrowerById";
            this.btnAddBorrowerById.Size = new System.Drawing.Size(54, 46);
            this.btnAddBorrowerById.TabIndex = 26;
            this.btnAddBorrowerById.Text = "+";
            this.btnAddBorrowerById.UseVisualStyleBackColor = true;
            this.btnAddBorrowerById.Click += new System.EventHandler(this.btnAddBorrowerById_Click);
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Font = new System.Drawing.Font("B Nazanin", 15.2F);
            this.txtBorrowerId.Location = new System.Drawing.Point(433, 109);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBorrowerId.Size = new System.Drawing.Size(294, 45);
            this.txtBorrowerId.TabIndex = 25;
            this.txtBorrowerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBorrowerId_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(755, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 37);
            this.label10.TabIndex = 24;
            this.label10.Text = "کد عضویت";
            // 
            // btnAddBookById
            // 
            this.btnAddBookById.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookById.Location = new System.Drawing.Point(956, 93);
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
            this.label9.Location = new System.Drawing.Point(1318, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 41);
            this.label9.TabIndex = 22;
            this.label9.Text = "کد کتاب";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("B Nazanin", 15.2F);
            this.txtBookId.Location = new System.Drawing.Point(1016, 93);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookId.Size = new System.Drawing.Size(254, 45);
            this.txtBookId.TabIndex = 21;
            this.txtBookId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookId_KeyDown);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(956, 338);
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
            this.lstBookNames.Location = new System.Drawing.Point(956, 152);
            this.lstBookNames.Name = "lstBookNames";
            this.lstBookNames.Size = new System.Drawing.Size(449, 178);
            this.lstBookNames.TabIndex = 19;
            this.lstBookNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBookNames_KeyDown);
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBorrow";
            this.Text = "امانت و تحویل";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.Shown += new System.EventHandler(this.frmBorrow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrows)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dtBorrows;
        private System.Windows.Forms.CheckBox chOnlyNotReterned;
        private System.Windows.Forms.Button btnReterned;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBorrower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBookNames;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox txtRegisterationId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddBookById;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddBorrowerById;
        private System.Windows.Forms.TextBox txtBorrowerId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchByBookId;
        private System.Windows.Forms.Label lblReternedStatus;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnDeleteAllText;
    }
}