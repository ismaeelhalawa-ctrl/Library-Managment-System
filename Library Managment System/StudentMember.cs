using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class StudentMember : Member , IBorrowable
    {
        public string name;
        public int Id;

        public StudentMember(string name, int memberId) : base(name, memberId)
        {
            this.name = name;
            this.Id = memberId;
        }
        public string GetName()
        { return name; }
        public int GetID()
        { return memberId; }

        public void BorrowBook(Book book)
        {
            book.Borrow();
            Console.WriteLine($"Student {name} Borrowed {book.getTitle()} for the auther {book.getAuthor()}");
        }

        public void Returnbook(Book book)
        {
            book.Return();
            Console.WriteLine($"Student {name} Returned {book.getTitle()} for the auther {book.getAuthor()}");
        }
        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 0.5;
        }
    }
}
