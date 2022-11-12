namespace LibraryManagementSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.CheckBox();
            this.btnIssued = new System.Windows.Forms.CheckBox();
            this.btnBook = new System.Windows.Forms.CheckBox();
            this.btnStudents = new System.Windows.Forms.CheckBox();
            this.btnUsers = new System.Windows.Forms.CheckBox();
            this.btnDashboard = new System.Windows.Forms.CheckBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.btnReturn);
            this.sidebar.Controls.Add(this.btnIssued);
            this.sidebar.Controls.Add(this.btnBook);
            this.sidebar.Controls.Add(this.btnStudents);
            this.sidebar.Controls.Add(this.btnUsers);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebar.Location = new System.Drawing.Point(-1, 37);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(276, 734);
            this.sidebar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 521);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(276, 56);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "LOGOUT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnReturn.AutoCheck = false;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReturn.Location = new System.Drawing.Point(0, 466);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(276, 56);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "RETURN BOOKS";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // btnIssued
            // 
            this.btnIssued.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIssued.AutoCheck = false;
            this.btnIssued.FlatAppearance.BorderSize = 0;
            this.btnIssued.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnIssued.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIssued.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssued.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssued.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnIssued.Location = new System.Drawing.Point(0, 411);
            this.btnIssued.Name = "btnIssued";
            this.btnIssued.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIssued.Size = new System.Drawing.Size(276, 56);
            this.btnIssued.TabIndex = 11;
            this.btnIssued.TabStop = false;
            this.btnIssued.Text = "ISSUED BOOKS";
            this.btnIssued.UseVisualStyleBackColor = true;
            this.btnIssued.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIssued_MouseClick);
            // 
            // btnBook
            // 
            this.btnBook.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnBook.AutoCheck = false;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBook.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBook.Location = new System.Drawing.Point(0, 356);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(276, 56);
            this.btnBook.TabIndex = 10;
            this.btnBook.TabStop = false;
            this.btnBook.Text = "BOOK CATALOG";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBook_MouseClick);
            // 
            // btnStudents
            // 
            this.btnStudents.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnStudents.AutoCheck = false;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudents.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStudents.Location = new System.Drawing.Point(0, 301);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(276, 56);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.TabStop = false;
            this.btnStudents.Text = "STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStudents_MouseClick);
            // 
            // btnUsers
            // 
            this.btnUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnUsers.AutoCheck = false;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUsers.Location = new System.Drawing.Point(0, 246);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(276, 56);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.TabStop = false;
            this.btnUsers.Text = "MANAGE USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUsers_MouseClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDashboard.AutoCheck = false;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDashboard.Location = new System.Drawing.Point(0, 191);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(276, 56);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDashboard_MouseClick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainPanel.Location = new System.Drawing.Point(275, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(749, 734);
            this.MainPanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(993, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel sidebar;
        private Label label1;
        private Panel MainPanel;
        private CheckBox btnUsers;
        private CheckBox btnDashboard;
        private CheckBox btnReturn;
        private CheckBox btnIssued;
        private CheckBox btnBook;
        private CheckBox btnStudents;
        private Button button1;
        private Button btnClose;
    }
}