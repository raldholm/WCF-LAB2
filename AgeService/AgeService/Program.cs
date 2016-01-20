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
        [OperationContract]
        string CalculateEvenBirthday(DateTime date);
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
        private static void Main(string[] args)
        {
            var baseAdress = new Uri("http://localhost:8032/AgeService");


            ServiceHost selfService = new ServiceHost(typeof (AgeCalculator), baseAdress);
            try
            {
                selfService.AddServiceEndpoint(typeof (IAgeCalculatorService), new WSHttpBinding(), "AgeService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior {HttpGetEnabled = true};
                selfService.Description.Behaviors.Add(smb);
                selfService.Open();
                Console.WriteLine("Tjänsten är öppen.");
                Console.WriteLine("Tryck enter för att avsluta tjänsten.");
                Console.ReadKey();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Kommunikationsfel: " + ex.Message);
                selfService.Abort();
            }

        }
    }
    }
