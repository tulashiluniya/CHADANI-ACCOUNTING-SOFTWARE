using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration; 


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
            string str = "Hello";

            appsetting ap = new appsetting();
            ap.Savesettings(str);
            this.Hide();

            MainPage mp = new MainPage();
            mp.Show(); 


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose(); 

        }
    }
}
