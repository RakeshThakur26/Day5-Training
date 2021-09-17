using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a static method to find the sum of all the even numbers in a List.
            //Within Main, create a list with at least 10 integers and call your method on the list.
            //Write a static method to print out each word in a list that has exactly 5 letters.
            //Modify your code to prompt the user to enter the word length for the search
            List<int> al = new List<int>();

            //Console.WriteLine("Enter 10 Integers..");
            //for(int i=0; i<10; i++)
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    al.Add(x);
            //}

            //Console.WriteLine("The sum of Even Numbers is = " + Program.AddEven(al));



            //List<string> str = new List<string>();
            //Console.WriteLine("Enter 5 strings..");

            //for(int i=0; i<5; i++)
            //    str.Add(Console.ReadLine());

            //Program.StringExp(str);



            Rectangle rt = new Rectangle(20,10, "RED");
            rt.displayArea();

            //Cube ss = new Cube();
            //Console.WriteLine("Cube dimentions...");
            //Console.WriteLine("Area of Cube is = " + ss.area());
            //Console.WriteLine("Volume of Cube is = " + ss.volume());

           
            //circle cc = new circle();
            //Console.WriteLine("Circle dimentions...");

            //Console.WriteLine("Area of Circle is = " + cc.area());
            //Console.WriteLine("Volume of Circle is = " + cc.volume());

            Console.ReadLine();

        }

        public static void StringExp(List<string> str)
        {
            Console.WriteLine("Enter the length to search String : ");
            int l = Convert.ToInt32(Console.ReadLine());

            foreach (var x in str)
            {
                if (x.Length == l)
                    Console.WriteLine(x);
            }
        }

        public static int AddEven(List<int> ar)
        {
            int sum = 0;
            foreach (var a in ar)
            {
                int k = Convert.ToInt32(a);
                if ((k % 2) == 0)
                    sum += k;
            }

            return sum;
        }

    }

}
