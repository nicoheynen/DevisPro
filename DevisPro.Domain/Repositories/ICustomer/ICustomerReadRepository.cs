using DevisPro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain.Repositories
{
    public interface ICustomerReadRepository
    {
        Customer GetCustomerById(int id);
    }
}
