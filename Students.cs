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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{

    public partial class Students : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        int getID;
        void openConnection()
        {
            con = new SqlConnection("Server=Localhost;Initial Catalog=db_library;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void ClearForm()
        {
            tbFname.Clear();
            tbLname.Clear();
            tbAge.Clear();
            cbGender.SelectedItem = null;
            tbContact.Clear();
            tbEmail.Clear();
            tbSearch.Clear();
        }
        void ReadOnly(bool x)
        {
            tbFname.ReadOnly = x;
            tbLname.ReadOnly = x;
            tbAge.ReadOnly = x;
            cbGender.Enabled = !x;
            tbContact.ReadOnly = x;
            tbEmail.ReadOnly = x;
        }
        public Students()
        {
            InitializeComponent();
        }
        private void Students_Load(object sender, EventArgs e)
        {
            using (con)
            {
                openConnection();
                da = new SqlDataAdapter("SELECT * FROM Students", con);
                dt = new DataTable();
                da.Fill(dt);
                tblStudents.DataSource = dt;
                con.Close();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            openConnection();
            da = new SqlDataAdapter("SELECT * FROM Students where fname like '" + tbSearch.Text + "%' OR lname like '" + tbSearch.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            tblStudents.DataSource = dt;
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "ADD")
            {
                tbFname.Focus();
                btnAdd.Text = "SAVE DATA";
                btnUpdate.Text = "CANCEL";
                btnDelete.Enabled = false;
                ClearForm();
                ReadOnly(false);
            }
            else if(btnAdd.Text == "SAVE DATA")
            {
                if(tbFname.Text.Trim() == "" || tbLname.Text.Trim() == "" || tbAge.Text.Trim() == "" || cbGender.Text.Trim() == "" || cbGender.Text.Trim() == "Select" || tbContact.Text.Trim() == "" || tbEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }else if (!Int32.TryParse(tbAge.Text, out int value))
                {
                    MessageBox.Show("Age is invalid");
                }
                else
                {
                    openConnection();
                    using (var cmd = new SqlCommand("INSERT INTO Students (fname, lname, age, gender, contact, email) VALUES(@FirstName, @LastName, @Age, @Gender, @Contact, @Email)", con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", tbFname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@LastName", tbLname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(tbAge.Text));
                        cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
                        cmd.Parameters.AddWithValue("@Contact", tbContact.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Email", tbEmail.Text.ToUpper());
                        cmd.ExecuteNonQuery();
                    }

                    btnAdd.Text = "ADD";
                    btnUpdate.Text = "UPDATE";
                    ClearForm();
                    ReadOnly(true);
                    Students_Load(this, null);
                    con.Close();

                    MessageBox.Show("Data Added Succesfully");
                }
                
            }
            else if(btnAdd.Text == "SAVE UPDATED DATA")
            {
                if (tbFname.Text.Trim() == "" && tbLname.Text.Trim() == "" && tbAge.Text.Trim() == "" && cbGender.Text.Trim() == "" && cbGender.Text.Trim() == "Select" && tbContact.Text.Trim() == "" && tbEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else if (!Int32.TryParse(tbAge.Text, out int value))
                {
                    MessageBox.Show("Age is invalid");
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Students SET fname = @fname, lname = @lname, age = @age, gender = @gender, contact = @contact, email = @email WHERE stud_id = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", getID);
                    cmd.Parameters.AddWithValue("@fname", tbFname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@lname", tbLname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(tbAge.Text));
                    cmd.Parameters.AddWithValue("@gender", cbGender.Text);
                    cmd.Parameters.AddWithValue("@contact", tbContact.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text.ToUpper());
                    cmd.ExecuteNonQuery();

                    btnAdd.Text = "ADD";
                    btnUpdate.Text = "UPDATE";
                    ClearForm();
                    ReadOnly(true);
                    Students_Load(this, null);
                    con.Close();

                    MessageBox.Show("Record Updated Successfully");
                }   
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "UPDATE")
            {
                foreach (DataGridViewRow row in tblStudents.SelectedRows)
                {
                    getID = Convert.ToInt32(row.Cells["stud_id"].Value.ToString());
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
            string name = "";

            foreach (DataGridViewRow row in tblStudents.SelectedRows)
            {
                getID  = Convert.ToInt32(row.Cells["stud_id"].Value.ToString());
                name = row.Cells["lname"].Value.ToString();
            }

            openConnection();
            cmd = new SqlCommand("DELETE Students WHERE stud_id = @id", con);
            cmd.Parameters.AddWithValue("@id", getID);

            if (MessageBox.Show("Remove " + name + " in record?" , "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                ClearForm();
                Students_Load(this, null);
                MessageBox.Show("Record Deleted Successfully!");

            }   
        }

        private void tblStudents_SelectionChanged(object sender, EventArgs e)
        {
            if(btnAdd.Text == "ADD")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                foreach (DataGridViewRow row in tblStudents.SelectedRows)
                {
                    tbFname.Text = row.Cells["fname"].Value.ToString();
                    tbLname.Text = row.Cells["lname"].Value.ToString();
                    tbAge.Text = row.Cells["age"].Value.ToString();
                    cbGender.Text = row.Cells["gender"].Value.ToString();
                    tbContact.Text = row.Cells["contact"].Value.ToString();
                    tbEmail.Text = row.Cells["email"].Value.ToString();
                }
            }
            
        }

        private void tblStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
