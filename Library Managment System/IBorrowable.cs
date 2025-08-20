using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public interface IBorrowable
    {
        public void BorrowBook(Book book);
        public void Returnbook(Book book);
    }
}
