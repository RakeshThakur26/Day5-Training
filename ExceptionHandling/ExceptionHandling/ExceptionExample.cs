using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionExample : Exception
    {
        public ExceptionExample(string x)
        {
            Console.WriteLine(x + " This is User defined Exception");
            Console.Read();

        }
    }


}
