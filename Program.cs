using DealershipProject.Dealerships;
using DealershipProject.Dealerships.Exceptions;
using System;
using System.Collections.Generic;

namespace DealershipProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoDealership = new AutoDealership
            {
                Name = "Dacko's Dealership",
                AnnualRevenue = 50000,
                IsMoneyLaunderingFront = true,
                CarNames = new List<string>
                {
                    "Yugo Koral 45",
                    "Skoda Felicia",
                    "Peugeot Partner",
                    "Chevrolet Kalos"
                }
            };

            try
            {
                autoDealership.LaunderMoney(-500);
            }
            catch(InvalidLaunderingException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            autoDealership.EvadeTaxes();
        }
    }
}
