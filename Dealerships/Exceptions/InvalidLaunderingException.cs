using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProject.Dealerships.Exceptions
{
    public class InvalidLaunderingException : Exception
    {
        public InvalidLaunderingException(string? message) : base(message) { }
    }
}
