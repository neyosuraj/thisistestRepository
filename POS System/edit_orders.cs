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
    public partial class edit_orders : Form
    {
        public edit_orders()
        {
            InitializeComponent();
        }

        public decimal cost = 0;
        BLLOrder blod = new BLLOrder();
        

    

        private void edit_orders_Load(object sender, EventArgs e)
        {

        }
        public int order_id;
        private void btnorder_Click(object sender, EventArgs e)
        {

              
            }

        private void txtquantity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtquantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtquantity.Text.Length > 0)
                {
                    lbltotal.Text = (Convert.ToInt32(txtquantity.Text) * Convert.ToDecimal(cost)).ToString();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int parsedvalue;

            if (this.txtusers.Text == "" || this.txtquantity.Text == "" || this.txtitem.Text == "" || this.txttableno.Text == "")
            {
                MessageBox.Show("the inputs are empty..");
            }
            else if (!int.TryParse(txtquantity.Text, out parsedvalue) || !int.TryParse(txttableno.Text, out parsedvalue))
            {
                MessageBox.Show("the inputs are wrong, check again and type... ");
            }

            else
            {

                int i = blod.updateorderstable(Convert.ToInt32(txttableno.Text), txtitem.Text, Convert.ToInt32(txtquantity.Text), order_id, Convert.ToDecimal(lbltotal.Text));
                if (i > 0)
                {

                    MessageBox.Show("Data Has Been Update");
                    this.Hide();
                    //update bhaye pachi gridview ma auto search bhaye ko chaena
                }

            }
            UserControl_order_lists uld = new UserControl_order_lists();
            uld.search1();
            this.Hide();

        }
    }
        }

      
   
