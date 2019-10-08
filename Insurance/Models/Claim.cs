using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Claim
    {
        public Claim()
        {
            this.Status = 1;
        }
        [Key]
        public int PolicyNumber { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public string PlaceOfAccident { get; set; }
        public double InsuranceAmount { get; set; }
        public double ClaimableAmount { get; set; }
        public int Status { get; set; }

        public Customer Customer { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
