namespace WindowsFormsApp1
{
    partial class frmEditBook
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNotDonated = new System.Windows.Forms.RadioButton();
            this.rdDonated = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublishedYear = new System.Windows.Forms.TextBox();
            this.lblSavedStatus = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdNotDonated);
            this.groupBox2.Controls.Add(this.rdDonated);
            this.groupBox2.Controls.Add(this.label4);
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
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPublishedYear);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1308, 363);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کتاب جدید";
            // 
            // rdNotDonated
            // 
            this.rdNotDonated.AutoSize = true;
            this.rdNotDonated.Location = new System.Drawing.Point(531, 185);
            this.rdNotDonated.Name = "rdNotDonated";
            this.rdNotDonated.Size = new System.Drawing.Size(58, 33);
            this.rdNotDonated.TabIndex = 19;
            this.rdNotDonated.TabStop = true;
            this.rdNotDonated.Text = "خیر";
            this.rdNotDonated.UseVisualStyleBackColor = true;
            // 
            // rdDonated
            // 
            this.rdDonated.AutoSize = true;
            this.rdDonated.Location = new System.Drawing.Point(428, 185);
            this.rdDonated.Name = "rdDonated";
            this.rdDonated.Size = new System.Drawing.Size(50, 33);
            this.rdDonated.TabIndex = 18;
            this.rdDonated.TabStop = true;
            this.rdDonated.Text = "بله";
            this.rdDonated.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(628, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "آیا کتاب اهدا شده است؟";
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
            this.txtISBN.TabIndex = 5;
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
            this.txtTags.TabIndex = 6;
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
            this.txtPublisher.TabIndex = 3;
            // 
            // txtWriter
            // 
            this.txtWriter.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtWriter.Location = new System.Drawing.Point(489, 28);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(274, 48);
            this.txtWriter.TabIndex = 2;
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
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(888, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(274, 48);
            this.txtTitle.TabIndex = 1;
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1186, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "توضیحات";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(888, 224);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(274, 59);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDescription.Location = new System.Drawing.Point(888, 138);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 80);
            this.txtDescription.TabIndex = 7;
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
            // txtPublishedYear
            // 
            this.txtPublishedYear.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPublishedYear.Location = new System.Drawing.Point(888, 84);
            this.txtPublishedYear.Name = "txtPublishedYear";
            this.txtPublishedYear.Size = new System.Drawing.Size(274, 48);
            this.txtPublishedYear.TabIndex = 4;
            // 
            // lblSavedStatus
            // 
            this.lblSavedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSavedStatus.AutoSize = true;
            this.lblSavedStatus.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSavedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSavedStatus.Location = new System.Drawing.Point(12, 423);
            this.lblSavedStatus.Name = "lblSavedStatus";
            this.lblSavedStatus.Size = new System.Drawing.Size(114, 41);
            this.lblSavedStatus.TabIndex = 14;
            this.lblSavedStatus.Text = "ویرایش شد";
            this.lblSavedStatus.Visible = false;
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 473);
            this.Controls.Add(this.lblSavedStatus);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditBook";
            this.Text = "ویرایش کتاب";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublishedYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdNotDonated;
        private System.Windows.Forms.RadioButton rdDonated;
        private System.Windows.Forms.Label lblSavedStatus;
    }
}