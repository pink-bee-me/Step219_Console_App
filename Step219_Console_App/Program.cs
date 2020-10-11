using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step219_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            MathProblem problem = new MathProblem();
            Console.WriteLine(problem.Add(num));

            try
            {
                Console.WriteLine("enter a decimal number: ");
                decimal numDecimal = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(problem.Add(numDecimal));
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something Went Wrong");
            }
            finally
            {
                Console.WriteLine("Unlike JavaScript ( which is a \"loosely typed\" , dynamic language)," +
                    "\n C# does not make concessions that allow programmers or users to take the liberty of utilizing a number value \n" +
                    " written in string form and permit the conversion of that string (number) \n" +
                    " to then be interpreted and then transformed and compiled into a bright shiny new actual integer data type which \n" +
                    " mmagically now contains a usable numberic value. Sorry... We are Done Here!!! Lol.");
                Console.ReadLine();
            }
        }
    }
}
