using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation
{
    public static class Resources
    {
        public static (string stn, string bxn, string iso, string umb, string mask)[] Cnu =
        {
            ("충남대학교","1","isOpen_true.PNG","10","5"),
            ("충남대학교","2","isOpen_false.PNG","10","5"),
            ("충남대학교","3","isOpen_true.PNG","10","5"),
        };

        public static (string stn, string bxn, string iso, string umb, string mask)[] Pst =
        {
            ("포항공대","1","isOpen_true.PNG","3","5"),
            ("포항공대","2","isOpen_false.PNG","3","5"),
            ("포항공대","3","isOpen_false.PNG","3","5"),
        };

        

    }
}
