using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class Book
    {
        public string Title { get; set; }  
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int NoOfCopies { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, string iSBN, int noOfCopies)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            NoOfCopies = noOfCopies;
        }

        public string GetTitle()
        {
            return Title;
        }
        public string SetTitle(string title)
        {
            Title = title;
            return Title;
        }

        public int GetNoOfCopies()
        {
            return NoOfCopies;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public string GetIsbn(string isbn)
        {
            return isbn;
        }

    }
}
