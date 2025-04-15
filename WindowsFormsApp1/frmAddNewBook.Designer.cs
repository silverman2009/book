namespace WindowsFormsApp1
{
    partial class frmAddNewBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.txtPublishedYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchByWriter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchByTag = new System.Windows.Forms.TextBox();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsdonated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1168, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان کتاب";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(888, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(274, 48);
            this.txtTitle.TabIndex = 6;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewBook.Location = new System.Drawing.Point(888, 224);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(274, 59);
            this.btnAddNewBook.TabIndex = 13;
            this.btnAddNewBook.Text = "افزودن";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // txtPublishedYear
            // 
            this.txtPublishedYear.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPublishedYear.Location = new System.Drawing.Point(888, 84);
            this.txtPublishedYear.Name = "txtPublishedYear";
            this.txtPublishedYear.Size = new System.Drawing.Size(274, 48);
            this.txtPublishedYear.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1186, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "سال چاپ";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDescription.Location = new System.Drawing.Point(888, 138);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 80);
            this.txtDescription.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1186, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "توضیحات";
            // 
            // dtBooks
            // 
            this.dtBooks.AllowUserToDeleteRows = false;
            this.dtBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clBookName,
            this.clWriter,
            this.clPublisher,
            this.clPublishedYear,
            this.clTags,
            this.clISBN,
            this.clIsdonated,
            this.BookStatus,
            this.Tags,
            this.Column5});
            this.dtBooks.Location = new System.Drawing.Point(21, 114);
            this.dtBooks.Name = "dtBooks";
            this.dtBooks.ReadOnly = true;
            this.dtBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtBooks.RowHeadersWidth = 51;
            this.dtBooks.RowTemplate.Height = 24;
            this.dtBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtBooks.Size = new System.Drawing.Size(1259, 435);
            this.dtBooks.TabIndex = 40;
            this.dtBooks.TabStop = false;
            this.dtBooks.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dtBooks_UserDeletingRow);
            this.dtBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtBooks_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.txtSearch.Location = new System.Drawing.Point(1066, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 48);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(1413, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "عنوان";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.btnSearch.Location = new System.Drawing.Point(486, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSearchByTag);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchByWriter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDeleteBook);
            this.groupBox1.Controls.Add(this.btnSelectBook);
            this.groupBox1.Controls.Add(this.dtBooks);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1308, 610);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست کتاب‌ها";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.label10.Location = new System.Drawing.Point(909, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 41);
            this.label10.TabIndex = 16;
            this.label10.Text = "نویسنده";
            // 
            // txtSearchByWriter
            // 
            this.txtSearchByWriter.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.txtSearchByWriter.Location = new System.Drawing.Point(855, 56);
            this.txtSearchByWriter.Name = "txtSearchByWriter";
            this.txtSearchByWriter.Size = new System.Drawing.Size(205, 48);
            this.txtSearchByWriter.TabIndex = 1;
            this.txtSearchByWriter.TextChanged += new System.EventHandler(this.txtSearchByWriter_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.label9.Location = new System.Drawing.Point(1131, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 41);
            this.label9.TabIndex = 14;
            this.label9.Text = "عنوان کتاب";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(909, 558);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 46);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteBook.Location = new System.Drawing.Point(1069, 558);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(154, 46);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "حذف";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectBook.Location = new System.Drawing.Point(36, 557);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(154, 46);
            this.btnSelectBook.TabIndex = 5;
            this.btnSelectBook.Text = "انتخاب";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Visible = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTags);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPublisher);
            this.groupBox2.Controls.Add(this.txtWriter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAddNewBook);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPublishedYear);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(25, 645);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1308, 363);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کتاب جدید";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(788, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 41);
            this.label8.TabIndex = 14;
            this.label8.Text = "شابک";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtISBN.Location = new System.Drawing.Point(489, 81);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(274, 48);
            this.txtISBN.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(399, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "تگ‌ها";
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTags.Location = new System.Drawing.Point(112, 84);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(274, 48);
            this.txtTags.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(399, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "ناشر";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPublisher.Location = new System.Drawing.Point(112, 26);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(274, 48);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtWriter
            // 
            this.txtWriter.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtWriter.Location = new System.Drawing.Point(489, 28);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(274, 48);
            this.txtWriter.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(769, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "نویسنده";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.label11.Location = new System.Drawing.Point(722, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 41);
            this.label11.TabIndex = 42;
            this.label11.Text = "تگ";
            // 
            // txtSearchByTag
            // 
            this.txtSearchByTag.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.txtSearchByTag.Location = new System.Drawing.Point(644, 55);
            this.txtSearchByTag.Name = "txtSearchByTag";
            this.txtSearchByTag.Size = new System.Drawing.Size(205, 48);
            this.txtSearchByTag.TabIndex = 41;
            this.txtSearchByTag.TextChanged += new System.EventHandler(this.txtSearchByTag_TextChanged);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            dataGridViewCellStyle78.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clId.DefaultCellStyle = dataGridViewCellStyle78;
            this.clId.FillWeight = 70F;
            this.clId.HeaderText = "کد";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 70;
            // 
            // clBookName
            // 
            this.clBookName.DataPropertyName = "Name";
            dataGridViewCellStyle79.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clBookName.DefaultCellStyle = dataGridViewCellStyle79;
            this.clBookName.FillWeight = 120F;
            this.clBookName.HeaderText = "عنوان کتاب";
            this.clBookName.MaxInputLength = 320;
            this.clBookName.MinimumWidth = 6;
            this.clBookName.Name = "clBookName";
            this.clBookName.ReadOnly = true;
            this.clBookName.Width = 265;
            // 
            // clWriter
            // 
            this.clWriter.DataPropertyName = "Writer";
            dataGridViewCellStyle80.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clWriter.DefaultCellStyle = dataGridViewCellStyle80;
            this.clWriter.HeaderText = "نویسنده";
            this.clWriter.MinimumWidth = 6;
            this.clWriter.Name = "clWriter";
            this.clWriter.ReadOnly = true;
            this.clWriter.Width = 125;
            // 
            // clPublisher
            // 
            this.clPublisher.DataPropertyName = "Publisher";
            dataGridViewCellStyle81.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clPublisher.DefaultCellStyle = dataGridViewCellStyle81;
            this.clPublisher.HeaderText = "انتشارات";
            this.clPublisher.MinimumWidth = 6;
            this.clPublisher.Name = "clPublisher";
            this.clPublisher.ReadOnly = true;
            this.clPublisher.Width = 125;
            // 
            // clPublishedYear
            // 
            this.clPublishedYear.DataPropertyName = "PublishedYear";
            dataGridViewCellStyle82.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clPublishedYear.DefaultCellStyle = dataGridViewCellStyle82;
            this.clPublishedYear.HeaderText = "PublishedYear";
            this.clPublishedYear.MinimumWidth = 6;
            this.clPublishedYear.Name = "clPublishedYear";
            this.clPublishedYear.ReadOnly = true;
            this.clPublishedYear.Visible = false;
            this.clPublishedYear.Width = 125;
            // 
            // clTags
            // 
            this.clTags.DataPropertyName = "Tags";
            dataGridViewCellStyle83.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clTags.DefaultCellStyle = dataGridViewCellStyle83;
            this.clTags.HeaderText = "Tags";
            this.clTags.MinimumWidth = 6;
            this.clTags.Name = "clTags";
            this.clTags.ReadOnly = true;
            this.clTags.Visible = false;
            this.clTags.Width = 125;
            // 
            // clISBN
            // 
            this.clISBN.DataPropertyName = "ISBN";
            dataGridViewCellStyle84.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clISBN.DefaultCellStyle = dataGridViewCellStyle84;
            this.clISBN.HeaderText = "ISBN";
            this.clISBN.MinimumWidth = 6;
            this.clISBN.Name = "clISBN";
            this.clISBN.ReadOnly = true;
            this.clISBN.Visible = false;
            this.clISBN.Width = 125;
            // 
            // clIsdonated
            // 
            this.clIsdonated.DataPropertyName = "Isdonated";
            dataGridViewCellStyle85.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.clIsdonated.DefaultCellStyle = dataGridViewCellStyle85;
            this.clIsdonated.HeaderText = "Status";
            this.clIsdonated.MinimumWidth = 6;
            this.clIsdonated.Name = "clIsdonated";
            this.clIsdonated.ReadOnly = true;
            this.clIsdonated.Visible = false;
            this.clIsdonated.Width = 125;
            // 
            // BookStatus
            // 
            this.BookStatus.DataPropertyName = "Status";
            dataGridViewCellStyle86.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.BookStatus.DefaultCellStyle = dataGridViewCellStyle86;
            this.BookStatus.FillWeight = 85F;
            this.BookStatus.HeaderText = "وضعیت";
            this.BookStatus.MinimumWidth = 6;
            this.BookStatus.Name = "BookStatus";
            this.BookStatus.ReadOnly = true;
            this.BookStatus.Width = 80;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            dataGridViewCellStyle87.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.Tags.DefaultCellStyle = dataGridViewCellStyle87;
            this.Tags.HeaderText = "تگ";
            this.Tags.MinimumWidth = 6;
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.Width = 160;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            dataGridViewCellStyle88.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle88;
            this.Column5.FillWeight = 91.57755F;
            this.Column5.HeaderText = "توضیحات";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 245;
            // 
            // frmAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 1003);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "frmAddNewBook";
            this.Text = "مدیریت کتاب";
            this.Load += new System.EventHandler(this.frmAddNewBook_Load);
            this.Shown += new System.EventHandler(this.frmAddNewBook_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.TextBox txtPublishedYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchByWriter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchByTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn clISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsdonated;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}