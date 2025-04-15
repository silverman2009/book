namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDelayedBooks = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAddKanon = new System.Windows.Forms.Button();
            this.btnKannonBookBarrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewBook.Location = new System.Drawing.Point(274, 102);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(234, 68);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "مدیریت کتاب‌ها";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBorrow.Location = new System.Drawing.Point(274, 34);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(234, 62);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "امانت / تحویل";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMembers.Location = new System.Drawing.Point(274, 176);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(234, 68);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "اعضا";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDelayedBooks
            // 
            this.btnDelayedBooks.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelayedBooks.Location = new System.Drawing.Point(274, 324);
            this.btnDelayedBooks.Name = "btnDelayedBooks";
            this.btnDelayedBooks.Size = new System.Drawing.Size(234, 68);
            this.btnDelayedBooks.TabIndex = 4;
            this.btnDelayedBooks.Text = "تاخیر کرده‌ها";
            this.btnDelayedBooks.UseVisualStyleBackColor = true;
            this.btnDelayedBooks.Click += new System.EventHandler(this.btnDelayedBooks_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStatistics.Location = new System.Drawing.Point(274, 398);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(234, 68);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "امار";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAddKanon
            // 
            this.btnAddKanon.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddKanon.Location = new System.Drawing.Point(274, 250);
            this.btnAddKanon.Name = "btnAddKanon";
            this.btnAddKanon.Size = new System.Drawing.Size(234, 68);
            this.btnAddKanon.TabIndex = 6;
            this.btnAddKanon.Text = "مدیریت کانون‌ها";
            this.btnAddKanon.UseVisualStyleBackColor = true;
            this.btnAddKanon.Click += new System.EventHandler(this.btnAddKanon_Click);
            // 
            // btnKannonBookBarrow
            // 
            this.btnKannonBookBarrow.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnKannonBookBarrow.Location = new System.Drawing.Point(554, 362);
            this.btnKannonBookBarrow.Name = "btnKannonBookBarrow";
            this.btnKannonBookBarrow.Size = new System.Drawing.Size(234, 68);
            this.btnKannonBookBarrow.TabIndex = 7;
            this.btnKannonBookBarrow.Text = "امانت / تحویل کانون‌ها";
            this.btnKannonBookBarrow.UseVisualStyleBackColor = true;
            this.btnKannonBookBarrow.Visible = false;
            this.btnKannonBookBarrow.Click += new System.EventHandler(this.btnKannonBookBarrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnKannonBookBarrow);
            this.Controls.Add(this.btnAddKanon);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnDelayedBooks);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAddNewBook);
            this.Name = "Form1";
            this.Text = "انجمن گسترش فرهنگ کتابخوانی";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnDelayedBooks;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnAddKanon;
        private System.Windows.Forms.Button btnKannonBookBarrow;
    }
}

