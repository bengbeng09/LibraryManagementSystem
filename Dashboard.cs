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

            foreach (Control cBox in panel2.Controls)
            {
                if (cBox is CheckBox && cBox != sender)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }

        }


        private void btnUsers_CheckedChanged(object sender, EventArgs e)
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

        private void btnStudents_CheckedChanged(object sender, EventArgs e)
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

        private void btnBook_CheckedChanged(object sender, EventArgs e)
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
    }
}
