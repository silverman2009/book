namespace WindowsFormsApp1
{
    partial class frmEditKanon
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtKanonAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKanonAdminPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkanonAdminName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditKanon = new System.Windows.Forms.Button();
            this.txtKanonName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEditedStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblEditedStatus);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKanonAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKanonAdminPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtkanonAdminName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEditKanon);
            this.groupBox1.Controls.Add(this.txtKanonName);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.groupBox1.Location = new System.Drawing.Point(36, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1201, 275);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کانون جدید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label4.Location = new System.Drawing.Point(600, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "آدرس کانون";
            // 
            // txtKanonAddress
            // 
            this.txtKanonAddress.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonAddress.Location = new System.Drawing.Point(30, 108);
            this.txtKanonAddress.Name = "txtKanonAddress";
            this.txtKanonAddress.Size = new System.Drawing.Size(491, 45);
            this.txtKanonAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label3.Location = new System.Drawing.Point(540, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تماس مسئول";
            // 
            // txtKanonAdminPhone
            // 
            this.txtKanonAdminPhone.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonAdminPhone.Location = new System.Drawing.Point(30, 44);
            this.txtKanonAdminPhone.Name = "txtKanonAdminPhone";
            this.txtKanonAdminPhone.Size = new System.Drawing.Size(491, 45);
            this.txtKanonAdminPhone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label2.Location = new System.Drawing.Point(1088, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام مسئول";
            // 
            // txtkanonAdminName
            // 
            this.txtkanonAdminName.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtkanonAdminName.Location = new System.Drawing.Point(737, 112);
            this.txtkanonAdminName.Name = "txtkanonAdminName";
            this.txtkanonAdminName.Size = new System.Drawing.Size(321, 45);
            this.txtkanonAdminName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label1.Location = new System.Drawing.Point(1098, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کانون";
            // 
            // btnEditKanon
            // 
            this.btnEditKanon.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnEditKanon.Location = new System.Drawing.Point(286, 197);
            this.btnEditKanon.Name = "btnEditKanon";
            this.btnEditKanon.Size = new System.Drawing.Size(235, 48);
            this.btnEditKanon.TabIndex = 0;
            this.btnEditKanon.Text = "ویرایش";
            this.btnEditKanon.UseVisualStyleBackColor = true;
            this.btnEditKanon.Click += new System.EventHandler(this.btnEditKanon_Click);
            // 
            // txtKanonName
            // 
            this.txtKanonName.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonName.Location = new System.Drawing.Point(737, 44);
            this.txtKanonName.Name = "txtKanonName";
            this.txtKanonName.Size = new System.Drawing.Size(321, 45);
            this.txtKanonName.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnExit.Location = new System.Drawing.Point(30, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEditedStatus
            // 
            this.lblEditedStatus.AutoSize = true;
            this.lblEditedStatus.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEditedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEditedStatus.Location = new System.Drawing.Point(527, 205);
            this.lblEditedStatus.Name = "lblEditedStatus";
            this.lblEditedStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditedStatus.Size = new System.Drawing.Size(95, 34);
            this.lblEditedStatus.TabIndex = 14;
            this.lblEditedStatus.Text = "ویرایش شد";
            this.lblEditedStatus.Visible = false;
            // 
            // frmEditKanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 572);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditKanon";
            this.Text = "ویرایش کانون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKanonAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKanonAdminPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkanonAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditKanon;
        private System.Windows.Forms.TextBox txtKanonName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEditedStatus;
    }
}