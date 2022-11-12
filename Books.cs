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
        public Books()
        {
            InitializeComponent();
        }

        private void cmbxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=DELL16GB\\SQLEXPRESS;Initial Catalog=db_library;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dtbl;
                
                con.Close();
            }
        }
    }
}
