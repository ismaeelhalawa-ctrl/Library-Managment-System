using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class Book
    {
        // Private fields for title, author, isBorrowed
        private string title;
        private string author;
        private bool isBorrowed = false;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // getters and setters for Title and Author
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return title;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getAuthor()
        {
            return author;
        }

        public void SetIsBorrowed(bool isBorrowed)
        {
            this.isBorrowed = isBorrowed;
        }
        public bool GetIsBorrowed()
        {
            return isBorrowed;
        }

        // Method Borrow
        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine($"{title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{title} is already borrowed.");
            }
        }
        // Method Return
        public void Return()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine($"{title} has been returned.");
            }
            else
            {
                Console.WriteLine($"{title} was not borrowed.");
            }
        }
    }
}
