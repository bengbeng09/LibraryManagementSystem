using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Initial Catalog=Login;Integrated Security=True"))
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select * from users where username = '" + tbUsername.Text + "' and password = '" + tbPassword.Text + "'", con).ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Login Succesfully");

                }
                else
                {
                    MessageBox.Show("BOBO");
                }
            }
        }
    }
}