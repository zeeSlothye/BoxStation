using System;
using Newtonsoft.Json.Linq;


namespace BoxStation
{
    public static class Resources
    {
        public static (string stn, string bxn, string iso, string umb, string mask)[] Box =
        {
            ("충남대학교","1","isOpen_true.PNG","10","5"),
            ("충남대학교","2","isOpen_false.PNG","10","5"),
            ("충남대학교","3","isOpen_true.PNG","10","5"),
        };

        public static (string stn, string bxn, string iso, string umb, string mask)[] User =
        {
            ("포항공대","1","isOpen_true.PNG","3","5"),
            ("포항공대","2","isOpen_false.PNG","3","5"),
            ("포항공대","3","isOpen_false.PNG","3","5"),
        }; 

        

    }
    public class User
    {
        public User(string json)
        {
            JObject data = JObject.Parse(json);

            String userId = (string)data["userId"];
            String userPw = (string)data["userPw"];
            bool autoPayment = (bool)data["autoPayment"];
        }

    }
}
