using CHADANI_ACCOUNTING_SOFTWARE.Screens.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHADANI_ACCOUNTING_SOFTWARE.Screens.Branches;

namespace CHADANI_ACCOUNTING_SOFTWARE
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddUserForm a1 = new AddUserForm();
            a1.ShowDialog(); 

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm AP = new AddProductForm();
            AP.ShowDialog(); 

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm AC = new AddCustomerForm();
            AC.ShowDialog(); 

        }

        private void brancheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranchForm BF = new BranchForm();
            BF.ShowDialog();


        }

        private void databaseSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSetting DS = new DatabaseSetting();
            DS.ShowDialog();
         


        }
    }
}