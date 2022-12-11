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
    public partial class Books : Form
    {

        int getID;
        public Books()
        {
            InitializeComponent();
        }

        void ClearForm()
        {
            txtAuthor.Clear();
            txtCategory.Clear();
            txtEdition.Clear();
            txtSearch.Clear();
            txtStatus.Clear();
            txtTitle.Clear();
            dtpPublication.ResetText();
        }
        void ReadOnly(bool x)
        {
            txtAuthor.ReadOnly = x;
            txtCategory.ReadOnly = x;
            txtEdition.ReadOnly = x;
            txtStatus.ReadOnly = x;
            txtTitle.ReadOnly = x;
            dtpPublication.Enabled = !x;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvBooks.AutoGenerateColumns = false;
                dgvBooks.DataSource = dtbl;
                
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (btnAdd.Text == "ADD")
            {
                txtTitle.Focus();
                btnAdd.Text = "SAVE DATA";
                btnUpdate.Text = "CANCEL";
                btnDelete.Enabled = false;
                ClearForm();
                ReadOnly(false);
            }
            else if (btnAdd.Text == "SAVE DATA")
            {
                if (txtTitle.Text.Trim() == "" || txtEdition.Text.Trim() == "" || txtCategory.Text.Trim() == "" || txtAuthor.Text.Trim() == "Select" || txtStatus.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                    {
                        con.Open();
                        using (var cmd = new SqlCommand("INSERT INTO Books (title, edition, category, author, status, publication) VALUES(@Title, @Edition, @Category, @Author, @Status, @Publication)", con))
                        {
                            cmd.Parameters.AddWithValue("@Title", txtTitle.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Edition", txtEdition.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Status", txtStatus.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Publication", dtpPublication.Text);
                            cmd.ExecuteNonQuery();
                        }

                        btnAdd.Text = "ADD";
                        btnUpdate.Text = "UPDATE";
                        ClearForm();
                        ReadOnly(true);
                        Books_Load(this, null);
                        con.Close();

                        MessageBox.Show("Data Added Succesfully");
                        con.Close();
                    }
                }

            }
            else if (btnAdd.Text == "SAVE UPDATED DATA")
            {
                using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
                {
                    if (txtTitle.Text.Trim() == "" || txtEdition.Text.Trim() == "" || txtCategory.Text.Trim() == "" || txtAuthor.Text.Trim() == "Select" || txtStatus.Text.Trim() == "")
                    {
                        MessageBox.Show("Do not leave any field blank");
                    }
                    else
                    {

                        using (var cmd = new SqlCommand("UPDATE Books SET title = @Title, edition = @Edition, category = @Category, author = @Author, status = @Status, publication = @Publication WHERE book_id = @id", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@Title", txtTitle.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Edition", txtEdition.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Status", txtStatus.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@Publication", dtpPublication.Text.ToUpper());
                            cmd.ExecuteNonQuery();
                        }

                        btnAdd.Text = "ADD";
                        btnUpdate.Text = "UPDATE";
                        ClearForm();
                        ReadOnly(true);
                        Books_Load(this, null);
                        con.Close();

                        MessageBox.Show("Record Updated Successfully");
                     }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (btnUpdate.Text == "UPDATE")
            {
                foreach (DataGridViewRow row in dgvBooks.SelectedRows)
                {
                    getID = Convert.ToInt32(row.Cells["book_id"].Value.ToString());
                }

                btnAdd.Text = "SAVE UPDATED DATA";
                btnUpdate.Text = "CANCEL";
                btnDelete.Enabled = false;
                ReadOnly(false);
            }
            else if (btnUpdate.Text == "CANCEL")
            {
                if (MessageBox.Show("Cancel current operation", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnAdd.Text = "ADD";
                    btnUpdate.Text = "UPDATE";
                    btnUpdate.Enabled = false;
                    ClearForm();
                    ReadOnly(true);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                string name = "";

                foreach (DataGridViewRow row in dgvBooks.SelectedRows)
                {
                    getID = Convert.ToInt32(row.Cells["book_id"].Value.ToString());
                    name = row.Cells["title"].Value.ToString(); 
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Books WHERE book_id = @id", con);
                cmd.Parameters.AddWithValue("@id", getID);

                if (MessageBox.Show("Remove " + name + " in record?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearForm();
                    Books_Load(this, null);
                    MessageBox.Show("Record Deleted Successfully!");

                    con.Close();
                }
            }

        }

        private void dgvBooks_SelectionChanged_1(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                foreach (DataGridViewRow row in dgvBooks.SelectedRows)
                {
                    txtTitle.Text = row.Cells["title"].Value.ToString();
                    txtEdition.Text = row.Cells["edition"].Value.ToString();
                    txtCategory.Text = row.Cells["category"].Value.ToString();
                    txtAuthor.Text = row.Cells["author"].Value.ToString();
                    txtStatus.Text = row.Cells["status"].Value.ToString();
                    dtpPublication.Text = row.Cells["publication"].Value.ToString();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books WHERE title LIKE '" + txtSearch.Text + "%' OR author LIKE '" + txtSearch.Text + "%'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvBooks.DataSource = dtbl;

                con.Close();
            }
        }
    }
}

