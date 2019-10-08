using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Bill
    {
        public Bill()
        {
            this.Status = 1;
        }
        [Key]
        public int BillNo { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int Status { get; set; }

        public Customer Customer { get; set; }
        public Claim Claim { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
