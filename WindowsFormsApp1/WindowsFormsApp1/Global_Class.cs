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
        public static class Language
        {
            public static ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
            public static CultureInfo cul;            // declare culture info
        }

    }
}
