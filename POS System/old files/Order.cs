using BLLS;
using DOA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        BLLOrder blord = new BLLOrder();

        private void Order_Load(object sender, EventArgs e)
        {
            //DataTable dt = blord.getitembyname(txtitem.Text);


            item();

        }
        public void orderitem(int x)
        {
            //DataTable dt = new DataTable();
            //dt = blord.getalldata(x);
            //while (dt.Rows.Count>0)
            //{
            //   string ord = dt.Rows[0].ToString();
            //}


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //            int indexdgRow; string item = "";

            //            if (e.ColumnIndex == 1)
            //            {

            //                indexdgRow = dataGridView1.SelectedCells[0].RowIndex;

            //                if (indexdgRow < dataGridView1.Rows.Count)
            //                {
            //                    try
            //                    {
            //                        item = dataGridView1.Rows[indexdgRow].Cells[2].Value.ToString();
            //                        sql = "Delete From order3 Where tblno ='" + Convert.ToInt32(txtblno.Text) + "' AND subcategory='" + item + "'";
            //                        DC.update(sql);

            //                    }
            //                    catch
            //                    {
            //                        msg = "Sorry no rows exist to delete";
            //                        DC.error(msg);
            //                    }
            //                }

            //            }
            //        }
            //        public void editdelete()
            //        {

            //            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn(); 
            //            Editlink.UseColumnTextForLinkValue = true;
            //            Editlink.HeaderText = "Edit";
            //            Editlink.DataPropertyName = "lnkColumn"; 
            //            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //            Editlink.Text = "Edit"; dataGridView1.Columns.Add(Editlink); 
            //            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //            Deletelink.UseColumnTextForLinkValue = true;
            //            Deletelink.HeaderText = "delete";
            //            Deletelink.DataPropertyName = "lnkColumn"; 
            //            Deletelink.LinkBehavior = LinkBehavior.SystemDefault; 
            //            Deletelink.Text = "Delete"; 
            //            dataGridView1.Columns.Add(Deletelink); 
            //}
        }
        int i;
       

        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = blord.getalldatafromitem();
            
           

           


                    //if (dt.Rows.Count > 0)
                    //{
                    //    string[] postSource = dt.AsEnumerable().Select<System.Data.DataRow, String>(x => x.Field<String>("item_name")).ToArray();
                    //    var source = new AutoCompleteStringCollection();
                    //    source.AddRange(postSource);
                    //    txtitem.AutoCompleteCustomSource = source;
                    //    txtitem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //    txtitem.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }

        private void cboitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboitem.SelectedIndex != 0)
            {
                DataTable dt =blord.getallitemprice (Convert.ToInt32(cboitem.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtcost.Text = dt.Rows[0]["item_price"].ToString();
                    txtquantity.Focus();

                }
            }
        }
        public void item()
        {
            DataTable dt = blord.getalldatafromitem();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["item_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cboitem.DataSource = dt;
                cboitem.DisplayMember = "item_name";
                cboitem.ValueMember = "item_id";
            }
        }

        private void txtquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtquantity.Text.Length > 0)
                {
                    txttotal.Text = (Convert.ToDecimal(txtcost.Text) * Convert.ToDecimal(txtquantity.Text)).ToString();
                    btnorder.Focus();
                }

            }
        }
        private void btnorder_Click(object sender, EventArgs e)
        {
            if (txttblno.Text.Length > 0)
            {
                int i = blord.insertorder(txtusername.Text, Convert.ToInt32(txttblno.Text), cboitem.Text.ToString(), Convert.ToInt32(txtquantity.Text), Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtcost.Text));
                gridview();
            }
        }
        public void gridview()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["calitem"].Value = cboitem.Text;
            dataGridView1.Rows[i].Cells["calquantity"].Value = txtquantity.Text;
            dataGridView1.Rows[i].Cells["caltable_no"].Value = txttblno.Text;

            dataGridView1.Rows[i].Cells["caltotal"].Value = txttotal.Text;
            dataGridView1.Rows[i].Cells["calcost"].Value = txtcost.Text;
            i++;

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            orderlist oid = new orderlist();
            oid.ShowDialog(this);
        }

        private void txtsearchtableno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttblno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }


        }

    
       
        
    
