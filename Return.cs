using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Return : Form
    {
        int getBorrowID, getBookID;
        public Return()
        {
            InitializeComponent();
            this.dtpDateIssued.Value = DateTime.Now;
            this.dtpDateReturned.Value = DateTime.Now;
        }

        private void Return_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Borrowing.borrowing_id, Books.book_id, Books.title, Books.author, Students.stud_id, Students.fname, Students.lname, Students.email, Borrowing.date_borrowed, Borrowing.date_return FROM Borrowing INNER JOIN Books ON Borrowing.book_id = Books.book_id INNER JOIN Students ON Borrowing.stud_id = Students.stud_id WHERE Borrowing.date_return IS NULL", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvReturned.AutoGenerateColumns = false;
                dgvReturned.DataSource = dtbl;
                con.Close();
            }
        }
        void EnableButton(bool x)
        {
            btnSelectStudent.Enabled = x;
            btnReturnCancel.Enabled = x;
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
            dtpDateReturned.Value = DateTime.Now;
        }
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReturned.SelectedRows)
            {
                getBorrowID = Convert.ToInt32(row.Cells["borrowing_id"].Value.ToString());
                getBookID = Convert.ToInt32(row.Cells["book_id"].Value.ToString());
            }

            if (btnReturnBook.Text == "RETURN BOOK")
            {
                EnableButton(true);
                dgvReturned.Enabled = true;
                dtpDateReturned.Enabled = true;
                btnReturnBook.Text = "CONFIRM";
            }
            else if (btnReturnBook.Text == "CONFIRM")
            {
                using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Borrowing.borrowing_id, Books.book_id, Books.title, Books.author, Books.copies, Students.stud_id, Students.fname, Students.lname, Students.email, Borrowing.date_borrowed, Borrowing.date_return FROM Borrowing INNER JOIN Books ON Borrowing.book_id = Books.book_id INNER JOIN Students ON Borrowing.stud_id = Students.stud_id WHERE Borrowing.date_return IS NULL", con);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dgvReturned.AutoGenerateColumns = false;
                    dgvReturned.DataSource = dtbl;
                    con.Close();
                }
                if (txtStudentID.Text.Trim() == "" || txtBookID.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                    {
                        con.Open();
                        using (var cmd = new SqlCommand("UPDATE Borrowing SET date_return = @date_return WHERE borrowing_id = @borrowing_id", con))
                        {

                            cmd.Parameters.AddWithValue("@borrowing_id", getBorrowID);
                            cmd.Parameters.AddWithValue("@date_return", dtpDateReturned.Text);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new SqlCommand("UPDATE Books SET copies += 1 WHERE book_id = @book_id", con))
                        {
                            cmd.Parameters.AddWithValue("@book_id", getBookID);
                            cmd.ExecuteNonQuery();
                        }
                        btnReturnBook.Text = "RETURN BOOK";
                        ClearForm();
                        EnableButton(false);
                        dgvReturned.Enabled = false;
                        dtpDateReturned.Enabled = false;
                        Return_Load(this, null);

                        MessageBox.Show("Book has been succesfully returned");
                        con.Close();
                    }
                }
            }
        }
        //Student Select
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
        //Student Confrim button
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

                dgvReturned.Refresh();
                using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Borrowing.borrowing_id, Books.book_id, Books.title, Books.author, Books.copies, Students.stud_id, Students.fname, Students.lname, Students.email, Borrowing.date_borrowed, Borrowing.date_return FROM Borrowing INNER JOIN Books ON Borrowing.book_id = Books.book_id INNER JOIN Students ON Borrowing.stud_id = Students.stud_id WHERE Students.stud_id LIKE '" + txtStudentID.Text + "%' AND Borrowing.date_return IS NULL", con);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dgvReturned.AutoGenerateColumns = false;
                    dgvReturned.DataSource = dtbl;
                    con.Close();
                }
            }
        }
        //Student Cancel button
        private void btnSCancel_Click(object sender, EventArgs e)
        {
            pnlStudentSelection.Visible = false;
        }

        //student Search
        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students where stud_id like '" + txtSearchStudent.Text + "%' OR fname like '" + txtSearchStudent.Text + "%' OR lname like '" + txtSearchStudent.Text + "%' OR email like '" + txtSearchStudent.Text + "%'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvStudentsSelect.DataSource = dtbl;
                
                con.Close();
            }
        }

        private void btnReturnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel current operation", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btnReturnBook.Text = "RETURN BOOK";
                dtpDateReturned.Enabled = false;
                ClearForm();
                EnableButton(false);
                Return_Load(this,null);
            }
        }

        private void dgvReturned_SelectionChanged(object sender, EventArgs e)
        {
            if (btnReturnBook.Text == "CONFIRM")
            {
                foreach (DataGridViewRow row in dgvReturned.SelectedRows)
                {
                    txtStudentID.Text = row.Cells["stud_id"].Value.ToString();
                    txtFname.Text = row.Cells["fname"].Value.ToString();
                    txtLname.Text = row.Cells["lname"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    txtBookID.Text = row.Cells["book_id"].Value.ToString();
                    txtTitle.Text = row.Cells["title"].Value.ToString();
                    txtAuthor.Text = row.Cells["author"].Value.ToString();
                    dtpDateIssued.Text = row.Cells["date_borrowed"].Value.ToString();
                }
            }
        }
    }
}
