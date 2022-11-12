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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class ManageUsers : Form
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
            tbUsername.Clear();
            cbRole.SelectedItem = null;
            tbPassword.Clear();
            tbEmail.Clear();
            tbSearch.Clear();
            tbPassword.PasswordChar = '•';
        }
        void ReadOnly(bool x)
        {
            tbFname.ReadOnly = x;
            tbLname.ReadOnly = x;
            tbUsername.ReadOnly = x;
            cbRole.Enabled = !x;
            tbPassword.ReadOnly = x;
            tbEmail.ReadOnly = x;
        }
        public ManageUsers()
        {
            InitializeComponent();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            using (con)
            {
                openConnection();
                da = new SqlDataAdapter("SELECT * FROM Users", con);
                dt = new DataTable();
                da.Fill(dt);
                tblUsers.DataSource = dt;
                con.Close();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            openConnection();
            da = new SqlDataAdapter("SELECT * FROM Users where fname like '" + tbSearch.Text + "%' OR lname like '" + tbSearch.Text + "%' OR username like '" + tbSearch.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            tblUsers.DataSource = dt;
            con.Close();
        }
        private void tblUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                btnDisable.Enabled = true;
                btnUpdate.Enabled = true;

                foreach (DataGridViewRow row in tblUsers.SelectedRows)
                {
                    tbFname.Text = row.Cells["fname"].Value.ToString();
                    tbLname.Text = row.Cells["lname"].Value.ToString();
                    tbUsername.Text = row.Cells["username"].Value.ToString();
                    tbPassword.Text = row.Cells["password"].Value.ToString();
                    tbEmail.Text = row.Cells["email"].Value.ToString();
                    cbRole.Text = row.Cells["user_role"].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                tbFname.Focus();
                btnAdd.Text = "SAVE DATA";
                btnUpdate.Text = "CANCEL";
                btnDisable.Enabled = false;
                ClearForm();
                ReadOnly(false);
            }
            else if (btnAdd.Text == "SAVE DATA")
            {
                if (tbFname.Text.Trim() == "" || tbLname.Text.Trim() == "" || tbUsername.Text.Trim() == "" || cbRole.Text.Trim() == "" || tbPassword.Text.Trim() == "" ||  tbEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else
                {
                    openConnection();
                    using (var cmd = new SqlCommand("INSERT INTO Users (fname, lname, username, password, email, user_role) VALUES(@FirstName, @LastName, @Username, @Password, @Email, @Role)", con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", tbFname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@LastName" , tbLname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Username" , tbUsername.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Password" , tbPassword.Text);
                        cmd.Parameters.AddWithValue("@Email"    , tbEmail.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Role"     , cbRole.Text.ToUpper());
                        cmd.ExecuteNonQuery();
                    }

                    btnAdd.Text = "ADD";
                    btnUpdate.Text = "UPDATE";
                    ClearForm();
                    ReadOnly(true);
                    ManageUsers_Load(this, null);
                    con.Close();

                    MessageBox.Show("User Added Succesfully");
                }

            }
            else if (btnAdd.Text == "SAVE UPDATED DATA")
            {
                if (tbFname.Text.Trim() == "" || tbLname.Text.Trim() == "" || tbUsername.Text.Trim() == "" || cbRole.Text.Trim() == "" || tbPassword.Text.Trim() == "" || tbEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Do not leave any field blank");
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Users SET fname = @fname, lname = @lname, username = @username, password = @password, email = @email, user_role = @role WHERE user_id = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id"       , getID);
                    cmd.Parameters.AddWithValue("@fname"    , tbFname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@lname"    , tbLname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@username" , tbUsername.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@password" , tbPassword.Text);
                    cmd.Parameters.AddWithValue("@email"    , tbEmail.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@role"     , cbRole.Text.ToUpper());
                    cmd.ExecuteNonQuery();

                    btnAdd.Text = "ADD";
                    btnUpdate.Text = "UPDATE";
                    ClearForm();
                    ReadOnly(true);
                    ManageUsers_Load(this, null);
                    con.Close();

                    MessageBox.Show("User Updated Successfully");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "UPDATE")
            {
                foreach (DataGridViewRow row in tblUsers.SelectedRows)
                {
                    getID = Convert.ToInt32(row.Cells["user_id"].Value.ToString());
                }

                btnAdd.Text = "SAVE UPDATED DATA";
                btnUpdate.Text = "CANCEL";
                btnDisable.Enabled = false;
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
        private void btnDisable_Click(object sender, EventArgs e)
        {
            string name = "";

            foreach (DataGridViewRow row in tblUsers.SelectedRows)
            {
                getID = Convert.ToInt32(row.Cells["user_id"].Value.ToString());
                name = row.Cells["lname"].Value.ToString();
            }

            openConnection();
            cmd = new SqlCommand("DELETE Users WHERE user_id = @id", con);
            cmd.Parameters.AddWithValue("@id", getID);

            if (MessageBox.Show("Disable user " + name + " ?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                ClearForm();
                ManageUsers_Load(this, null);
                MessageBox.Show("User Successfully Disabled!");

            }
        }
        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '•')
            {

                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void tblUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
