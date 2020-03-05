using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
