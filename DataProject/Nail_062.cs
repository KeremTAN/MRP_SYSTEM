using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace DataProject
{
    class Nail_062
    {
        public static string item_ID = "062";
        public static int amountOnHand = 50;
        public static int scheduled_receipt = 100;
        public static int arrivalOnWeek = 6;
        public static int leadTime = 2;
        public static string[] lotSizeRule = { "L4L", "1" };
        public int required = 2;
        public static int[] ctrl = { 0, 100 };
        public static ArrayList aOrder = new ArrayList();
        public static ArrayList changeWeek = new ArrayList();
        public Frm_inventory frm = (Frm_inventory)Application.OpenForms["Frm_inventory"];
        public void Calculate(int order, int week)
        {
            int i = 0;
            if (week == arrivalOnWeek)
            {
                amountOnHand += scheduled_receipt;
                scheduled_receipt = 0;
                arrivalOnWeek = 0;
                ctrl[0] = 1;
                int y = 0;
                if (changeWeek.Count != 0)
                {
                    while (Convert.ToInt32(changeWeek[y]) < changeWeek.Count)
                    {
                        if (Convert.ToInt32(changeWeek[y]) < week)
                            ctrl[0] += 5;
                        y++;
                    }
                }
                else
                    ctrl[0] += 5;
            }
            if (changeWeek.Count != 0)
            {
                while (i < changeWeek.Count)
                {
                    if (Convert.ToInt32(changeWeek[i]) == week)
                    {
                        if (ctrl[0] == 1)
                        {
                            amountOnHand -= ctrl[1];
                            ctrl[0]++;
                        }
                        else
                            ctrl[0] += 5;
                        int weNeed = (Convert.ToInt32(aOrder[i]) * required) - amountOnHand;
                        if (weNeed > 0)
                        {
                            amountOnHand = 0;
                            while (amountOnHand < weNeed)
                                amountOnHand += Convert.ToInt32(lotSizeRule[1]);
                            amountOnHand -= weNeed;
                        }
                        else
                            amountOnHand -= (Convert.ToInt32(aOrder[i]) * required);
                        if (ctrl[0] == 2)
                        {
                            amountOnHand += ctrl[1];
                            ctrl[0] += 5;
                        }
                        if (Convert.ToInt32(aOrder[i]) != 0)
                        {
                            frm.rchBox_Information.ForeColor = Color.Green;
                            frm.rchBox_Information.Text = "Your order of " + aOrder[i] + " pieces " + item_ID + " id has been delivered to costumor!";
                        }
                        aOrder[i] = 0;
                    }
                    i++;
                }
            }
            if (order != 0)
            {
                aOrder.Add(order);
                changeWeek.Add(leadTime + week);
            }
        }
        public int MaxWeek(int order, int week)
        {
            int weNeed = (order * required) - amountOnHand;
            if (weNeed > 0)
            {
                aOrder.Add(order);
                changeWeek.Add(leadTime + week);
                return leadTime + week;
            }
            else
            {
                aOrder.Add(order);
                changeWeek.Add(1 + week);
                return 0;
            }
        }
        public string[] get(int week)
        {
            string[] s = { Convert.ToString(week), item_ID, Convert.ToString(amountOnHand), Convert.ToString(scheduled_receipt), Convert.ToString(arrivalOnWeek), Convert.ToString(leadTime), lotSizeRule[0] };
            return s;
        }
        public string[] get_lotSize()
        {
            return lotSizeRule;
        }
    }
}
