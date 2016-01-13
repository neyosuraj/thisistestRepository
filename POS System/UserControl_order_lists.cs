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
    public partial class UserControl_order_lists : UserControl
    {
        public UserControl_order_lists()
        {
            InitializeComponent();
        }

        BLLOrder blod = new BLLOrder();
        double vat = 0; double dis = 0; double total = 0; double netamt = 0; double stax = 0;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            search1();
        }

        public void search1()
        {
            int parsedvalue;
            if (!int.TryParse(txtsearch.Text, out parsedvalue))
            {
                lblmsg.Text = (" inputs are invalid. check again....");

            }
            else if (txtsearch.Text.Length > 0)
            {
                DataTable dt = blod.getalldata(Convert.ToInt32(txtsearch.Text));
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    lblmsg.Text = "table no not found";
                }
            }
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            label2.Text = sum.ToString();
        
    }
        private void btnprint_Click(object sender, EventArgs e)
        {
            
            print();
            if (txtsearch.Text.Length > 0)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int a = 0; a < dataGridView1.Rows.Count; a++)
                    {
                        string item = (dataGridView1.Rows[a].Cells[3].Value.ToString());
                        int quantity = Convert.ToInt32(dataGridView1.Rows[a].Cells[4].Value.ToString());
                        decimal total = Convert.ToDecimal(dataGridView1.Rows[a].Cells[5].Value.ToString());
                        string date = DateTime.Today.ToShortDateString();
                        int b = blod.addorder(item, quantity, total, Convert.ToDateTime(date));


                    }
                }
                else
                {
                    lblmsg.Text = "No record found in database";
                 }

                int i = blod.deletefromtable(Convert.ToInt32(txtsearch.Text));
                if (i > 0)
                {
                    MessageBox.Show ( "Data has been save to database");
                }
            }
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
            string price;
            string name; string quantity; string totala; int y = 0; string gt = total.ToString();
            string vati = vat.ToString(); string disi = dis.ToString(); string net = netamt.ToString();
            string staxi = stax.ToString();
            Graphics gra = e.Graphics;
            String strDate = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToShortDateString();
            gra.DrawString(strDate, new System.Drawing.Font("Arial", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 50);
            gra.DrawString("Web Bank Nepal", new System.Drawing.Font("Times New Roamn", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 50, 20);
            gra.DrawString("A Family Restaurant", new System.Drawing.Font("Times New Roman ", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 57, 30);
            gra.DrawString("Kathmandu Nepal", new System.Drawing.Font("Times New Roman ", 5, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 50, 40);

            gra.DrawString("-------------------------------------------------------", new System.Drawing.Font("Arial", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 62, 30);
            gra.DrawString("Item", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 65);
            gra.DrawString("QTY", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 95, 65);
            gra.DrawString("Price", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 120, 65);
            gra.DrawString("Total", new System.Drawing.Font("Arial", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 160, 65);
            gra.DrawString("-------------------------------------------------------", new System.Drawing.Font("Arial", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, 70);


            DataTable dt = new DataTable();
            dt = blod.getalldata(Convert.ToInt32(txtsearch.Text));
            y = 80;
            foreach (DataRow row in dt.Rows)
            {
                name = (row["item"]).ToString();
                quantity = (row["quantity"]).ToString();
                price = (row["cost"]).ToString();
                //so = Convert.ToInt32(row["cost"]);
                //soldprice = so.ToString();
                totala = (row["total"]).ToString();


                gra.DrawString(name, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, y);

                gra.DrawString(quantity, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 95, y);
                gra.DrawString(price, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 120, y);

                //gra.DrawString(soldprice, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 120, y);

                gra.DrawString(totala, new System.Drawing.Font("Time New Roamn", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 160, y);
                y = y + 15;
            }
            y = y - 5;
            gra.DrawString("-------------------------------------------------------------------------------------------", new System.Drawing.Font("Courier New ", 7, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 10, y);
            y = y + 10;
            gra.DrawString("Grand-Total ::", new System.Drawing.Font("Courier New ", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 100, y);
            gra.DrawString(label2.Text, new System.Drawing.Font("Courier New ", 6, FontStyle.Regular), new SolidBrush(System.Drawing.Color.Black), 160, y);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit_orders ord = new edit_orders();

           
            ord.order_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().ToString());
            ord.txtitem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ord.txtusers.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ord.txtquantity.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ord.txttableno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ord.cost = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            ord.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }
    }
}
