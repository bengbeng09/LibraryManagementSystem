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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.CheckBox();
            this.btnIssued = new System.Windows.Forms.CheckBox();
            this.btnBook = new System.Windows.Forms.CheckBox();
            this.btnStudents = new System.Windows.Forms.CheckBox();
            this.btnUsers = new System.Windows.Forms.CheckBox();
            this.btnDashboard = new System.Windows.Forms.CheckBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnIssued);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.btnStudents);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-1, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 734);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 56);
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
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(4, 499);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(272, 56);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "RETURN BOOKS";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnIssued
            // 
            this.btnIssued.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIssued.FlatAppearance.BorderSize = 0;
            this.btnIssued.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssued.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssued.Location = new System.Drawing.Point(4, 437);
            this.btnIssued.Name = "btnIssued";
            this.btnIssued.Size = new System.Drawing.Size(272, 56);
            this.btnIssued.TabIndex = 11;
            this.btnIssued.TabStop = false;
            this.btnIssued.Text = "ISSUED BOOKS";
            this.btnIssued.UseVisualStyleBackColor = true;
            this.btnIssued.CheckedChanged += new System.EventHandler(this.btnIssued_CheckedChanged);
            // 
            // btnBook
            // 
            this.btnBook.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBook.Location = new System.Drawing.Point(4, 375);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(272, 56);
            this.btnBook.TabIndex = 10;
            this.btnBook.TabStop = false;
            this.btnBook.Text = "BOOK CATALOG";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.CheckedChanged += new System.EventHandler(this.btnBook_CheckedChanged);
            // 
            // btnStudents
            // 
            this.btnStudents.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudents.Location = new System.Drawing.Point(4, 313);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(272, 56);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.TabStop = false;
            this.btnStudents.Text = "STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.CheckedChanged += new System.EventHandler(this.btnStudents_CheckedChanged);
            // 
            // btnUsers
            // 
            this.btnUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.Location = new System.Drawing.Point(3, 251);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(273, 56);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.TabStop = false;
            this.btnUsers.Text = "MANAGE USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.CheckedChanged += new System.EventHandler(this.btnUsers_CheckedChanged);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Location = new System.Drawing.Point(3, 191);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(273, 56);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainPanel.Location = new System.Drawing.Point(275, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(749, 734);
            this.MainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel MainPanel;
        private CheckBox btnUsers;
        private CheckBox btnDashboard;
        private CheckBox btnReturn;
        private CheckBox btnIssued;
        private CheckBox btnBook;
        private CheckBox btnStudents;
        private Button button1;
    }
}