using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 


namespace CHADANI_ACCOUNTING_SOFTWARE
{
   public class appsetting
    {
        Configuration config;

       public appsetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 

        }


        public  void Savesettings(string value)
        {

            config.ConnectionStrings.ConnectionStrings["constr"].ConnectionString = value;
            
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStringsfaf");

        }
    }
}
