using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain.Models.ValueObjects
{
    public class Address
    {
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetAndNumber { get; set; }
    }
}
