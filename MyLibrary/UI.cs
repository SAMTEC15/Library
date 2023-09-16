using LibCore;
using LibModels;
using System;


namespace MyLibrary
{
    public  class UI
    {
        public static void UiInfo()
        {
            
            Console.WriteLine("YOU ARE WELCOME TO SAMTEC LIBRARY LIMITED");
            Console.WriteLine("THANK YOU FOR CHOSEN US");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Input 1 to login");
            Console.WriteLine("Input 2 to register (/If this your first time, if 'YES'\\)");           
            Console.WriteLine("Input 3 to logout");           
            string whatYouWant = Console.ReadLine();                      

            switch (whatYouWant)
            {
                case "1": Login.login();
                    Activities.BookSearch();
                    break;
                case "2":
                    Registration.Register();
                    Login.SuccessFulLogin();

                    break;
                case "3":
                    Console.WriteLine("You have successfully logout"); ;
                    break;
                    
                default: Console.Clear();
                    Console.WriteLine("Enter a valid input");
                    Console.WriteLine();
                    UI.UiInfo(); 
                    break;
            }
            
        }      
        
    }
}
