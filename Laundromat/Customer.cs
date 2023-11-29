using System;
using System.ComponentModel.DataAnnotations;

namespace Laundromat
{
	public class Customer
	{
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerSex { get; set; }
        public int CustomerAge { get; set; } = 0;
        [Key] public int CustomerId { get; set; }
    }
}

