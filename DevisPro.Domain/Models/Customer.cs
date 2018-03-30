using DevisPro.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Tva { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

    }
}
