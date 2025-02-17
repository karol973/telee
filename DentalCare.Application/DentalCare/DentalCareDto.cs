﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Application.DentalCare
{
    internal class DentalCareDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string? About { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        public string? EncodeName { get; set; }
    }
}
