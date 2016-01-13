using BLLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class edit_user : Form
    {
        public edit_user()
        {
            InitializeComponent();
        }
        BLLUser blus = new BLLUser();
        private void btnchange_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = blus.getpasswordbyusername(txtpassword.Text);
            if (dt.Rows.Count > 0)
            {
                if (txtnewpassword.Text == txtrenewpassword.Text)
                {
                    int i = blus.newpassword(txtnewpassword.Text, txtusername.Text);
                    MessageBox.Show("Password Change");

                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }
            }
            else
            {
                MessageBox.Show("past password incorrect");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

            if (txtusername.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                dt = blus.getalluser();
                txtusername.Text = dt.Rows[0]["user_name"].ToString();
            }
        }
    }
}

