using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeClients
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new AgeCalculatorServiceClient();
            Console.WriteLine("Mata in ditt födelsedatum. (YYYY-MM-DD)");
            var birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Du är {0} dagar gammal.", client.CalculateAgedays(birthdate));
            Console.WriteLine("Du fyller jämt antal tusen dagar på datumet: {0}",client.CalculateEvenBirthday(birthdate) );
            Console.ReadKey();
        }
    }
}
