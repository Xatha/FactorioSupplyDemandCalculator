using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactorioSupplyDemandCalculatorUI
{
 
    internal class CalculationLogic
    {
        public double NumberOfProducingFactories { get; set; }
        public double NumberOfDemandingFactories { get; set; }
        public double DemandRate { get; set; }
        public double ProductionRate { get; set; }

        public CalculationLogic()
        {

        }

        internal double Calculate()
        {
            var result = double.NaN;
            //Find n_demand
            if (NumberOfProducingFactories > 0 && ProductionRate > 0 && DemandRate > 0 && !(NumberOfDemandingFactories > 0))
            {
                Console.WriteLine("====");
                result = (ProductionRate * NumberOfProducingFactories) / DemandRate;
            }
            //Find n_supply
            else if (NumberOfDemandingFactories > 0 && ProductionRate > 0 && DemandRate > 0 && !(NumberOfProducingFactories > 0))
            {
                result = (DemandRate * NumberOfDemandingFactories) / ProductionRate;
            }
            Console.WriteLine("NumberOfProducingFactories: " + NumberOfProducingFactories);
            Console.WriteLine("NumberOfDemandingFactories: " + NumberOfDemandingFactories);
            Console.WriteLine("DemandRate: " + DemandRate);
            Console.WriteLine("ProductionRate: " + ProductionRate);
            Console.WriteLine($"Calculated value is: {result}");
            return result;
        }

        internal void ResetValues()
        {
            NumberOfProducingFactories = 0;
            NumberOfDemandingFactories = 0;
            DemandRate = 0;
            ProductionRate = 0;
        }


    }
}
