using BLLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class SingUp_Form : Form
    {
        public SingUp_Form()
        {
            InitializeComponent();
        }
        BLLUser blus = new BLLUser();
        private void btnsignup_Click(object sender, EventArgs e) {

        }


        private void txtusername_Validated(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click_1(object sender, EventArgs e)
        {
            if (this.txtusername.Text == "" || this.txtpassword.Text == "" || this.txtrepassword.Text == "" || this.txtemail.Text == "")
            {

                lblmsg.Text = ("input are invalid or empty check again...");
            }

            else if (txtpassword.Text != txtrepassword.Text)
            {
                lblmsg.Text = ("Retype Password is not correct with password");
            }



            else if ((txtemail.Text.Trim() != string.Empty))
            {
                Regex mRegxExpression;
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtemail.Text.Trim()))

                {
                    lblmsg.Text = ("E-mail address format is not correct");

                    txtemail.Focus();

                }
                else
                {
                    int i = blus.signupuser(txtusername.Text, txtpassword.Text, txtemail.Text, cbousertype.Text);
                    
                   
                   if (i > 0)
                    {
                        MessageBox.Show("User Create");



                    }
                    else
                    {
                        lblmsg.Text = ("Sign Up Fail");
                    }

                }

            
        }
              
               
        }

    }
}

