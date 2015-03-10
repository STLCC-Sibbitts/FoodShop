using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodShop
{
    public partial class ManageEmployees : UserControl
    {
        DatabaseServices dbs = new DatabaseServices();
        DatabaseConnection objConnect;
        string conString;
        DataSet dset;
        DataRow drow;

        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            try 
            {
                conString = dbs.DbConnectionString;
                
            }
            
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
