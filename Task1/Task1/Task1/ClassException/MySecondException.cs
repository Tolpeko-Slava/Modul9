using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ClassException
{
    internal class MySecondException : Exception
    {
        public MySecondException(string messeg) : base(messeg) 
        {
           
        }
    }
}
