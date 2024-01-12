using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub__The_Job_Board.MyException
{
    internal class ApplicationDeadlineException : Exception
    {
        public ApplicationDeadlineException() : base("Application Deadline Exception") { }
    }
}