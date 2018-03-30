using DevisPro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain.Repositories.ICustomer
{
    public interface ICustomerWriteRepository
    {
        void AddCustomer(Customer customer);
    }
}
