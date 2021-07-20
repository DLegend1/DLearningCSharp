using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProject.Dealerships
{
    public class AutoDealership : Dealership, IEvadeTaxes
    {
        public List<string> CarNames { get; set; }

        public void EvadeTaxes()
        {
            Console.WriteLine($"Dealership {this.Name} has successfully evaded taxes!");
        }
    }
}
