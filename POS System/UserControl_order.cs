using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLS;
using System.Drawing.Printing;

namespace POS_System
{
    public partial class UserControl_order : UserControl
    {
        public UserControl_order()
        {
            InitializeComponent();
        }
        BLLOrder blord = new BLLOrder();

        private void UserControl_order_Load(object sender, EventArgs e)
        {
            items();
            
        }
        public void items()
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



        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboitem.SelectedIndex != 0)
            {
                DataTable dt = blord.getallitemprice(Convert.ToInt32(cboitem.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtcost.Text = dt.Rows[0]["item_price"].ToString();
                    txtquantity.Focus();

                }
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
        private void btnorder_Click(object sender, EventArgs e)
        {
            int parsedvalue;
            if (txtusername.Text == "" || txttblno.Text == "" || txtquantity.Text == "")
            {

                MessageBox.Show("inputs are required");
            }

            else if (!int.TryParse(this.txttblno.Text, out parsedvalue) || !int.TryParse(this.txtquantity.Text, out parsedvalue) || !int.TryParse(this.txtcost.Text, out parsedvalue) || !int.TryParse(this.txttotal.Text, out parsedvalue))
            {

               lblmsg.Text = ("the input are invalid...");//assigning the text in labels
            }
            else {

                if (txttblno.Text.Length > 0)
                {
                    int i = blord.insertorder(txtusername.Text, Convert.ToInt32(txttblno.Text), cboitem.Text.ToString(), Convert.ToInt32(txtquantity.Text), Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtcost.Text));
                    gridview();
                    print();
                }
            }
        } 

        private void btnview_Click(object sender, EventArgs e)
        {
            orderlist oid = new orderlist();
            oid.ShowDialog(this);
        }

        private void txtsearchtableno_TextChanged(object sender, EventArgs e)
        {

        }
        BLLOrder blod = new BLLOrder();
        private void order_search_Click(object sender, EventArgs e)
        {

           
        }

        private void txtquantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            int parsedvalue;
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(txtcost.Text, out parsedvalue) || !int.TryParse(txtquantity.Text, out parsedvalue))
                {
                    MessageBox.Show("cost or quantity cant be straings...");
                }
                else if(txtquantity.Text.Length > 0)
                {
                    txttotal.Text = (Convert.ToDecimal(txtcost.Text) * Convert.ToDecimal(txtquantity.Text)).ToString();
                    btnorder.Focus();
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Arial", 12);
            PaperSize psize = new PaperSize("Custome", 100, 200);
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            pdoc.DefaultPageSettings.PaperSize.Height = 320;
            pdoc.DefaultPageSettings.PaperSize.Width = 200;
            pdoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pdoc;
                result = ppd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();

                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string name; string quantity;
            string table_no;
            table_no = txttblno.Text;
            Graphics gra = e.Graphics;
            String strDate = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToShortDateString();
            gra.DrawString(strDate, new System.Drawing.Font("Arial", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10,50 );
            gra.DrawString("Web Bank Nepal", new System.Drawing.Font("Times New Roamn", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 50, 20);
            gra.DrawString("A Family Restaurant", new System.Drawing.Font("Times New Roman ", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 57, 30);
            gra.DrawString("Kathmandu Nepal", new System.Drawing.Font("Times New Roman ", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 50, 40);
            gra.DrawString("Table No", new System.Drawing.Font("Arial", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 95, 50);
            gra.DrawString(table_no, new System.Drawing.Font("Arial", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 140, 50);

            gra.DrawString("----------------------------------------------------------", new System.Drawing.Font("Arial", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 55);
            gra.DrawString("Item", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 65);
            gra.DrawString("Quantity", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 140, 65);
           
            gra.DrawString("----------------------------------------------------------", new System.Drawing.Font("Arial", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 70);

            int y;
           
            y = 80;

            name = cboitem.Text;
            quantity = txtquantity.Text;
               


                gra.DrawString(name, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, y);

                gra.DrawString(quantity, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 140, y);

                //gra.DrawString(soldprice, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 120, y);

               
                y = y + 15;
            }

        private void msg_Click(object sender, EventArgs e)
        {

        }
    }
}

