using DevisPro.Domain.Models;
using DevisPro.Domain.Repositories.ICustomer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain.Repositories
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        public void AddCustomer(Customer customer)
        {
            var context = DevisProContextFactory.Create();
            context.Customers.Add(customer);
            context.SaveChanges();

        }
    }
}
