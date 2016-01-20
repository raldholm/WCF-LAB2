using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace SnusService
{
    [ServiceContract(Namespace = "http://SnusService")]

    public interface ISnusService
    {
        [OperationContract]
        double CalculateNicotineAmount(double antalDosor);
    }

    public class SnusCalculator : ISnusService
    {
        public double CalculateNicotineAmount(double antalDosor)
        {
            var gramNikoin = antalDosor * (16 * 0.008);
            var milligramNikotin = gramNikoin/100;
            return milligramNikotin;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
