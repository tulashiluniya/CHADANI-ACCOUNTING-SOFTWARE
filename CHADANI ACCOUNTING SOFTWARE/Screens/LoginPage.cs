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
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

    
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage MP = new MainPage();
            MP.Show();


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose(); 

        }
    }
}
