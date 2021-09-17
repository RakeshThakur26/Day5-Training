using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exception Handling ...");

            int a = 2, b = 0;
            int[] ar = null;
            
            try
            {
                // Divide by zero exception
                //int c = a / b;
                //Console.WriteLine(c);

                //DivideByZero Exception
                //int x = ar[0];

                // File not found exception
                //File.Open("sample.txt",FileMode.Open);


                // User defined exception
                if (true)
                    throw new ExceptionExample("Hello, ");

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("A number cannot divided by zero..");
                Console.ReadLine();
            }
           
            catch (NullReferenceException e)
            {
                Console.WriteLine("Remove null Reference...");

            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found the given path..");
            }

            catch (Exception e)
            {
                Console.WriteLine("General Exception");
            }

            finally
            {
                Console.WriteLine("Finally block executed successfully..!");
                Console.ReadLine();
            }
  
            //Console.WriteLine("User defined Exception ");
            //int i = 2;
            //if (i == 2)
            //    throw new ExceptionExample("Hi");

        }
    }

}
