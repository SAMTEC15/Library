using System.Collections.Generic;
using LibModels;

namespace LibData
{
    public class DataBase
    {
        public static Dictionary<string, Patron> ListOfPatron = new Dictionary<string, Patron>();

        public static void AddPatron(string accountNo, Patron patron)
        {
            ListOfPatron.Add(accountNo, patron);
        }

    }
}
