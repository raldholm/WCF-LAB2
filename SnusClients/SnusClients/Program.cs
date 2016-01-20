using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SnusClients
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SnusCalculatorClient();
            Console.WriteLine("Mata in antal dosor Kaliber VIT snus du har förbrukat:");
            var antalDosor = double.Parse(Console.ReadLine());
            var nicotineAmount = client.CalculateNicotineAmount(antalDosor);
            Console.WriteLine("Du har konsumerat {0} milligram nikotin",nicotineAmount);
            Console.WriteLine("Varav 10-20% har absorberats av din kropp.");
            Console.WriteLine("Källa: http://www.swedishmatch.com/sv/Snus-och-halsa/Forskning-kring-snus/Nikotinupptag-/");
            Console.ReadLine();
        }
    }
}
