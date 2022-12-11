namespace LibraryManagementSystem
{
    partial class Return
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReturned = new System.Windows.Forms.DataGridView();
            this.borrowing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnCancel = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateReturn = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnSelectStudent = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.pnlStudentSelection = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturned)).BeginInit();
            this.pnlStudentSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReturned
            // 
            this.dgvReturned.AllowUserToAddRows = false;
            this.dgvReturned.AllowUserToDeleteRows = false;
            this.dgvReturned.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturned.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReturned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowing_id,
            this.copies,
            this.book_id,
            this.title,
            this.author,
            this.stud_id,
            this.fname,
            this.lname,
            this.email,
            this.date_borrowed,
            this.date_return});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturned.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturned.Enabled = false;
            this.dgvReturned.EnableHeadersVisualStyles = false;
            this.dgvReturned.Location = new System.Drawing.Point(38, 35);
            this.dgvReturned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReturned.Name = "dgvReturned";
            this.dgvReturned.ReadOnly = true;
            this.dgvReturned.RowHeadersVisible = false;
            this.dgvReturned.RowHeadersWidth = 62;
            this.dgvReturned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReturned.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReturned.RowTemplate.Height = 33;
            this.dgvReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturned.ShowCellErrors = false;
            this.dgvReturned.ShowCellToolTips = false;
            this.dgvReturned.ShowEditingIcon = false;
            this.dgvReturned.ShowRowErrors = false;
            this.dgvReturned.Size = new System.Drawing.Size(995, 477);
            this.dgvReturned.TabIndex = 46;
            this.dgvReturned.SelectionChanged += new System.EventHandler(this.dgvReturned_SelectionChanged);
            // 
            // borrowing_id
            // 
            this.borrowing_id.DataPropertyName = "borrowing_id";
            this.borrowing_id.HeaderText = "BORROW_ID";
            this.borrowing_id.MinimumWidth = 8;
            this.borrowing_id.Name = "borrowing_id";
            this.borrowing_id.ReadOnly = true;
            this.borrowing_id.Width = 113;
            // 
            // copies
            // 
            this.copies.DataPropertyName = "copies";
            this.copies.HeaderText = "Copies";
            this.copies.MinimumWidth = 8;
            this.copies.Name = "copies";
            this.copies.ReadOnly = true;
            this.copies.Visible = false;
            this.copies.Width = 150;
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
            this.title.Width = 140;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "BOOK AUTHOR";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 147;
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
            this.fname.Width = 130;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "LAST NAME";
            this.lname.MinimumWidth = 8;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 120;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            this.email.Width = 150;
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
            this.date_return.Width = 170;
            // 
            // btnReturnCancel
            // 
            this.btnReturnCancel.AllowDrop = true;
            this.btnReturnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnReturnCancel.Enabled = false;
            this.btnReturnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnCancel.ForeColor = System.Drawing.Color.White;
            this.btnReturnCancel.Location = new System.Drawing.Point(713, 1041);
            this.btnReturnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnCancel.Name = "btnReturnCancel";
            this.btnReturnCancel.Size = new System.Drawing.Size(320, 91);
            this.btnReturnCancel.TabIndex = 48;
            this.btnReturnCancel.Text = "CANCEL";
            this.btnReturnCancel.UseVisualStyleBackColor = false;
            this.btnReturnCancel.Click += new System.EventHandler(this.btnReturnCancel_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(363, 1041);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(320, 91);
            this.btnReturnBook.TabIndex = 47;
            this.btnReturnBook.Text = "RETURN BOOK";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookID.Location = new System.Drawing.Point(208, 762);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(476, 29);
            this.txtBookID.TabIndex = 56;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookID.Location = new System.Drawing.Point(40, 762);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(86, 24);
            this.lblBookID.TabIndex = 55;
            this.lblBookID.Text = "BOOK ID";
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateIssued.Location = new System.Drawing.Point(41, 945);
            this.lblDateIssued.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(130, 24);
            this.lblDateIssued.TabIndex = 54;
            this.lblDateIssued.Text = "DATE ISSUED";
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.CustomFormat = "MM/dd/yyyy";
            this.dtpDateIssued.Enabled = false;
            this.dtpDateIssued.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIssued.Location = new System.Drawing.Point(209, 940);
            this.dtpDateIssued.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(475, 31);
            this.dtpDateIssued.TabIndex = 53;
            this.dtpDateIssued.Value = new System.DateTime(2022, 12, 12, 2, 55, 44, 535);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(208, 875);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(475, 31);
            this.txtAuthor.TabIndex = 52;
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
            this.txtTitle.Location = new System.Drawing.Point(208, 817);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(475, 31);
            this.txtTitle.TabIndex = 51;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(40, 876);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(85, 24);
            this.lblAuthor.TabIndex = 50;
            this.lblAuthor.Text = "AUTHOR";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(40, 820);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 24);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "BOOK TITLE";
            // 
            // lblDateReturn
            // 
            this.lblDateReturn.AutoSize = true;
            this.lblDateReturn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateReturn.Location = new System.Drawing.Point(40, 996);
            this.lblDateReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReturn.Name = "lblDateReturn";
            this.lblDateReturn.Size = new System.Drawing.Size(162, 24);
            this.lblDateReturn.TabIndex = 58;
            this.lblDateReturn.Text = "DATE RETURNED";
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.CustomFormat = "MM/dd/yyyy";
            this.dtpDateReturned.Enabled = false;
            this.dtpDateReturned.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReturned.Location = new System.Drawing.Point(208, 991);
            this.dtpDateReturned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(475, 31);
            this.dtpDateReturned.TabIndex = 57;
            this.dtpDateReturned.Value = new System.DateTime(2022, 12, 12, 2, 55, 44, 535);
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectStudent.ForeColor = System.Drawing.Color.White;
            this.btnSelectStudent.Location = new System.Drawing.Point(713, 542);
            this.btnSelectStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(320, 88);
            this.btnSelectStudent.TabIndex = 66;
            this.btnSelectStudent.Text = "SELECT STUDENT";
            this.btnSelectStudent.UseVisualStyleBackColor = false;
            this.btnSelectStudent.Click += new System.EventHandler(this.btnSelectStudent_Click);
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
            this.txtStudentID.TabIndex = 65;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.Location = new System.Drawing.Point(37, 542);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(119, 24);
            this.lblStudentID.TabIndex = 64;
            this.lblStudentID.Text = "STUDENT ID";
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
            this.txtEmail.TabIndex = 63;
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
            this.txtFname.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 710);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 61;
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
            this.label2.TabIndex = 60;
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
            this.label1.TabIndex = 59;
            this.label1.Text = "FIRST NAME";
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
            this.txtLname.TabIndex = 67;
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
            this.pnlStudentSelection.TabIndex = 68;
            this.pnlStudentSelection.Visible = false;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchStudent.Location = new System.Drawing.Point(23, 1068);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(322, 35);
            this.txtSearchStudent.TabIndex = 57;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(23, 1031);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 28);
            this.lblSearch.TabIndex = 56;
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
            this.dgvStudentsSelect.Location = new System.Drawing.Point(23, 25);
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
            this.dgvStudentsSelect.TabIndex = 55;
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
            this.btnSCancel.Location = new System.Drawing.Point(703, 1018);
            this.btnSCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(320, 89);
            this.btnSCancel.TabIndex = 54;
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
            this.btnSConfirmSelect.Location = new System.Drawing.Point(364, 1018);
            this.btnSConfirmSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSConfirmSelect.Name = "btnSConfirmSelect";
            this.btnSConfirmSelect.Size = new System.Drawing.Size(320, 88);
            this.btnSConfirmSelect.TabIndex = 53;
            this.btnSConfirmSelect.Text = "CONFIRM SELECTED";
            this.btnSConfirmSelect.UseVisualStyleBackColor = false;
            this.btnSConfirmSelect.Click += new System.EventHandler(this.btnSConfirmSelect_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 1156);
            this.Controls.Add(this.pnlStudentSelection);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblDateReturn);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblDateIssued);
            this.Controls.Add(this.dtpDateIssued);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturnCancel);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.dgvReturned);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturned)).EndInit();
            this.pnlStudentSelection.ResumeLayout(false);
            this.pnlStudentSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvReturned;
        private Button btnReturnCancel;
        private Button btnReturnBook;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblDateIssued;
        private DateTimePicker dtpDateIssued;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblDateReturn;
        private DateTimePicker dtpDateReturned;
        private Button btnSelectStudent;
        private TextBox txtStudentID;
        private Label lblStudentID;
        private TextBox txtEmail;
        private TextBox txtFname;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txtLname;
        private Panel pnlStudentSelection;
        private TextBox txtSearchStudent;
        private Label lblSearch;
        private DataGridView dgvStudentsSelect;
        private DataGridViewTextBoxColumn stud_id_select;
        private DataGridViewTextBoxColumn fname_select;
        private DataGridViewTextBoxColumn lname_select;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn email_select;
        private Button btnSCancel;
        private Button btnSConfirmSelect;
        private DataGridViewTextBoxColumn borrowing_id;
        private DataGridViewTextBoxColumn copies;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn stud_id;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn date_borrowed;
        private DataGridViewTextBoxColumn date_return;
    }
}