using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.ClassException
{
    internal class IntParseException : Exception
    {
        public IntParseException(string messeger) : base(messeger)
        {
        }
    }
}
