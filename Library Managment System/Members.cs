using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public abstract class Member
    {
        protected string name;
        protected int memberId;

        public Member(string name, int memberId)
        {
            this.name = name;
            this.memberId = memberId;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Your name is : {name}");
            Console.WriteLine($"You ID is : {memberId}");
        }
        public abstract double CalculateLateFee(int daysLate);
    }
}
