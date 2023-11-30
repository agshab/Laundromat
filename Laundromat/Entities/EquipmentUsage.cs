using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laundromat
{
	public class EquipmentUsage
	{
        [Key]
        public int EquipmentUsageId { get; set; }
        public Equipment? Equipment { get; set; }
        public TimeSpan TimeWashCycle { get; set; }
        public Customer? Customer { get; set; }
        [ForeignKey(nameof(CustomerId))] public int? CustomerId { get; set; }
        public string? TypeofEquipmentinUse { get; set; }

        //public static implicit operator EquipmentUsage(Equipment v)
        //{
        //    //throw new NotImplementedException();
        //}

        //public static implicit operator EquipmentUsage((Equipment Equipment1, Equipment Equipment2, Equipment Equipment6, Equipment Equipment8) v)
        //{
        //    throw new NotImplementedException();
        //}

        //public static implicit operator EquipmentUsage((Equipment Equipment10, Equipment Equipment12, Equipment Equipment13, Equipment Equipment14, Equipment Equipment16) v)
        //{
        //    throw new NotImplementedException();
        //}

        ////public static implicit operator EquipmentUsage((Equipment Equipment17, Equipment Equipment20, Equipment Equipment21, Equipment Equipment24) v)
        ////{
        ////    throw new NotImplementedException();
        ////}

        //public static implicit operator EquipmentUsage((Equipment Equipment27, Equipment Equipment28) v)
        //{
        //    throw new NotImplementedException();
        //}

    }
}

