using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Status = 1;
        }

        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        public int Status { get; set; }

        public List<Bill> Bills { get; set; } 
        public List<Claim> Claims { get; set; } 
        public List<Insurance> Insurances { get; set; } 
        public List<Estimate> Estimates { get; set; } 
        public Account Account { get; set; }
    }
}
