//JASDEEP BAJWA
// 30015656
//question 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jasdeepbajwa_30015656_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------------this program can give the result of base^exponent-----------------");
            Console.WriteLine("------------------------------------");
            //for the base 
            Console.WriteLine("enter the base value: ");
         double number1 = double.Parse(Console.ReadLine());
            //for the exponent
            Console.Write("enter the exponent value ");
            int exponent= int.Parse(Console.ReadLine());
            //result
            Console.WriteLine($"{number1}^{exponent}={number1 * exponent}");
    
             Console.WriteLine($"please enter for quit  ");
            Console.ReadLine();
        }
    }
}
