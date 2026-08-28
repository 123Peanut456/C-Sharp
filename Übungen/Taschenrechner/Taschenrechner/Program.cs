using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gebe Zahl 1 ein: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Gebe einen Operator ein: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Gebe Zahl2 ein ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 + number2);
                    break;

                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 - number2);
                    break;

                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 * number2);
                    break;

                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 / number2);
                    break;

                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
            Console.ReadLine();
        }
    }
}
