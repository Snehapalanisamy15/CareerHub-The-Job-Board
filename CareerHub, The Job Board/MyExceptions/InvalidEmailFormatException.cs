using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub__The_Job_Board.MyException
{
    internal class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException() : base("Invalid Email Format Exception") { }
    }
}
