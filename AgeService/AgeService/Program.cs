using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace AgeService
{
    [ServiceContract(Namespace = "http://AgeService")]
    public interface IAgeCalculatorService
    {
        [OperationContract]
        double CalculateAgedays(DateTime date);
    }
    public class AgeCalculator : IAgeCalculatorService
    {
        public double CalculateAgedays(DateTime date)
        {
            return (DateTime.Now - date).TotalDays;
        }
        public string CalculateEvenBirthday(DateTime birthday)
        {
            var even = 1000 - (DateTime.Now - birthday).Days % 1000;
            var even1KDayDate = DateTime.Now.AddDays(even);
            return even1KDayDate.ToShortDateString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var baseAdress = new Uri("http://localhost:8032/AgeService");

            var selfService = new ServiceHost(typeof(AgeCalculator), baseAdress);

            try
            {

                selfService.AddServiceEndpoint(typeof(IAgeCalculatorService), new BasicHttpBinding(),
                    "IAgeCalculatorService");

                var smb = new ServiceMetadataBehavior { HttpGetEnabled = true };

                selfService.Description.Behaviors.Add(smb);

                selfService.Open();

                Console.WriteLine("Servicen är startad!");
                Console.WriteLine("Tryck på valfri tangent för att avsluta");
                Console.WriteLine();
                Console.ReadKey();
            }

            catch (CommunicationException ex)
            {
                Console.WriteLine("Kunde ej starta hosten: {0}", ex);
            }
        }
    }
}
