namespace BookshopManagementSystem
{
    partial class FormUser
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
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnlUserInfoDB = new System.Windows.Forms.Panel();
            this.dgvUserInfoDB = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearchUserId = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUserInfoDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfoDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.Location = new System.Drawing.Point(169, -4);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(141, 21);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "User Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 153);
            this.panel1.TabIndex = 17;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.cmbRole.Location = new System.Drawing.Point(109, 129);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 26;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(109, 9);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(175, 20);
            this.txtUserId.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Role             :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Password   : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Name          : ";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(13, 11);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(78, 16);
            this.lblUserId.TabIndex = 21;
            this.lblUserId.Text = "User ID       : ";
            // 
            // pnlUserInfoDB
            // 
            this.pnlUserInfoDB.Controls.Add(this.dgvUserInfoDB);
            this.pnlUserInfoDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserInfoDB.Location = new System.Drawing.Point(0, 238);
            this.pnlUserInfoDB.Name = "pnlUserInfoDB";
            this.pnlUserInfoDB.Size = new System.Drawing.Size(457, 203);
            this.pnlUserInfoDB.TabIndex = 18;
            // 
            // dgvUserInfoDB
            // 
            this.dgvUserInfoDB.AllowUserToAddRows = false;
            this.dgvUserInfoDB.AllowUserToDeleteRows = false;
            this.dgvUserInfoDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserInfoDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfoDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.Password,
            this.Role});
            this.dgvUserInfoDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserInfoDB.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUserInfoDB.Location = new System.Drawing.Point(0, 0);
            this.dgvUserInfoDB.Name = "dgvUserInfoDB";
            this.dgvUserInfoDB.ReadOnly = true;
            this.dgvUserInfoDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfoDB.Size = new System.Drawing.Size(457, 203);
            this.dgvUserInfoDB.TabIndex = 0;
            this.dgvUserInfoDB.DoubleClick += new System.EventHandler(this.dgvUserInfoDB_DoubleClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 110;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(378, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 29);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "HOME";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(378, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 29);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(378, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(378, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 29);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(0, 212);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(135, 20);
            this.txtSearchById.TabIndex = 30;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(173, 212);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(123, 20);
            this.txtSearchByName.TabIndex = 31;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Location = new System.Drawing.Point(12, 196);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(66, 13);
            this.lblSearchById.TabIndex = 32;
            this.lblSearchById.Text = "Search by id";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(170, 196);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(84, 13);
            this.lblSearchByName.TabIndex = 33;
            this.lblSearchByName.Text = "Search by name";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(378, 207);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(77, 25);
            this.btnShowAll.TabIndex = 34;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtSearchUserId
            // 
            this.txtSearchUserId.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserId.Location = new System.Drawing.Point(81, 183);
            this.txtSearchUserId.Name = "txtSearchUserId";
            this.txtSearchUserId.Size = new System.Drawing.Size(54, 26);
            this.txtSearchUserId.TabIndex = 35;
            this.txtSearchUserId.Text = "Search";
            this.txtSearchUserId.UseVisualStyleBackColor = true;
            this.txtSearchUserId.Click += new System.EventHandler(this.txtSearchUserId_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Red;
            this.lblComment.Location = new System.Drawing.Point(285, 189);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(172, 13);
            this.lblComment.TabIndex = 41;
            this.lblComment.Text = "Double click to select a User";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(457, 441);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtSearchUserId);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.lblSearchById);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlUserInfoDB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUserInfoDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfoDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Panel pnlUserInfoDB;
        private System.Windows.Forms.DataGridView dgvUserInfoDB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button txtSearchUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Label lblComment;
    }
}