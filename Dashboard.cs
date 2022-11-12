using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void clearCheckBox(object sender)
        {

            foreach (Control cBox in sidebar.Controls)
            {
                if (cBox is CheckBox && cBox != sender)
                {
                    ((CheckBox)cBox).Checked = false;
                    ((CheckBox)cBox).ForeColor = Color.FromArgb(100, 100, 100);
                }
                else if(cBox == sender)
                {
                    ((CheckBox)cBox).Checked = true;
                    ((CheckBox)cBox).ForeColor = Color.White;
                }
            }

        }
        private void btnDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnDashboard);
            MainPanel.Refresh();
        }

        private void btnUsers_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnUsers);
            ManageUsers mUsers = new ManageUsers();
            mUsers.TopLevel = false;
            mUsers.AutoScroll = true;
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
            this.MainPanel.Controls.Add(mUsers);
            mUsers.Show();
        }

        private void btnStudents_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnStudents);
            Students students = new Students();
            students.TopLevel = false;
            students.AutoScroll = true;
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
            this.MainPanel.Controls.Add(students);
            students.Show();
        }

        private void btnBook_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnBook);
            Books bk = new Books();
            bk.TopLevel = false;
            bk.AutoScroll = true;
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
            this.MainPanel.Controls.Add(bk);
            bk.Show();
        }

        private void btnIssued_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnIssued);
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            clearCheckBox(btnReturn);
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebar.Focus();
            if(MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK){
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sidebar.Focus();
            if (MessageBox.Show("Are you sure?", "Exit to Desktop", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
