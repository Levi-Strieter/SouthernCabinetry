﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SouthernCabinetry.Models
{
    public class FinancialOutputs
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
