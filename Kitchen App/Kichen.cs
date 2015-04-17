using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kitchen_App
{
    public partial class Kichen : Form
    {
        public Kichen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = treeOrders.Nodes.Count;
            TreeNode node = treeOrders.Nodes.Add("Order Name "+rand.Next(1,100));
            node.Tag = node.Text;
            node.Text += " | 00:00";
            CompletedNodes.Add(new List<Boolean>());
            OrdersTimerLog.Add(DateTime.Now);
                node.Nodes.Add("Order Item 1");
                CompletedNodes[i].Add(false);
                    node.LastNode.Nodes.Add("Removed Ingredient");

                node.Nodes.Add("Order Item 2");
                CompletedNodes[i].Add(false);
                    node.LastNode.Nodes.Add("Extra Ingredient");
                node.Nodes.Add("Order Item 3");
                CompletedNodes[i].Add(false);

            node.ExpandAll();

        }

        private void treeViewOrder_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeOrders.SelectedNode;
            if (node != null && node.Parent != null && node.Parent.Parent == null)
            {
                TreeNode nodesParent = node.Parent;
                node.ForeColor = Color.Green;
                CompletedNodes[nodesParent.Index][node.Index] = true;
                Boolean OrderDone = true;
                foreach (var nodeChild in CompletedNodes[nodesParent.Index])
                    OrderDone &= nodeChild;
                if (OrderDone)
                {

                    node.Parent.ForeColor = Color.Green;
                    CompletedOrders.Nodes.Clear();
                    CompletedOrders.Nodes.Add((TreeNode)node.Parent.Clone());
                    CompletedOrders.ExpandAll();
                    AllCompletedOrders.Add((TreeNode)node.Parent.Clone());
                    AllCompletedOrdersTimerLog.Add(OrdersTimerLog[nodesParent.Index]);
                    node.Parent.Remove();
                    CompletedNodes.RemoveAt(nodesParent.Index);
                    OrdersTimerLog.RemoveAt(nodesParent.Index);
                }

            }
            else if (node.Parent == null)
            {
                node.Expand();
            }
        }
        private void CompletedOrders_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nodeSelected = CompletedOrders.SelectedNode;
            if (nodeSelected.Parent == null)
            {
                nodeSelected.ForeColor = Color.Gray;
                List<Boolean> newNodes= new List<Boolean>();

                foreach (TreeNode node in nodeSelected.Nodes) 
                {
                    newNodes.Add(false);
                    node.ForeColor = Color.Gray;
                }
                CompletedNodes.Insert(0,newNodes);

                treeOrders.Nodes.Insert(0,(TreeNode)nodeSelected.Clone());
                nodeSelected.Remove();


                OrdersTimerLog.Insert(0, AllCompletedOrdersTimerLog[nodeSelected.Index]);
                AllCompletedOrdersTimerLog.RemoveAt(nodeSelected.Index);
                
                treeOrders.Nodes[0].ExpandAll();
                AllCompletedOrders.RemoveAt(AllCompletedOrders.Count-1);
                if (AllCompletedOrders.Count > 0)
                {
                    CompletedOrders.Nodes.Add(AllCompletedOrders.Last());
                    CompletedOrders.ExpandAll();
                }
            }
        }
        private List<List<Boolean>> CompletedNodes = new List<List<Boolean>>();
        private List<TreeNode> AllCompletedOrders = new List<TreeNode>();

        private List<DateTime> OrdersTimerLog = new List<DateTime>();
        private List<DateTime> AllCompletedOrdersTimerLog = new List<DateTime>();

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            int TIME_OVER_SEC = 10;
            int TIME_OVER_MIN = 0;

            foreach(TreeNode node in treeOrders.Nodes)
            {

                TimeSpan timeDiffrence = DateTime.Now - OrdersTimerLog[node.Index];
                node.Text = String.Format("{0} | {1}:{2}", node.Tag, timeDiffrence.Minutes.ToString().PadLeft(2, '0'), timeDiffrence.Seconds.ToString().PadLeft(2, '0'));
                if (timeDiffrence.Seconds >= TIME_OVER_SEC && timeDiffrence.Minutes >= TIME_OVER_MIN)
                {
                    node.BackColor = (node.BackColor == Color.Red)?Color.Orange:Color.Red;
                }
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
