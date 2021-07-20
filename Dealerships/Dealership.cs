using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipProject.Dealerships.Exceptions;

namespace DealershipProject.Dealerships
{
    public abstract class Dealership : IEquatable<Dealership>
    {
        public string Name { get; set; }
        public bool IsMoneyLaunderingFront { get; set; }
        public decimal AnnualRevenue { get; set; }

        public Dealership (){}

        public Dealership (string name){
            Name = name;
        }

        public void LaunderMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidLaunderingException("Cannot launder negative amounts of money");
            }
            AnnualRevenue -= amount;
        }

        public void SplitMoney(int divisor)
        {
            try
            {
                this.AnnualRevenue /= divisor;
            }
            catch(System.DivideByZeroException e) {
                Console.WriteLine("Ne se deli so nula babush");
            }
        }

        public bool Equals(Dealership other)
        {
            return AnnualRevenue.Equals(other.AnnualRevenue);
        }
    }
}
