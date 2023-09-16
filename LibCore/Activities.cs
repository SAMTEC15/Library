using LibModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCore
{
    public static class Activities
    {
        public static Dictionary<string, Book> AvailableResource = new Dictionary<string, Book>();

      
        public static void BookSearch()
        {
            Console.WriteLine("Enter the Name, Author, Genre or ISBN");
            string required = Console.ReadLine();

            if (required == null)
            {
                Console.WriteLine("Please, Invalid a serach field");
                BookSearch();
            }
            else
            {
                foreach (var item in AvailableResource)
                {
                    Book book = item.Value;
                    if (book != null)
                    {
                        if (book.Author.Equals(required, StringComparison.OrdinalIgnoreCase) ||
                            book.Title.Equals(required, StringComparison.OrdinalIgnoreCase) ||
                            book.Genre.Equals(required, StringComparison.OrdinalIgnoreCase) ||
                            book.ISBN.Equals(required, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Book found {0}", required);
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                    }
                    else//(item.Key == required)
                    {
                        Console.WriteLine("Fields can not be empty");
                    }
                }
            }
        }
    }
}
