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
    public partial class second_user_interface : Form
    {
        public second_user_interface( string user)
        {
            InitializeComponent();
          
            label4.Text = user;

        }

       

        private void products_Click(object sender, EventArgs e)
        {
            UserControl_product_add pro = new UserControl_product_add();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(pro);
            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            UserControl_add_category sell = new UserControl_add_category();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(sell);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            UserControl_order order = new UserControl_order();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(order);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            UserControl_order_lists ord = new UserControl_order_lists();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(ord);
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
            UserControl_purchase_form view = new UserControl_purchase_form();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(view);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            UserControl_dameged_products abc = new UserControl_dameged_products();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(abc);
        }

        private void products_MouseClick(object sender, MouseEventArgs e)
        {
            products.BackColor = Color.Azure;
            
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {
           
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserControl_add_category abc = new UserControl_add_category();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(abc);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.systime.Text = System.DateTime.Now.ToString();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.systime.Text = System.DateTime.Now.ToString();
        }

        private void systime_Click(object sender, EventArgs e)
        {
            this.systime.Text = System.DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserControl_view_damage damage = new UserControl_view_damage();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(damage);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserControl_view_expiry expiry = new UserControl_view_expiry();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(expiry);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            UserControl_dameged_products damage = new UserControl_dameged_products();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(damage);
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.BackColor = Color.Goldenrod;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.RoyalBlue;
        }

        private void products_MouseHover(object sender, EventArgs e)
        {
            products.BackColor = Color.Goldenrod;
        }

        private void products_MouseLeave(object sender, EventArgs e)
        {
            products.BackColor = Color.RoyalBlue;
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.BackColor = Color.Goldenrod;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.RoyalBlue;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Goldenrod;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.RoyalBlue;
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.BackColor = Color.Goldenrod;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.RoyalBlue;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.BackColor = Color.Goldenrod;
        }
        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.RoyalBlue;
        }
        private void Updateitem_MouseHover(object sender, EventArgs e)
        {
            Updateitem.BackColor = Color.Goldenrod;
        }
        private void Updateitem_MouseLeave(object sender, EventArgs e)
        {
            Updateitem.BackColor = Color.RoyalBlue;
        }


        //View
        private void viewExpiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_view_expiry vieexp = new UserControl_view_expiry();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(vieexp);
        }

        private void viewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_view_purchases viepur = new UserControl_view_purchases();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(viepur);
        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_order_lists vieord = new UserControl_order_lists();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(vieord);
        }

        private void viewDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_view_damage viedmg = new UserControl_view_damage();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(viedmg);
        }

        //Stock
        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_purchase_form stopur = new UserControl_purchase_form();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(stopur);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_product_add adpro = new UserControl_product_add();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(adpro);
        }

        private void addDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_dameged_products addmg = new UserControl_dameged_products();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(addmg);
        }

        private void orderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_order ord = new UserControl_order();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(ord);
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl_order_lists ordli = new UserControl_order_lists();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(ordli);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp sigup = new SignUp();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(sigup);
        }

        private void Updateitem_Click(object sender, EventArgs e)
        {
            item upit = new item();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(upit);
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStock viestk = new ViewStock();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(viestk);
        }

        private void viewRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewrestaurant vieret = new Viewrestaurant();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(vieret);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                   }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwareversion sp = new softwareversion();
            sp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void second_user_interface_Load(object sender, EventArgs e)
        {

        }
    }

   
    }

