namespace LibraryManagementSystem
{
    partial class ManageUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tblUsers = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(500, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "SEARCH";
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.btnDisable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(500, 607);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(224, 52);
            this.btnDisable.TabIndex = 35;
            this.btnDisable.Text = "DISABLE";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(500, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 55);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(500, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 52);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "ROLE";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(136, 607);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(348, 22);
            this.tbEmail.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "EMAIL";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(136, 544);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(348, 22);
            this.tbUsername.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "LAST NAME";
            // 
            // tbLname
            // 
            this.tbLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLname.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLname.Location = new System.Drawing.Point(136, 514);
            this.tbLname.Name = "tbLname";
            this.tbLname.ReadOnly = true;
            this.tbLname.Size = new System.Drawing.Size(348, 22);
            this.tbLname.TabIndex = 24;
            // 
            // tbFname
            // 
            this.tbFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFname.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFname.Location = new System.Drawing.Point(136, 485);
            this.tbFname.Name = "tbFname";
            this.tbFname.ReadOnly = true;
            this.tbFname.Size = new System.Drawing.Size(348, 22);
            this.tbFname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "FIRST NAME";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(500, 60);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 23);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tblUsers
            // 
            this.tblUsers.AllowUserToAddRows = false;
            this.tblUsers.AllowUserToDeleteRows = false;
            this.tblUsers.AllowUserToResizeColumns = false;
            this.tblUsers.AllowUserToResizeRows = false;
            this.tblUsers.BackgroundColor = System.Drawing.Color.White;
            this.tblUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblUsers.ColumnHeadersHeight = 30;
            this.tblUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.fname,
            this.lname,
            this.username,
            this.email,
            this.user_role,
            this.password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblUsers.EnableHeadersVisualStyles = false;
            this.tblUsers.Location = new System.Drawing.Point(24, 100);
            this.tblUsers.MultiSelect = false;
            this.tblUsers.Name = "tblUsers";
            this.tblUsers.ReadOnly = true;
            this.tblUsers.RowHeadersVisible = false;
            this.tblUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tblUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblUsers.RowTemplate.Height = 25;
            this.tblUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblUsers.ShowCellErrors = false;
            this.tblUsers.ShowCellToolTips = false;
            this.tblUsers.ShowEditingIcon = false;
            this.tblUsers.ShowRowErrors = false;
            this.tblUsers.Size = new System.Drawing.Size(700, 365);
            this.tblUsers.TabIndex = 20;
            this.tblUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUsers_CellContentClick);
            this.tblUsers.SelectionChanged += new System.EventHandler(this.tblUsers_SelectionChanged);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "StudentID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.FillWeight = 120F;
            this.fname.HeaderText = "FIRST NAME";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fname.Width = 130;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.FillWeight = 120F;
            this.lname.HeaderText = "LAST NAME";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lname.Width = 130;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 120F;
            this.username.HeaderText = "USERNAME";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.username.Width = 130;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Width = 200;
            // 
            // user_role
            // 
            this.user_role.DataPropertyName = "user_role";
            this.user_role.HeaderText = "ROLE";
            this.user_role.Name = "user_role";
            this.user_role.ReadOnly = true;
            this.user_role.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.user_role.Width = 110;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "PASSWORD";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(136, 577);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(348, 22);
            this.tbPassword.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "PASSWORD";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Enabled = false;
            this.cbRole.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "ADMIN",
            "LIBRARIAN"});
            this.cbRole.Location = new System.Drawing.Point(136, 637);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(348, 22);
            this.cbRole.TabIndex = 40;
            // 
            // btnShow
            // 
            this.btnShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(461, 578);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(19, 19);
            this.btnShow.TabIndex = 41;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.CheckedChanged += new System.EventHandler(this.btnShow_CheckedChanged);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 694);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tblUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnDisable;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label6;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbUsername;
        private Label label5;
        private Label label2;
        private TextBox tbLname;
        private TextBox tbFname;
        private Label label1;
        private TextBox tbSearch;
        private DataGridView tblUsers;
        private TextBox tbPassword;
        private Label label4;
        private ComboBox cbRole;
        private CheckBox btnShow;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn user_role;
        private DataGridViewTextBoxColumn password;
    }
}