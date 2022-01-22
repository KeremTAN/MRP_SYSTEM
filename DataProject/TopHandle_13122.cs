using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DataProject
{
    class TopHandle_13122
    {
        public static string item_ID = "13122";
        public static int amountOnHand = 0;
        public static int scheduled_receipt = 70;
        public static int arrivalOnWeek = 3;
        public static int leadTime = 1;
        public static string[] lotSizeRule = { "Multiples of 40", "40" };
        public static int required = 1;
        public static int[] ctrl = {0,70 };
        public static ArrayList aOrder = new ArrayList();
        public static ArrayList changeWeek = new ArrayList();
        public Frm_inventory frm = (Frm_inventory)Application.OpenForms["Frm_inventory"];
        public Bracelet_11495 br_11495 = new Bracelet_11495();
        public Nail_062 nl_062 = new Nail_062();
        public TopHandle_457 tp_457 = new TopHandle_457();

        public void Calculate(int order, int week)
        {
            nl_062.required = 2;
            br_11495.Calculate(0, week);
            nl_062.Calculate(0, week);
            tp_457.Calculate(0, week);
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
                        if (ctrl[0]==2)
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
                int weNeed2 = (order /** required*/) - amountOnHand;
                int subOrder = 0;
                int ix = amountOnHand;
                if (weNeed2 > 0)
                {
                    while (ix < (order /** required*/))
                    {
                        ix += Convert.ToInt32(lotSizeRule[1]);
                        subOrder += Convert.ToInt32(lotSizeRule[1]);
                    }
                    int[] maxWeek = { br_11495.MaxWeek(subOrder, week), nl_062.MaxWeek(subOrder, week), tp_457.MaxWeek(subOrder, week), leadTime + week };
                    changeWeek.Add(maxWeek.Max());
                }
                else
                    changeWeek.Add(leadTime + week);
            }
        }
        public int MaxWeek(int order, int week)
        {
            nl_062.required = 2;
            int weNeed = (order * required) - amountOnHand;
            int subOrder = 0;
            int i = amountOnHand;
            if (weNeed > 0)
            {
                while (i< (order * required))
                {
                    i += Convert.ToInt32(lotSizeRule[1]);
                    subOrder += Convert.ToInt32(lotSizeRule[1]);
                }
                aOrder.Add(order);
                int[] maxWeek = { br_11495.MaxWeek(subOrder, week), nl_062.MaxWeek(subOrder, week), tp_457.MaxWeek(subOrder, week), leadTime + week };
                changeWeek.Add(maxWeek.Max());
                return (maxWeek.Max());
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
