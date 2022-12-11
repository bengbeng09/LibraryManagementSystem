namespace LibraryManagementSystem
{
    partial class Issued
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnIssueCancel = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnSelectStudent = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.dgvIssued = new System.Windows.Forms.DataGridView();
            this.borrowing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudentSelection = new System.Windows.Forms.Panel();
            this.pnlBookSelection = new System.Windows.Forms.Panel();
            this.dgvBooksSelect = new System.Windows.Forms.DataGridView();
            this.book_id_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copies_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBCancel = new System.Windows.Forms.Button();
            this.btnBConfirmSelect = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudentsSelect = new System.Windows.Forms.DataGridView();
            this.stud_id_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSConfirmSelect = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).BeginInit();
            this.pnlStudentSelection.SuspendLayout();
            this.pnlBookSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(206, 906);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(475, 31);
            this.txtAuthor.TabIndex = 24;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "ah",
            "bg",
            "cf",
            "de",
            "ed",
            "fc",
            "gb",
            "ha"});
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTitle.HideSelection = false;
            this.txtTitle.Location = new System.Drawing.Point(206, 848);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(475, 31);
            this.txtTitle.TabIndex = 23;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(38, 907);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(85, 24);
            this.lblAuthor.TabIndex = 22;
            this.lblAuthor.Text = "AUTHOR";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(38, 851);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 24);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "BOOK TITLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 710);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 657);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "LAST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 598);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "FIRST NAME";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(207, 709);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(476, 29);
            this.txtEmail.TabIndex = 30;
            // 
            // txtFname
            // 
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFname.Location = new System.Drawing.Point(207, 597);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(476, 29);
            this.txtFname.TabIndex = 28;
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateIssued.Location = new System.Drawing.Point(39, 989);
            this.lblDateIssued.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(130, 24);
            this.lblDateIssued.TabIndex = 33;
            this.lblDateIssued.Text = "DATE ISSUED";
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.CustomFormat = "MM/dd/yyyy";
            this.dtpDateIssued.Enabled = false;
            this.dtpDateIssued.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIssued.Location = new System.Drawing.Point(206, 984);
            this.dtpDateIssued.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(475, 31);
            this.dtpDateIssued.TabIndex = 32;
            this.dtpDateIssued.Value = new System.DateTime(2022, 12, 12, 2, 55, 44, 535);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(363, 1041);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(320, 91);
            this.btnIssueBook.TabIndex = 36;
            this.btnIssueBook.Text = "ISSUE BOOK";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnIssueCancel
            // 
            this.btnIssueCancel.AllowDrop = true;
            this.btnIssueCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnIssueCancel.Enabled = false;
            this.btnIssueCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssueCancel.ForeColor = System.Drawing.Color.White;
            this.btnIssueCancel.Location = new System.Drawing.Point(713, 1041);
            this.btnIssueCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssueCancel.Name = "btnIssueCancel";
            this.btnIssueCancel.Size = new System.Drawing.Size(320, 91);
            this.btnIssueCancel.TabIndex = 37;
            this.btnIssueCancel.Text = "CANCEL";
            this.btnIssueCancel.UseVisualStyleBackColor = false;
            this.btnIssueCancel.Click += new System.EventHandler(this.btnIssueCancel_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentID.Location = new System.Drawing.Point(207, 540);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(476, 29);
            this.txtStudentID.TabIndex = 39;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.Location = new System.Drawing.Point(37, 542);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(119, 24);
            this.lblStudentID.TabIndex = 38;
            this.lblStudentID.Text = "STUDENT ID";
            // 
            // txtBookID
            // 
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookID.Location = new System.Drawing.Point(206, 793);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(476, 29);
            this.txtBookID.TabIndex = 41;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookID.Location = new System.Drawing.Point(38, 793);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(86, 24);
            this.lblBookID.TabIndex = 40;
            this.lblBookID.Text = "BOOK ID";
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectStudent.ForeColor = System.Drawing.Color.White;
            this.btnSelectStudent.Location = new System.Drawing.Point(713, 653);
            this.btnSelectStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(320, 88);
            this.btnSelectStudent.TabIndex = 43;
            this.btnSelectStudent.Text = "SELECT STUDENT";
            this.btnSelectStudent.UseVisualStyleBackColor = false;
            this.btnSelectStudent.Click += new System.EventHandler(this.btnSelectStudent_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnSelectBook.Enabled = false;
            this.btnSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBook.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectBook.ForeColor = System.Drawing.Color.White;
            this.btnSelectBook.Location = new System.Drawing.Point(713, 851);
            this.btnSelectBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(320, 88);
            this.btnSelectBook.TabIndex = 44;
            this.btnSelectBook.Text = "SELECT BOOK";
            this.btnSelectBook.UseVisualStyleBackColor = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // dgvIssued
            // 
            this.dgvIssued.AllowUserToAddRows = false;
            this.dgvIssued.AllowUserToDeleteRows = false;
            this.dgvIssued.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssued.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssued.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIssued.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssued.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssued.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowing_id,
            this.book_id,
            this.title,
            this.author,
            this.copies,
            this.stud_id,
            this.fname,
            this.lname,
            this.date_borrowed,
            this.date_return});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssued.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssued.EnableHeadersVisualStyles = false;
            this.dgvIssued.Location = new System.Drawing.Point(38, 35);
            this.dgvIssued.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIssued.Name = "dgvIssued";
            this.dgvIssued.ReadOnly = true;
            this.dgvIssued.RowHeadersVisible = false;
            this.dgvIssued.RowHeadersWidth = 62;
            this.dgvIssued.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIssued.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIssued.RowTemplate.Height = 33;
            this.dgvIssued.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssued.ShowCellErrors = false;
            this.dgvIssued.ShowCellToolTips = false;
            this.dgvIssued.ShowEditingIcon = false;
            this.dgvIssued.ShowRowErrors = false;
            this.dgvIssued.Size = new System.Drawing.Size(995, 477);
            this.dgvIssued.TabIndex = 45;
            // 
            // borrowing_id
            // 
            this.borrowing_id.DataPropertyName = "borrowing_id";
            this.borrowing_id.HeaderText = "BORROWING_ID";
            this.borrowing_id.MinimumWidth = 8;
            this.borrowing_id.Name = "borrowing_id";
            this.borrowing_id.ReadOnly = true;
            this.borrowing_id.Width = 157;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            this.book_id.Width = 125;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "BOOK TITLE";
            this.title.MinimumWidth = 8;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 170;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "BOOK AUTHOR";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 160;
            // 
            // copies
            // 
            this.copies.DataPropertyName = "copies";
            this.copies.HeaderText = "COPIES";
            this.copies.MinimumWidth = 8;
            this.copies.Name = "copies";
            this.copies.ReadOnly = true;
            this.copies.Visible = false;
            this.copies.Width = 150;
            // 
            // stud_id
            // 
            this.stud_id.DataPropertyName = "stud_id";
            this.stud_id.HeaderText = "stud_id";
            this.stud_id.MinimumWidth = 8;
            this.stud_id.Name = "stud_id";
            this.stud_id.ReadOnly = true;
            this.stud_id.Visible = false;
            this.stud_id.Width = 150;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "FIRST NAME";
            this.fname.MinimumWidth = 8;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 150;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "LAST NAME";
            this.lname.MinimumWidth = 8;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 150;
            // 
            // date_borrowed
            // 
            this.date_borrowed.DataPropertyName = "date_borrowed";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.date_borrowed.DefaultCellStyle = dataGridViewCellStyle2;
            this.date_borrowed.HeaderText = "DATE BORROWED";
            this.date_borrowed.MinimumWidth = 8;
            this.date_borrowed.Name = "date_borrowed";
            this.date_borrowed.ReadOnly = true;
            this.date_borrowed.Width = 175;
            // 
            // date_return
            // 
            this.date_return.DataPropertyName = "date_return";
            this.date_return.HeaderText = "DATE RETURNED";
            this.date_return.MinimumWidth = 8;
            this.date_return.Name = "date_return";
            this.date_return.ReadOnly = true;
            this.date_return.Visible = false;
            this.date_return.Width = 180;
            // 
            // pnlStudentSelection
            // 
            this.pnlStudentSelection.Controls.Add(this.txtSearchStudent);
            this.pnlStudentSelection.Controls.Add(this.lblSearch);
            this.pnlStudentSelection.Controls.Add(this.dgvStudentsSelect);
            this.pnlStudentSelection.Controls.Add(this.btnSCancel);
            this.pnlStudentSelection.Controls.Add(this.btnSConfirmSelect);
            this.pnlStudentSelection.Location = new System.Drawing.Point(12, 12);
            this.pnlStudentSelection.Name = "pnlStudentSelection";
            this.pnlStudentSelection.Size = new System.Drawing.Size(1046, 1132);
            this.pnlStudentSelection.TabIndex = 46;
            this.pnlStudentSelection.Visible = false;
            // 
            // pnlBookSelection
            // 
            this.pnlBookSelection.Controls.Add(this.dgvBooksSelect);
            this.pnlBookSelection.Controls.Add(this.txtSearchBook);
            this.pnlBookSelection.Controls.Add(this.label3);
            this.pnlBookSelection.Controls.Add(this.btnBCancel);
            this.pnlBookSelection.Controls.Add(this.btnBConfirmSelect);
            this.pnlBookSelection.Location = new System.Drawing.Point(12, 15);
            this.pnlBookSelection.Name = "pnlBookSelection";
            this.pnlBookSelection.Size = new System.Drawing.Size(1046, 1132);
            this.pnlBookSelection.TabIndex = 53;
            this.pnlBookSelection.Visible = false;
            // 
            // dgvBooksSelect
            // 
            this.dgvBooksSelect.AllowUserToAddRows = false;
            this.dgvBooksSelect.AllowUserToDeleteRows = false;
            this.dgvBooksSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooksSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooksSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBooksSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooksSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBooksSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id_select,
            this.title_select,
            this.edition,
            this.category,
            this.author_select,
            this.status,
            this.publication,
            this.copies_select});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooksSelect.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBooksSelect.EnableHeadersVisualStyles = false;
            this.dgvBooksSelect.Location = new System.Drawing.Point(21, 24);
            this.dgvBooksSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBooksSelect.Name = "dgvBooksSelect";
            this.dgvBooksSelect.ReadOnly = true;
            this.dgvBooksSelect.RowHeadersVisible = false;
            this.dgvBooksSelect.RowHeadersWidth = 62;
            this.dgvBooksSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBooksSelect.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBooksSelect.RowTemplate.Height = 33;
            this.dgvBooksSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksSelect.ShowCellErrors = false;
            this.dgvBooksSelect.ShowCellToolTips = false;
            this.dgvBooksSelect.ShowEditingIcon = false;
            this.dgvBooksSelect.ShowRowErrors = false;
            this.dgvBooksSelect.Size = new System.Drawing.Size(1000, 968);
            this.dgvBooksSelect.TabIndex = 53;
            // 
            // book_id_select
            // 
            this.book_id_select.DataPropertyName = "book_id";
            this.book_id_select.HeaderText = "Book_id";
            this.book_id_select.MinimumWidth = 6;
            this.book_id_select.Name = "book_id_select";
            this.book_id_select.ReadOnly = true;
            this.book_id_select.Visible = false;
            this.book_id_select.Width = 125;
            // 
            // title_select
            // 
            this.title_select.DataPropertyName = "title";
            this.title_select.HeaderText = "TITLE";
            this.title_select.MinimumWidth = 8;
            this.title_select.Name = "title_select";
            this.title_select.ReadOnly = true;
            this.title_select.Width = 180;
            // 
            // edition
            // 
            this.edition.DataPropertyName = "edition";
            this.edition.HeaderText = "EDITION";
            this.edition.MinimumWidth = 8;
            this.edition.Name = "edition";
            this.edition.ReadOnly = true;
            this.edition.Width = 185;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 150;
            // 
            // author_select
            // 
            this.author_select.DataPropertyName = "author";
            this.author_select.HeaderText = "AUTHOR";
            this.author_select.MinimumWidth = 8;
            this.author_select.Name = "author_select";
            this.author_select.ReadOnly = true;
            this.author_select.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 135;
            // 
            // publication
            // 
            this.publication.DataPropertyName = "publication";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.publication.DefaultCellStyle = dataGridViewCellStyle9;
            this.publication.HeaderText = "PUBLICATION";
            this.publication.MinimumWidth = 8;
            this.publication.Name = "publication";
            this.publication.ReadOnly = true;
            this.publication.Width = 200;
            // 
            // copies_select
            // 
            this.copies_select.DataPropertyName = "copies";
            this.copies_select.HeaderText = "COPIES";
            this.copies_select.MinimumWidth = 8;
            this.copies_select.Name = "copies_select";
            this.copies_select.ReadOnly = true;
            this.copies_select.Visible = false;
            this.copies_select.Width = 150;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBook.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchBook.Location = new System.Drawing.Point(21, 1067);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(322, 35);
            this.txtSearchBook.TabIndex = 52;
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtBookSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 1030);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "SEARCH";
            // 
            // btnBCancel
            // 
            this.btnBCancel.AllowDrop = true;
            this.btnBCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnBCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBCancel.ForeColor = System.Drawing.Color.White;
            this.btnBCancel.Location = new System.Drawing.Point(701, 1017);
            this.btnBCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBCancel.Name = "btnBCancel";
            this.btnBCancel.Size = new System.Drawing.Size(320, 89);
            this.btnBCancel.TabIndex = 49;
            this.btnBCancel.Text = "CANCEL";
            this.btnBCancel.UseVisualStyleBackColor = false;
            this.btnBCancel.Click += new System.EventHandler(this.btnBCancel_Click);
            // 
            // btnBConfirmSelect
            // 
            this.btnBConfirmSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnBConfirmSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBConfirmSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBConfirmSelect.ForeColor = System.Drawing.Color.White;
            this.btnBConfirmSelect.Location = new System.Drawing.Point(362, 1017);
            this.btnBConfirmSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBConfirmSelect.Name = "btnBConfirmSelect";
            this.btnBConfirmSelect.Size = new System.Drawing.Size(320, 88);
            this.btnBConfirmSelect.TabIndex = 48;
            this.btnBConfirmSelect.Text = "CONFIRM SELECTED";
            this.btnBConfirmSelect.UseVisualStyleBackColor = false;
            this.btnBConfirmSelect.Click += new System.EventHandler(this.btnBConfirmSelect_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchStudent.Location = new System.Drawing.Point(21, 1067);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(322, 35);
            this.txtSearchStudent.TabIndex = 52;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtStudentSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(21, 1030);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 28);
            this.lblSearch.TabIndex = 51;
            this.lblSearch.Text = "SEARCH";
            // 
            // dgvStudentsSelect
            // 
            this.dgvStudentsSelect.AllowUserToAddRows = false;
            this.dgvStudentsSelect.AllowUserToDeleteRows = false;
            this.dgvStudentsSelect.AllowUserToResizeColumns = false;
            this.dgvStudentsSelect.AllowUserToResizeRows = false;
            this.dgvStudentsSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentsSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentsSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudentsSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentsSelect.ColumnHeadersHeight = 30;
            this.dgvStudentsSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentsSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stud_id_select,
            this.fname_select,
            this.lname_select,
            this.age,
            this.gender,
            this.contact,
            this.email_select});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsSelect.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentsSelect.EnableHeadersVisualStyles = false;
            this.dgvStudentsSelect.Location = new System.Drawing.Point(21, 24);
            this.dgvStudentsSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStudentsSelect.MultiSelect = false;
            this.dgvStudentsSelect.Name = "dgvStudentsSelect";
            this.dgvStudentsSelect.ReadOnly = true;
            this.dgvStudentsSelect.RowHeadersVisible = false;
            this.dgvStudentsSelect.RowHeadersWidth = 51;
            this.dgvStudentsSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudentsSelect.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudentsSelect.RowTemplate.Height = 25;
            this.dgvStudentsSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsSelect.ShowCellErrors = false;
            this.dgvStudentsSelect.ShowCellToolTips = false;
            this.dgvStudentsSelect.ShowEditingIcon = false;
            this.dgvStudentsSelect.ShowRowErrors = false;
            this.dgvStudentsSelect.Size = new System.Drawing.Size(1000, 968);
            this.dgvStudentsSelect.TabIndex = 50;
            // 
            // stud_id_select
            // 
            this.stud_id_select.DataPropertyName = "stud_id";
            this.stud_id_select.HeaderText = "StudentID";
            this.stud_id_select.MinimumWidth = 6;
            this.stud_id_select.Name = "stud_id_select";
            this.stud_id_select.ReadOnly = true;
            this.stud_id_select.Visible = false;
            this.stud_id_select.Width = 125;
            // 
            // fname_select
            // 
            this.fname_select.DataPropertyName = "fname";
            this.fname_select.HeaderText = "FIRST NAME";
            this.fname_select.MinimumWidth = 6;
            this.fname_select.Name = "fname_select";
            this.fname_select.ReadOnly = true;
            this.fname_select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fname_select.Width = 150;
            // 
            // lname_select
            // 
            this.lname_select.DataPropertyName = "lname";
            this.lname_select.HeaderText = "LAST NAME";
            this.lname_select.MinimumWidth = 6;
            this.lname_select.Name = "lname_select";
            this.lname_select.ReadOnly = true;
            this.lname_select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lname_select.Width = 150;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "AGE";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 80;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 125;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "CONTACT";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.contact.Width = 130;
            // 
            // email_select
            // 
            this.email_select.DataPropertyName = "email";
            this.email_select.HeaderText = "EMAIL";
            this.email_select.MinimumWidth = 6;
            this.email_select.Name = "email_select";
            this.email_select.ReadOnly = true;
            this.email_select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email_select.Width = 240;
            // 
            // btnSCancel
            // 
            this.btnSCancel.AllowDrop = true;
            this.btnSCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnSCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSCancel.ForeColor = System.Drawing.Color.White;
            this.btnSCancel.Location = new System.Drawing.Point(701, 1017);
            this.btnSCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(320, 89);
            this.btnSCancel.TabIndex = 49;
            this.btnSCancel.Text = "CANCEL";
            this.btnSCancel.UseVisualStyleBackColor = false;
            this.btnSCancel.Click += new System.EventHandler(this.btnSCancel_Click);
            // 
            // btnSConfirmSelect
            // 
            this.btnSConfirmSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnSConfirmSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSConfirmSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSConfirmSelect.ForeColor = System.Drawing.Color.White;
            this.btnSConfirmSelect.Location = new System.Drawing.Point(362, 1017);
            this.btnSConfirmSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSConfirmSelect.Name = "btnSConfirmSelect";
            this.btnSConfirmSelect.Size = new System.Drawing.Size(320, 88);
            this.btnSConfirmSelect.TabIndex = 48;
            this.btnSConfirmSelect.Text = "CONFIRM SELECTED";
            this.btnSConfirmSelect.UseVisualStyleBackColor = false;
            this.btnSConfirmSelect.Click += new System.EventHandler(this.btnSConfirmSelect_Click);
            // 
            // txtLname
            // 
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLname.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLname.Location = new System.Drawing.Point(207, 657);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(476, 29);
            this.txtLname.TabIndex = 47;
            // 
            // Issued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 1156);
            this.Controls.Add(this.pnlBookSelection);
            this.Controls.Add(this.pnlStudentSelection);
            this.Controls.Add(this.dgvIssued);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnIssueCancel);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.lblDateIssued);
            this.Controls.Add(this.dtpDateIssued);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Issued";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issued";
            this.Load += new System.EventHandler(this.Issued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).EndInit();
            this.pnlStudentSelection.ResumeLayout(false);
            this.pnlStudentSelection.PerformLayout();
            this.pnlBookSelection.ResumeLayout(false);
            this.pnlBookSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label lblAuthor;
        private Label lblTitle;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtFname;
        private Label lblDateIssued;
        private DateTimePicker dtpDateIssued;
        private Button btnIssueBook;
        private Button btnIssueCancel;
        private TextBox txtStudentID;
        private Label lblStudentID;
        private TextBox txtBookID;
        private Label lblBookID;
        private Button btnSelectStudent;
        private Button btnSelectBook;
        private DataGridView dgvIssued;
        private Panel pnlStudentSelection;
        private Button btnSCancel;
        private Button btnSConfirmSelect;
        private DataGridView dgvStudentsSelect;
        private TextBox txtLname;
        private DataGridViewTextBoxColumn stud_id_select;
        private DataGridViewTextBoxColumn fname_select;
        private DataGridViewTextBoxColumn lname_select;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn email_select;
        private TextBox txtSearchStudent;
        private Label lblSearch;
        private Panel pnlBookSelection;
        private TextBox txtSearchBook;
        private Label label3;
        private Button btnBCancel;
        private Button btnBConfirmSelect;
        private DataGridView dgvBooksSelect;
        private DataGridViewTextBoxColumn book_id_select;
        private DataGridViewTextBoxColumn title_select;
        private DataGridViewTextBoxColumn edition;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn author_select;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn publication;
        private DataGridViewTextBoxColumn copies_select;
        private DataGridViewTextBoxColumn borrowing_id;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn copies;
        private DataGridViewTextBoxColumn stud_id;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn date_borrowed;
        private DataGridViewTextBoxColumn date_return;
    }
}