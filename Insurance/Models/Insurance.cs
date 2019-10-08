using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Insurance
    {
        public Insurance()
        {
            this.Status = 1;
        }
        [Key]
        public int InsuranceId { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime PolicyDate { get; set; }
        public DateTime PolicyDuration { get; set; }
        public int Status { get; set; }

        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
