using System;
using System.ComponentModel.DataAnnotations;

namespace Laundromat
{
	public class Equipment
	{
        public string? EquipmentType { get; set; }
        [Key] public string? SerialNumber { get; set; }
        public decimal CustomerPrice { get; set; }

    }
}

