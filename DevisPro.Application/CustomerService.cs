using DevisPro.Domain.Models;
using DevisPro.Domain.Models.ValueObjects;
using DevisPro.Domain.Repositories.ICustomer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Application
{
    public class CustomerService
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public CustomerService(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        public void CreateCustomer(string name,
                                    string streetAndNumber,
                                    string postalCode,
                                    string city,
                                    string mail,
                                    string phone,
                                    string tva)
        {
            var customer = new Customer
            {
                Name = name,
                Mail = mail,
                PhoneNumber = phone,
                Tva = tva,
                Address = new Address
                {
                    City = city,
                    PostalCode = postalCode,
                    StreetAndNumber = streetAndNumber
                }
                

            };

            _customerWriteRepository.AddCustomer(customer);

        }
    }
}
