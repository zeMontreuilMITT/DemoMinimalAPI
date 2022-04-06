using System;
using System.Collections.Generic;

namespace DemoApi.Models
{
    public partial class Countrylanguage
    {
        public string CountryCode { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string IsOfficial { get; set; } = null!;
        public decimal Percentage { get; set; }
    }
}
