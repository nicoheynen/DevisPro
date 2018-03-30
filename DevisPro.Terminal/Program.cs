using DevisPro.Application;
using DevisPro.Domain;
using DevisPro.Domain.Models;
using DevisPro.Domain.Models.ValueObjects;
using DevisPro.Domain.Repositories;
using System;

namespace DevisPro.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Cus

            /////////ADD A CUSTOMER
            //var batman = new Customer
            //{
            //    Name = "Batman",
            //    Mail = "sourisvollante@mail.com",
            //    PhoneNumber = "+32 94 74 21 83",
            //    Tva = "BE 787 454 72",
            //    Address = new Address
            //    {
            //        City = "Gotham City",
            //        PostalCode = "1080",
            //        StreetAndNumber = "Boulevard Edmon Machtens 155 0047"
            //    }
            //};

            //var repository = new CustomerWriteRepository();
            //repository.AddCustomer(batman);

            ////////RESET DATABASE
            //var context = DevisProContextFactory.Create();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
        }
    }
}
