using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class TeacherMember : Member , IBorrowable
    {
        public string name;
        public int Id;

        public TeacherMember(string name, int memberId) : base(name, memberId)
        {
            this.name = name;
            this.Id = memberId;
        }

        public void BorrowBook(Book book)
        {
            book.Borrow();
            Console.WriteLine($"Techer {name} Borrowed {book.getTitle()} for the auther {book.getAuthor()}");
        }

        public void Returnbook(Book book)
        {
            book.Return();
            Console.WriteLine($"Techer {name} Returned {book.getTitle()} for the auther {book.getAuthor()}");
        }
        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 0.2;
        }
    }
}
