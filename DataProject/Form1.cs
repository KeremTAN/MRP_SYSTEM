using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataProject
{
    public partial class Frm_inventory : Form
    {
        public int week = 1;
        public static int rowCount = 0;
        
        public Frm_inventory()
        {
            InitializeComponent();
            dataGrid_items.AllowUserToAddRows = false;
            dataGrid_items.AllowUserToDeleteRows = false;
            dataGrid_items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_items.ColumnCount = 7;
            dataGrid_items.Columns[0].Name = "PERIOD";
            dataGrid_items.Columns[1].Name = "ITEM ID";
            dataGrid_items.Columns[2].Name = "AMOUNT ON HAND";
            dataGrid_items.Columns[3].Name = "SCHEDULED RECEIPT";
            dataGrid_items.Columns[4].Name = "ARRIVAL ON WEEK";
            dataGrid_items.Columns[5].Name = "LEAD TIME";
            dataGrid_items.Columns[6].Name = "LOT SIZING RULE";
            rchBox_Information.Enabled = false;
            txt_week.Enabled = false;
            dataGrid_items.ScrollBars = ScrollBars.Both;
            Print();
        }
        private void cmb_ItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Piece_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void Print() {
            DataGridViewCellStyle c = new DataGridViewCellStyle();
            c.BackColor = Color.White;
            rowCount = dataGrid_items.RowCount;
            int i = rowCount;
            ShovelComplate_1605 sc_1605 = new ShovelComplate_1605();
            dataGrid_items.Rows.Add(sc_1605.get(week));
            dataGrid_items.Rows.Add(sc_1605.tp_13122.get(week));
            dataGrid_items.Rows.Add(sc_1605.ss_048.get(week));
            dataGrid_items.Rows.Add(sc_1605.shft_118.get(week));
            dataGrid_items.Rows.Add(sc_1605.nl_62.get(week));
            dataGrid_items.Rows.Add(sc_1605.rv_14127.get(week));
            dataGrid_items.Rows.Add(sc_1605.sa_314.get(week));
            dataGrid_items.Rows.Add(sc_1605.tp_13122.tp_457.get(week));
            dataGrid_items.Rows.Add(sc_1605.tp_13122.br_11495.get(week));
            dataGrid_items.Rows.Add(sc_1605.tp_13122.br_11495.tp129.get(week));
            dataGrid_items.Rows.Add(sc_1605.tp_13122.br_11495.tp1118.get(week));
            dataGrid_items.Rows.Add(sc_1605.sa_314.sc_2142.get(week));
            dataGrid_items.Rows.Add(sc_1605.sa_314.bd_019.get(week));
            if (week % 2 == 0)
                while (i<dataGrid_items.RowCount)
                {
                    c.BackColor = Color.White;
                    dataGrid_items.Rows[i].DefaultCellStyle = c;
                    i++;
                }
            else
                while (i < dataGrid_items.RowCount)
                {
                    c.BackColor = Color.LightGray;
                    dataGrid_items.Rows[i].DefaultCellStyle = c;
                    i++;
                }
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            rchBox_Information.Text = "";

             week = Convert.ToInt32(txt_week.Text);
            ShovelComplate_1605 sc_1605 = new ShovelComplate_1605();
            if (txt_Piece.Text != "")
            {
                if (cmb_ItemID.Text=="1605")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "13122")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.tp_13122.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.tp_13122.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "048")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.ss_048.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.ss_048.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "118")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.shft_118.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.shft_118.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "062")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.nl_62.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.nl_62.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "14127")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.rv_14127.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.rv_14127.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "314")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.sa_314.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.sa_314.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "457")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.tp_13122.tp_457.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.tp_13122.tp_457.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "11495")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.tp_13122.br_11495.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.tp_13122.br_11495.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "129")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.tp_13122.br_11495.tp129.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.tp_13122.br_11495.tp129.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "1118")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.tp_13122.br_11495.tp1118.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.tp_13122.br_11495.tp1118.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else if (cmb_ItemID.Text == "2142")
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.sa_314.sc_2142.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.sa_314.sc_2142.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                else
                {
                    if ((Convert.ToInt32(txt_Piece.Text) % Convert.ToInt32(sc_1605.sa_314.bd_019.get_lotSize()[1]) == 0 && Convert.ToInt32(txt_Piece.Text) != 0))
                    {
                        sc_1605.sa_314.bd_019.Calculate(Convert.ToInt32(txt_Piece.Text), week);
                        lbl_Warning2.ForeColor = Color.DarkGreen;
                        lbl_Warning2.Text = "Your order request that is " + txt_Piece.Text + " pieces that has " + cmb_ItemID.Text + " id number has been received!";
                    }
                    else
                    {
                        lbl_Warning2.ForeColor = Color.DarkRed;
                        lbl_Warning2.Text = "Your order request could not be received!";
                        rchBox_Information.ForeColor = Color.DarkRed;
                        rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
                    }
                }
                txt_Piece.Text = "";
            }
            else
            {
                lbl_Warning2.ForeColor = Color.DarkRed;
                lbl_Warning2.Text = "Your order request could not be received!";
                rchBox_Information.ForeColor = Color.DarkRed;
                rchBox_Information.Text = "You should check number of pieces! Your number of pieces should be proportional with lot sizing rule!";
            }

        }
        private void pcrBox_Week_Click(object sender, EventArgs e)
        {
            ShovelComplate_1605 sc = new ShovelComplate_1605();

            lbl_Warning2.Text = "";
            rchBox_Information.Text = "";
            if (week < 15)
            {
                week++;
                txt_week.Text = Convert.ToString(week);
                sc.Calculate(0,week);
                Print();
            }
            if (week>10)
            {
                btn_Order.Visible = false;
            }
        }
        private void pcrBox_Week_MouseHover(object sender, EventArgs e)
        {
            pcrBox_Week.Image = Properties.Resources._372912_48;
        }

        private void pcrBox_Week_MouseLeave(object sender, EventArgs e)
        {
            pcrBox_Week.Image = Properties.Resources.iconfinder_Next_372912__2_;
        }
        private void txt_week_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
