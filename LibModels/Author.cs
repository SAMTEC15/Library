using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class Author
    {
        public string name { get; set; }
        public string birthDate { get; set; }
        public List<Book> books { get; set; }


        public Author()
        {

        }

        public Author(string name, string birthDate, List<Book> books)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.books = books;
        }
        public string GetName(string name)
        {
            return name;
        }
        public string GetBirthDate()
        {
            return birthDate;
        }
        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
