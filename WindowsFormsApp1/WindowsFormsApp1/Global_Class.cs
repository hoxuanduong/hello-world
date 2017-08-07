using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Global_Class
    {

        //string use to connect to server
        //server explorer, datenverbindungen, Eigenschaften -> Verbindungszeichenfolge
        public const string localserver = "Data Source=BIB-LHOX\\CONEXIO;Initial Catalog=Testdb;Integrated Security=True";
        public const string awsserver = "Data Source=mysql.c3r9um7vz9v5.us-east-1.rds.amazonaws.com,1433;Initial Catalog=testdb2;Persist Security Info=True;User ID=xdho;Password=lentus3012";

        public static class Language
        {
            public static ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
            public static CultureInfo cul;            // declare culture info
        }

    }
}
