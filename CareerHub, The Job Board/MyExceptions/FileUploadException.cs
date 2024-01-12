using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub__The_Job_Board.MyException
{
    internal class FileUploadException : Exception
    {
        public FileUploadException() : base("File Upload Exception") { }
    }
}