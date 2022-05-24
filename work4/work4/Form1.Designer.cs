namespace work4
{
    partial class frmEmployee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbempName = new System.Windows.Forms.Label();
            this.lbempSurname = new System.Windows.Forms.Label();
            this.lbempPhone = new System.Windows.Forms.Label();
            this.lbempEmail = new System.Windows.Forms.Label();
            this.lbempAddress = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.txtempSurname = new System.Windows.Forms.TextBox();
            this.txtempPhone = new System.Windows.Forms.TextBox();
            this.txtempEmail = new System.Windows.Forms.TextBox();
            this.txtempAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btEditData = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtempAddress);
            this.groupBox1.Controls.Add(this.txtempEmail);
            this.groupBox1.Controls.Add(this.txtempPhone);
            this.groupBox1.Controls.Add(this.txtempSurname);
            this.groupBox1.Controls.Add(this.txtempName);
            this.groupBox1.Controls.Add(this.lbNote);
            this.groupBox1.Controls.Add(this.lbempAddress);
            this.groupBox1.Controls.Add(this.lbempEmail);
            this.groupBox1.Controls.Add(this.lbempPhone);
            this.groupBox1.Controls.Add(this.lbempSurname);
            this.groupBox1.Controls.Add(this.lbempName);
            this.groupBox1.Location = new System.Drawing.Point(94, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ຂໍ້ມູນພະນັກງານ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbempName
            // 
            this.lbempName.AutoSize = true;
            this.lbempName.Location = new System.Drawing.Point(74, 36);
            this.lbempName.Name = "lbempName";
            this.lbempName.Size = new System.Drawing.Size(19, 21);
            this.lbempName.TabIndex = 0;
            this.lbempName.Text = "ຊື່";
            this.lbempName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbempSurname
            // 
            this.lbempSurname.AutoSize = true;
            this.lbempSurname.Location = new System.Drawing.Point(24, 83);
            this.lbempSurname.Name = "lbempSurname";
            this.lbempSurname.Size = new System.Drawing.Size(69, 21);
            this.lbempSurname.TabIndex = 1;
            this.lbempSurname.Text = "ນາມສະກຸນ";
            this.lbempSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbempPhone
            // 
            this.lbempPhone.AutoSize = true;
            this.lbempPhone.Location = new System.Drawing.Point(53, 130);
            this.lbempPhone.Name = "lbempPhone";
            this.lbempPhone.Size = new System.Drawing.Size(40, 21);
            this.lbempPhone.TabIndex = 2;
            this.lbempPhone.Text = "ເບີໂທ";
            this.lbempPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbempEmail
            // 
            this.lbempEmail.AutoSize = true;
            this.lbempEmail.Location = new System.Drawing.Point(51, 177);
            this.lbempEmail.Name = "lbempEmail";
            this.lbempEmail.Size = new System.Drawing.Size(42, 21);
            this.lbempEmail.TabIndex = 3;
            this.lbempEmail.Text = "ອີເມວ";
            this.lbempEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbempAddress
            // 
            this.lbempAddress.AutoSize = true;
            this.lbempAddress.Location = new System.Drawing.Point(64, 225);
            this.lbempAddress.Name = "lbempAddress";
            this.lbempAddress.Size = new System.Drawing.Size(29, 21);
            this.lbempAddress.TabIndex = 4;
            this.lbempAddress.Text = "ທີ່ຢູ";
            this.lbempAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(31, 285);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(62, 21);
            this.lbNote.TabIndex = 5;
            this.lbNote.Text = "ໝາຍເຫດ";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtempName
            // 
            this.txtempName.Location = new System.Drawing.Point(99, 33);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(168, 30);
            this.txtempName.TabIndex = 6;
            // 
            // txtempSurname
            // 
            this.txtempSurname.Location = new System.Drawing.Point(99, 80);
            this.txtempSurname.Name = "txtempSurname";
            this.txtempSurname.Size = new System.Drawing.Size(168, 30);
            this.txtempSurname.TabIndex = 7;
            // 
            // txtempPhone
            // 
            this.txtempPhone.Location = new System.Drawing.Point(99, 127);
            this.txtempPhone.Name = "txtempPhone";
            this.txtempPhone.Size = new System.Drawing.Size(168, 30);
            this.txtempPhone.TabIndex = 8;
            // 
            // txtempEmail
            // 
            this.txtempEmail.Location = new System.Drawing.Point(99, 174);
            this.txtempEmail.Name = "txtempEmail";
            this.txtempEmail.Size = new System.Drawing.Size(168, 30);
            this.txtempEmail.TabIndex = 9;
            // 
            // txtempAddress
            // 
            this.txtempAddress.Location = new System.Drawing.Point(99, 222);
            this.txtempAddress.Name = "txtempAddress";
            this.txtempAddress.Size = new System.Drawing.Size(168, 30);
            this.txtempAddress.TabIndex = 10;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(99, 282);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(168, 30);
            this.txtNote.TabIndex = 11;
            // 
            // btEditData
            // 
            this.btEditData.Location = new System.Drawing.Point(280, 388);
            this.btEditData.Name = "btEditData";
            this.btEditData.Size = new System.Drawing.Size(81, 33);
            this.btEditData.TabIndex = 2;
            this.btEditData.Text = "ແກ້ໄຂຂໍ້ມູນ";
            this.btEditData.UseVisualStyleBackColor = true;
            this.btEditData.Click += new System.EventHandler(this.btEditData_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(193, 388);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(81, 33);
            this.btnInsertData.TabIndex = 3;
            this.btnInsertData.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 425);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.btEditData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtempAddress;
        private System.Windows.Forms.TextBox txtempEmail;
        private System.Windows.Forms.TextBox txtempPhone;
        private System.Windows.Forms.TextBox txtempSurname;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbempAddress;
        private System.Windows.Forms.Label lbempEmail;
        private System.Windows.Forms.Label lbempPhone;
        private System.Windows.Forms.Label lbempSurname;
        private System.Windows.Forms.Label lbempName;
        private System.Windows.Forms.Button btEditData;
        private System.Windows.Forms.Button btnInsertData;
    }
}

