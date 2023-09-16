using System;
using System.Collections.Generic;
using LibData;
using LibModels;

namespace LibCore
{
    public class Registration
    {
        public static void Register()
        {
            Console.WriteLine("Welcome to the Registeration dashboard");
            Console.WriteLine("Input your firstName");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastName");
            string lname = Console.ReadLine();

            Console.WriteLine("Input your PhoneNumber");
            string number = Console.ReadLine();

            Console.WriteLine("Input your DOB");
            string Dob = Console.ReadLine();

            Console.WriteLine("Input your qualification");
            string Qualify = Console.ReadLine();

            Console.WriteLine("Input your email");
            string mail = Console.ReadLine();

            Console.WriteLine("Input your desired password");
            string passd = Console.ReadLine();

            bool found = false;

            foreach (var member in DataBase.ListOfPatron)
            {
                Patron user = member.Value;
                if (user.GetEmail() == mail)
                {
                    if (user.GetPhoneNumber() == number)
                    {
                        Console.WriteLine($"You have an existing {mail} already ");
                        found = true;
                        break;
                    }
                }

            }
            if (!found)
            {
                Patron patron = new Patron(fname, lname, number, Dob, Qualify, mail, passd);
                string PatronId = PatronNumberGenerator.GenerateId();

                DataBase.ListOfPatron.Add(PatronId, patron);

                string[] values = { fname + " " + lname, "0", mail, PatronId, "0", "Library Account" };
                //AccountStatement.statements.Add(new KeyValuePair<string, string[]>(PatronId, values));

               

            }
        }

    }
}
