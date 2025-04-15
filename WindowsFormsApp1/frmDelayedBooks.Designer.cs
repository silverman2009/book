namespace WindowsFormsApp1
{
    partial class frmDelayedBooks
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
            this.btnPrint = new System.Windows.Forms.Button();
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
            this.txtRegisterationId = new System.Windows.Forms.TextBox();
            this.btnReterned = new System.Windows.Forms.Button();
            this.dtBorrows = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPrint);
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
            this.groupBox1.Controls.Add(this.txtRegisterationId);
            this.groupBox1.Controls.Add(this.btnReterned);
            this.groupBox1.Controls.Add(this.dtBorrows);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1450, 620);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "امانت‌ها";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Location = new System.Drawing.Point(50, 518);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 53);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblReternedStatus
            // 
            this.lblReternedStatus.AutoSize = true;
            this.lblReternedStatus.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReternedStatus.ForeColor = System.Drawing.Color.Green;
            this.lblReternedStatus.Location = new System.Drawing.Point(1160, 518);
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
            this.label11.Location = new System.Drawing.Point(1327, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "کد کتاب";
            // 
            // txtSearchByBookId
            // 
            this.txtSearchByBookId.Enabled = false;
            this.txtSearchByBookId.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchByBookId.Location = new System.Drawing.Point(1308, 61);
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
            this.label8.Location = new System.Drawing.Point(1104, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "عنوان کتاب";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBookName.Location = new System.Drawing.Point(1048, 61);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookName.Size = new System.Drawing.Size(254, 48);
            this.txtBookName.TabIndex = 20;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(221, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "شماره تلفن";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhone.Location = new System.Drawing.Point(135, 63);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(254, 48);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(464, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLastName.Location = new System.Drawing.Point(395, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(254, 48);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(756, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(927, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "کد عضویت";
            // 
            // txtRegisterationId
            // 
            this.txtRegisterationId.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRegisterationId.Location = new System.Drawing.Point(915, 61);
            this.txtRegisterationId.Name = "txtRegisterationId";
            this.txtRegisterationId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegisterationId.Size = new System.Drawing.Size(127, 48);
            this.txtRegisterationId.TabIndex = 8;
            this.txtRegisterationId.TextChanged += new System.EventHandler(this.txtRegisterationId_TextChanged);
            // 
            // btnReterned
            // 
            this.btnReterned.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReterned.Location = new System.Drawing.Point(1258, 515);
            this.btnReterned.Name = "btnReterned";
            this.btnReterned.Size = new System.Drawing.Size(169, 53);
            this.btnReterned.TabIndex = 7;
            this.btnReterned.Text = "برگشت";
            this.btnReterned.UseVisualStyleBackColor = true;
            this.btnReterned.Visible = false;
            this.btnReterned.Click += new System.EventHandler(this.btnReterned_Click);
            // 
            // dtBorrows
            // 
            this.dtBorrows.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBorrows.Location = new System.Drawing.Point(18, 117);
            this.dtBorrows.Name = "dtBorrows";
            this.dtBorrows.ReadOnly = true;
            this.dtBorrows.RowHeadersWidth = 51;
            this.dtBorrows.RowTemplate.Height = 24;
            this.dtBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtBorrows.Size = new System.Drawing.Size(1413, 386);
            this.dtBorrows.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFirstName.Location = new System.Drawing.Point(655, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(254, 48);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // frmDelayedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 636);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDelayedBooks";
            this.Text = "frmDelayedBooks";
            this.Load += new System.EventHandler(this.frmDelayedBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorrows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReternedStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchByBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegisterationId;
        private System.Windows.Forms.Button btnReterned;
        private System.Windows.Forms.DataGridView dtBorrows;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnPrint;
    }
}