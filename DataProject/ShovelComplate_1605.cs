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
    class ShovelComplate_1605
    {
        public static string item_ID = "1605";
        public static int amountOnHand = 30;
        public static int scheduled_receipt = 0;
        public static int arrivalOnWeek = 0;
        public static int leadTime = 1;
        public static string[] lotSizeRule = { "L4L", "1" };
        public static int required = 1;
        public static int[] ctrl = { 0, 0 };
        public static ArrayList aOrder = new ArrayList();
        public static ArrayList changeWeek = new ArrayList();
        public Frm_inventory frm = (Frm_inventory)Application.OpenForms["Frm_inventory"];
        public TopHandle_13122 tp_13122 = new TopHandle_13122();
        public ScoopShaft_048 ss_048 = new ScoopShaft_048();
        public Shaft_118 shft_118 = new Shaft_118();
        public Nail_062 nl_62 = new Nail_062();
        public Rivet_14127 rv_14127 = new Rivet_14127();
        public ScoopAssembly_314 sa_314 = new ScoopAssembly_314();
        public void Calculate(int order, int week)
        {
            nl_62.required = 4;
            rv_14127.required = 4;
            tp_13122.Calculate(0, week);
            ss_048.Calculate(0, week);
            shft_118.Calculate(0,week);
            nl_62.Calculate(0, week);
            rv_14127.Calculate(0, week);
            sa_314.Calculate(0, week);
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
                    int[] maxWeek = { tp_13122.MaxWeek(subOrder,week),ss_048.MaxWeek(subOrder, week), shft_118.MaxWeek(subOrder, week), nl_62.MaxWeek(subOrder, week), rv_14127.MaxWeek(subOrder, week), sa_314.MaxWeek(subOrder, week), leadTime + week };
                    changeWeek.Add(maxWeek.Max());
                }
                else
                    changeWeek.Add(leadTime + week);
            }
        }
        public int MaxWeek(int order, int week)
        {
            nl_62.required = 4;
            rv_14127.required = 4;
            int weNeed = (order * required) - amountOnHand;
            int subOrder = 0;
            int i = amountOnHand;
            if (weNeed > 0)
            {
                while (i < (order * required))
                {
                    i += Convert.ToInt32(lotSizeRule[1]);
                    subOrder += Convert.ToInt32(lotSizeRule[1]);
                }
                aOrder.Add(order);
                int[] maxWeek = { tp_13122.MaxWeek(subOrder, week), ss_048.MaxWeek(subOrder, week), shft_118.MaxWeek(subOrder, week), nl_62.MaxWeek(subOrder, week), rv_14127.MaxWeek(subOrder, week), sa_314.MaxWeek(subOrder, week), leadTime + week };
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
