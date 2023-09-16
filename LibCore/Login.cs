using System;
using LibData;
using LibModels;

namespace LibCore
{
    public class Login
    {
        enum user
        {
            Workers,
            Patron
        }
        public static void login()
        {

            Console.WriteLine("Input your UserID");
            string UserID = Console.ReadLine();

            Console.WriteLine("Input your password");
            string pass = Console.ReadLine();

            if (pass == "" || UserID == "")
            {
                Console.WriteLine("All field needed");
                login();
            }
            else
            {
                bool found = false;

                foreach (var custom in DataBase.ListOfPatron)
                {
                    if (custom.Key == UserID)
                    {
                        Patron foundPatron = custom.Value;
                        string passed = foundPatron.GetPassword();

                        // Check if the provided password matches the stored password
                        if (passed == pass)
                        {
                            // Set the 'found' flag to true to indicate a successful login
                            found = true;
                        }
                    }
                }
                if (found)
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Invalid Login details!. Try again");
                    login();
                }
                    
            }

        }
        public static void SuccessFulLogin()
        {
            Console.Clear();
            Console.WriteLine("You are welcome to samtec library where we borrow out books to our members for free");
            Console.WriteLine("Your account has been successfully created");
            Console.WriteLine($"Your ID is {PatronNumberGenerator.GenerateId()}");
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                Console.WriteLine("Input 1 to Login and 2 to Logout");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Login.login();
                }
                else
                {
                    Console.WriteLine("You have successfully logout");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Entry {0}", ex.Message);
                
            }
            finally
            {
                Console.WriteLine("You have successfully logout.Press any key to exit.");
                Console.ReadKey();
            }
            



        }
    }
}
        

