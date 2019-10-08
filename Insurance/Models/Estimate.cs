using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Estimate
    {
        [Key]
        public int EstimateId { get; set; }
        public long EstimateNumber { get; set; }
        public int PolicyType { get; set; }

        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
