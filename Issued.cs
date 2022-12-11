using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LibraryManagementSystem
{
    public partial class Issued : Form
    {
        int getCopies;
        public Issued()
        {
            InitializeComponent();
            this.dtpDateIssued.Value = DateTime.Now;
        }
        void EnableButton(bool x)
        {
            btnSelectBook.Enabled = x;
            btnSelectStudent.Enabled = x;
            btnIssueCancel.Enabled = x;
        }
        void ClearForm()
        {
            txtStudentID.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtEmail.Clear();
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            dtpDateIssued.Value = DateTime.Now;
        }

        private void Issued_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Borrowing.borrowing_id, Books.book_id, Books.title, Books.author, Books.copies, Students.stud_id, Students.fname, Students.lname, Students.email, Borrowing.date_borrowed, Borrowing.date_return FROM Borrowing INNER JOIN Books ON Borrowing.book_id = Books.book_id INNER JOIN Students ON Borrowing.stud_id = Students.stud_id", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvIssued.AutoGenerateColumns = false;
                dgvIssued.DataSource = dtbl;
                con.Close();
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBooksSelect.SelectedRows)
            {
                getCopies = Convert.ToInt32(row.Cells["copies_select"].Value.ToString());
            }
            if (btnIssueBook.Text == "ISSUE BOOK")
            {
                EnableButton(true);
                dtpDateIssued.Enabled = true;
                btnIssueBook.Text = "CONFIRM";

            }
            else if (btnIssueBook.Text == "CONFIRM")
            {
                if (txtStudentID.Text.Trim() == "" || txtBookID.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                    {

                        if (getCopies == 0)
                        {
                            MessageBox.Show("The selected book has insufficient copies in stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBookID.Clear();
                            txtTitle.Clear();
                            txtAuthor.Clear();
                        }
                        else
                        {
                            con.Open();
                            using (var cmd = new SqlCommand("INSERT INTO Borrowing (stud_id, book_id, date_borrowed) VALUES(@stud_id, @book_id, @Date_borrowed)", con))
                            {
                                cmd.Parameters.AddWithValue("@stud_id", txtStudentID.Text.ToUpper());
                                cmd.Parameters.AddWithValue("@book_id", txtBookID.Text.ToUpper());
                                cmd.Parameters.AddWithValue("@Date_borrowed", dtpDateIssued.Text);
                                cmd.ExecuteNonQuery();
                            }
                            using (var cmd = new SqlCommand("UPDATE Books SET copies -= 1 WHERE book_id = @book_id", con))
                            {
                                cmd.Parameters.AddWithValue("@book_id", txtBookID.Text);
                                cmd.ExecuteNonQuery();
                            }
                            btnIssueBook.Text = "ISSUE BOOK";
                            ClearForm();
                            EnableButton(false);
                            dtpDateIssued.Enabled = false;
                            Issued_Load(this, null);

                            MessageBox.Show("Book has been succesfully issued");
                            con.Close();
                        }
                    }
                }
            }
        }

        //Student Select button
        private void btnSelectStudent_Click(object sender, EventArgs e)
        {
            txtSearchStudent.Focus();
            this.pnlStudentSelection.Visible = true;
            txtSearchStudent.Clear();
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvStudentsSelect.AutoGenerateColumns = false;
                dgvStudentsSelect.DataSource = dtbl;

                con.Close();
            }
        }
        //Student Confirm button
        private void btnSConfirmSelect_Click(object sender, EventArgs e)
        {
            if (dgvStudentsSelect.Rows.Count == 0)
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvStudentsSelect.SelectedRows)
                {
                    txtStudentID.Text = row.Cells[0].Value.ToString();
                    txtFname.Text = row.Cells[1].Value.ToString();
                    txtLname.Text = row.Cells[2].Value.ToString();
                    txtEmail.Text = row.Cells[6].Value.ToString();
                }
                pnlStudentSelection.Visible = false;
            }
        }
        //Student Search
        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE stud_id LIKE '" + txtSearchStudent.Text + "%' OR fname LIKE '" + txtSearchStudent.Text + "%' OR lname LIKE '" + txtSearchStudent.Text + "%' OR email LIKE '" + txtSearchStudent.Text + "%'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvStudentsSelect.DataSource = dtbl;

                con.Close();
            }
        }
        //Student Cancel button
        private void btnSCancel_Click(object sender, EventArgs e)
        {
            pnlStudentSelection.Visible = false;
        }

        //Book Select button
        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            txtSearchBook.Focus();
            this.pnlBookSelection.Visible = true;
            txtSearchBook.Clear();
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvBooksSelect.AutoGenerateColumns = false;
                dgvBooksSelect.DataSource = dtbl;

                con.Close();
            }
        }

        //Book Search
        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books WHERE book_id LIKE '" + txtSearchBook.Text + "%' OR title LIKE '" + txtSearchBook.Text + "%' OR author LIKE '" + txtSearchBook.Text + "%'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvBooksSelect.DataSource = dtbl;

                con.Close();
            }
        }


        //Book Confirm button
        private void btnBConfirmSelect_Click(object sender, EventArgs e)
        {
            if (dgvBooksSelect.Rows.Count == 0)
            {
                MessageBox.Show("Book not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvBooksSelect.SelectedRows)
                {
                    txtBookID.Text = row.Cells[0].Value.ToString();
                    txtTitle.Text = row.Cells[1].Value.ToString();
                    txtAuthor.Text = row.Cells[4].Value.ToString();
                }
                pnlBookSelection.Visible = false;
            }
        }
        //Book Cancel button
        private void btnBCancel_Click(object sender, EventArgs e)
        {
            pnlBookSelection.Visible = false;
        }

        private void btnIssueCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel current operation", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btnIssueBook.Text = "ISSUE BOOK";
                dtpDateIssued.Enabled = false;
                ClearForm();
                EnableButton(false);
            }
        }
    }
}
