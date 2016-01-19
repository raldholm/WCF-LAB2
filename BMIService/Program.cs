using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace BMIService
{
    [ServiceContract(Namespace = "http://BMIService")]

    public interface IBmiCalculatorService
    {
        [OperationContract]
        double CalculateBmi(double weight, double length);
    }
    public class BmiCalculatorService : IBmiCalculatorService
    {
        public double CalculateBmi(double weight, double length)
        {
            var lengtInMeter = length / 100;
            return weight / (lengtInMeter * lengtInMeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var baseAdress = new Uri("http://localhost:8082/BMIService");
            var selfService = new ServiceHost(typeof(BmiCalculatorService), baseAdress);
            try
            {
                selfService.AddServiceEndpoint(typeof (IBmiCalculatorService), new WSHttpBinding(), "BMIService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                {
                    smb.HttpGetEnabled = true;
                }
                selfService.Description.Behaviors.Add(smb);
                selfService.Open();
                Console.WriteLine("Tjänsten är startad!");
                Console.WriteLine("Tryck på enter för att avsluta.");
                Console.ReadLine();

            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Kommunikationsfel: " +ex.Message);
                selfService.Abort();
                Console.ReadKey();
            }

        }
    }
}
