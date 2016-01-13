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
    public partial class DamageExpiry : Form
    {
        public DamageExpiry()
        {
            InitializeComponent();
        }

        public int stock_id = 0;
        BLLDamage bldmg = new BLLDamage();
        private void DamageExpiry_Load(object sender, EventArgs e)
        {
            lbltoday.Text = DateTime.Today.ToShortDateString();
        }

        private void btndamage_Click(object sender, EventArgs e)
        {
            if (txtdamagequantity.Text.Length > 0)
            {
                int i = bldmg.damageproduct(lbldamageproduct.Text, Convert.ToInt32(txtdamagequantity.Text));
                insertdamage();
                MessageBox.Show("Damage Product Has Been Added TO DataBase");
                this.Hide();
            }
        }
        public void insertdamage()
        {
            int i = bldmg.addtodamage(lbldamagecategpry.Text, lbldamageproduct.Text, Convert.ToInt32(txtdamagequantity.Text), Convert.ToDateTime(lbltoday.Text));
        }

        private void btnexpiry_Click(object sender, EventArgs e)
        {
            if (txtdamagequantity.Text.Length > 0)
            {
                int i = bldmg.damageproduct(lbldamageproduct.Text, Convert.ToInt32(txtdamagequantity.Text));
                insertexpiry();
                MessageBox.Show("Expiry Product Has Been Added TO DataBase");
                this.Hide();
            }
        }
        public void insertexpiry()
        {
            int i = bldmg.addexpirydate(lbldamagecategpry.Text, lbldamageproduct.Text, Convert.ToInt32(txtdamagequantity.Text), Convert.ToDateTime(lblexpirydate.Text), Convert.ToDateTime(lbltoday.Text));


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

