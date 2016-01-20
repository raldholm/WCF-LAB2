using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIClients
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BmiCalculatorServiceClient();

            Console.WriteLine("Mata in din vikt i kilogram:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Mata in din längd i centimeter:");
            var lenght = double.Parse(Console.ReadLine());
            var bmi = client.CalculateBmi(weight, lenght);

            Console.WriteLine("Ditt BMI baserat på vikt {0}kg och längden {1}cm, är: {2}", weight, lenght, bmi);
            Console.ReadKey();
        }
    }
    }

