﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHADANI_ACCOUNTING_SOFTWARE.Screens.Database
{
    public partial class DatabaseSetting : MetroFramework.Forms.MetroForm
    {
        public DatabaseSetting()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database Setting has been saved successfully!!"); 

        }
    }
}
