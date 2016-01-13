using BLLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }
        BLLUser blu = new BLLUser();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public string sendusername
        {
            get

            {

                return txtusername.Text;
            }
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {


            DataTable dt = blu.getalluserlogin(txtusername.Text, txtpassword.Text);
            if (dt.Rows.Count > 0)
            {
                
                second_user_interface pur = new second_user_interface(dt.Rows[0][1].ToString());
                pur.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void btnlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //  String abc = ConfigurationSettings.AppSettings.Get("myConnection");
           // textBox1.Text = abc;
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataTable dt = blu.getalluserlogin(txtusername.Text, txtpassword.Text);
                if (dt.Rows.Count > 0)
                {

                    second_user_interface pur = new second_user_interface(dt.Rows[0][1].ToString());
                    pur.Show();
                    this.Hide();
                    btnlogin.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                }
            }

        }
        }
    }
        
    
