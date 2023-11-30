using System;
using System.ComponentModel.DataAnnotations;

namespace Laundromat
{
	public class Store
	{
        public string? StoreName { get; set; }
        public string? StoreAddress { get; set; }
        [Key] public int StoreId { get; set; }

        public DateTime HoursofOperationstartoftheDay { get; set; } = new DateTime(2023, 12, 2, 6, 0, 0);
        public DateTime HoursofOperationEndoftheDay { get; set; } = new DateTime(2023, 12, 2, 22, 0, 0);

        public decimal CostToRun { get; set; } = 0.0M;
        public decimal BusinessRevenue { get; set; } = 0.0M;

        public ICollection<Equipment>? EquipmentInStore { get; set; }
        public ICollection<Customer>? CustomersinStore { get; set; }
        //public ICollection<EquipmentUsage>? EquipmentInUuseInStore { get; set; }


    }
}

