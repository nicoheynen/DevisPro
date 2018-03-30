using DevisPro.Domain.Models;
using DevisPro.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Terminal
{
    public class DataSeed
    {
        public static IEnumerable<Customer> CeateCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Name = "Batman",
                    Mail = "sourisvollante@mail.com",
                    PhoneNumber = "+32 94 74 21 83",
                    Tva = "BE 787 454 72",
                    Address = new Address
                    {
                        City = "Gotham City",
                        PostalCode ="1080",
                        StreetAndNumber = "Boulevard Edmon Machtens 155 0047"
                    }

                }
            };
        }
    }
}
