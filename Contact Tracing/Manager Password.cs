using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Manager_Password : Form
    {
        ManagerList openManager = new ManagerList();
        public string password = "0000";
        public Manager_Password()
        {
            InitializeComponent();
        }
        private void reset()
        {
            passwordInput.Text = string.Empty;
            passwordNotCorrect.Text = string.Empty;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            reset();
            this.Hide();
        }
        private bool checkRequired()
        {
            bool passwordCorrect = true;
            if (passwordInput.Text != password)
            {
                passwordCorrect = false;
            }
            return passwordCorrect;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isPasswordCorrect = checkRequired();
            if (isPasswordCorrect)
            {
                reset();
                this.Hide();
                openManager.Show();
            }
            else
            {
                passwordNotCorrect.Text = "Password is Incorrect";
            }
        }
    }
}
