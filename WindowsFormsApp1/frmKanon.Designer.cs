namespace WindowsFormsApp1
{
    partial class frmKanon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddKanon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKanonName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKanonAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKanonAdminPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkanonAdminName = new System.Windows.Forms.TextBox();
            this.dtKanons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanonAdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBarrowBookToKanon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchKanonId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchKanonAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchKanonName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtKanons)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddKanon
            // 
            this.btnAddKanon.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnAddKanon.Location = new System.Drawing.Point(198, 193);
            this.btnAddKanon.Name = "btnAddKanon";
            this.btnAddKanon.Size = new System.Drawing.Size(235, 48);
            this.btnAddKanon.TabIndex = 0;
            this.btnAddKanon.Text = "ذخیره";
            this.btnAddKanon.UseVisualStyleBackColor = true;
            this.btnAddKanon.Click += new System.EventHandler(this.btnAddKanon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label1.Location = new System.Drawing.Point(1276, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کانون";
            // 
            // txtKanonName
            // 
            this.txtKanonName.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonName.Location = new System.Drawing.Point(894, 44);
            this.txtKanonName.Name = "txtKanonName";
            this.txtKanonName.Size = new System.Drawing.Size(321, 45);
            this.txtKanonName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKanonAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKanonAdminPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtkanonAdminName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddKanon);
            this.groupBox1.Controls.Add(this.txtKanonName);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.groupBox1.Location = new System.Drawing.Point(26, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1375, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کانون جدید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label4.Location = new System.Drawing.Point(757, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "آدرس کانون";
            // 
            // txtKanonAddress
            // 
            this.txtKanonAddress.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonAddress.Location = new System.Drawing.Point(187, 108);
            this.txtKanonAddress.Name = "txtKanonAddress";
            this.txtKanonAddress.Size = new System.Drawing.Size(491, 45);
            this.txtKanonAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label3.Location = new System.Drawing.Point(697, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تماس مسئول";
            // 
            // txtKanonAdminPhone
            // 
            this.txtKanonAdminPhone.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtKanonAdminPhone.Location = new System.Drawing.Point(187, 44);
            this.txtKanonAdminPhone.Name = "txtKanonAdminPhone";
            this.txtKanonAdminPhone.Size = new System.Drawing.Size(491, 45);
            this.txtKanonAdminPhone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label2.Location = new System.Drawing.Point(1266, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام مسئول";
            // 
            // txtkanonAdminName
            // 
            this.txtkanonAdminName.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtkanonAdminName.Location = new System.Drawing.Point(894, 112);
            this.txtkanonAdminName.Name = "txtkanonAdminName";
            this.txtkanonAdminName.Size = new System.Drawing.Size(321, 45);
            this.txtkanonAdminName.TabIndex = 4;
            // 
            // dtKanons
            // 
            this.dtKanons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKanons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KanonName,
            this.KanonAdminName,
            this.AdminPhone,
            this.KanonAddress});
            this.dtKanons.Location = new System.Drawing.Point(21, 121);
            this.dtKanons.Name = "dtKanons";
            this.dtKanons.ReadOnly = true;
            this.dtKanons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtKanons.RowHeadersWidth = 51;
            this.dtKanons.RowTemplate.Height = 24;
            this.dtKanons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtKanons.Size = new System.Drawing.Size(1348, 305);
            this.dtKanons.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "کد";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // KanonName
            // 
            this.KanonName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.KanonName.DefaultCellStyle = dataGridViewCellStyle2;
            this.KanonName.HeaderText = "نام کانون";
            this.KanonName.MinimumWidth = 6;
            this.KanonName.Name = "KanonName";
            this.KanonName.ReadOnly = true;
            this.KanonName.Width = 145;
            // 
            // KanonAdminName
            // 
            this.KanonAdminName.DataPropertyName = "AdminName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.KanonAdminName.DefaultCellStyle = dataGridViewCellStyle3;
            this.KanonAdminName.HeaderText = "نام مسئول کانون";
            this.KanonAdminName.MinimumWidth = 6;
            this.KanonAdminName.Name = "KanonAdminName";
            this.KanonAdminName.ReadOnly = true;
            this.KanonAdminName.Width = 155;
            // 
            // AdminPhone
            // 
            this.AdminPhone.DataPropertyName = "AdminPhone";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.AdminPhone.DefaultCellStyle = dataGridViewCellStyle4;
            this.AdminPhone.HeaderText = "شماره تلفن مسئول کانون";
            this.AdminPhone.MinimumWidth = 6;
            this.AdminPhone.Name = "AdminPhone";
            this.AdminPhone.ReadOnly = true;
            this.AdminPhone.Width = 165;
            // 
            // KanonAddress
            // 
            this.KanonAddress.DataPropertyName = "Address";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 16.2F);
            this.KanonAddress.DefaultCellStyle = dataGridViewCellStyle5;
            this.KanonAddress.HeaderText = "آدرس کانون";
            this.KanonAddress.MinimumWidth = 6;
            this.KanonAddress.Name = "KanonAddress";
            this.KanonAddress.ReadOnly = true;
            this.KanonAddress.Width = 390;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBarrowBookToKanon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearchKanonId);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSearchKanonAdmin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSearchKanonName);
            this.groupBox2.Controls.Add(this.dtKanons);
            this.groupBox2.Location = new System.Drawing.Point(26, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1375, 517);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // btnBarrowBookToKanon
            // 
            this.btnBarrowBookToKanon.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnBarrowBookToKanon.Location = new System.Drawing.Point(555, 432);
            this.btnBarrowBookToKanon.Name = "btnBarrowBookToKanon";
            this.btnBarrowBookToKanon.Size = new System.Drawing.Size(235, 48);
            this.btnBarrowBookToKanon.TabIndex = 13;
            this.btnBarrowBookToKanon.Text = "امانت / تحویل کتاب";
            this.btnBarrowBookToKanon.UseVisualStyleBackColor = true;
            this.btnBarrowBookToKanon.Click += new System.EventHandler(this.btnBarrowBookToKanon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label7.Location = new System.Drawing.Point(1245, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "کد کانون";
            // 
            // txtSearchKanonId
            // 
            this.txtSearchKanonId.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtSearchKanonId.Location = new System.Drawing.Point(1218, 54);
            this.txtSearchKanonId.Name = "txtSearchKanonId";
            this.txtSearchKanonId.Size = new System.Drawing.Size(138, 45);
            this.txtSearchKanonId.TabIndex = 11;
            this.txtSearchKanonId.TextChanged += new System.EventHandler(this.txtSearchKanonId_TextChanged);
            this.txtSearchKanonId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKanonId_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnDelete.Location = new System.Drawing.Point(47, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 48);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.btnEdit.Location = new System.Drawing.Point(297, 432);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(235, 48);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label6.Location = new System.Drawing.Point(829, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "نام مسئول";
            // 
            // txtSearchKanonAdmin
            // 
            this.txtSearchKanonAdmin.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtSearchKanonAdmin.Location = new System.Drawing.Point(758, 54);
            this.txtSearchKanonAdmin.Name = "txtSearchKanonAdmin";
            this.txtSearchKanonAdmin.Size = new System.Drawing.Size(213, 45);
            this.txtSearchKanonAdmin.TabIndex = 8;
            this.txtSearchKanonAdmin.TextChanged += new System.EventHandler(this.txtSearchKanonAdmin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.label5.Location = new System.Drawing.Point(1051, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام کانون";
            // 
            // txtSearchKanonName
            // 
            this.txtSearchKanonName.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.txtSearchKanonName.Location = new System.Drawing.Point(977, 54);
            this.txtSearchKanonName.Name = "txtSearchKanonName";
            this.txtSearchKanonName.Size = new System.Drawing.Size(235, 45);
            this.txtSearchKanonName.TabIndex = 5;
            this.txtSearchKanonName.TextChanged += new System.EventHandler(this.txtSearchKanonName_TextChanged);
            // 
            // frmKanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 812);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKanon";
            this.Text = "کانون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtKanons)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddKanon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKanonName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkanonAdminName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKanonAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKanonAdminPhone;
        private System.Windows.Forms.DataGridView dtKanons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchKanonName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchKanonAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchKanonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanonAdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanonAddress;
        private System.Windows.Forms.Button btnBarrowBookToKanon;
    }
}