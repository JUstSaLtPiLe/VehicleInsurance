using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public int VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public float VehicleVersion { get; set; }
        public string VehicleRate { get; set; }
        public string VehicleBodyNumber { get; set; }
        public string VehicleEngineNumber { get; set; }
        public string VehicleNumber { get; set; }

        public List<Bill> Bills { get; set; }
        public List<Insurance> Insurances { get; set; }
        public List<Estimate> Estimates { get; set; }
    }
}
