using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace VehicleInsurance.Models
{
    public class Account
    {
        public Account()
        {
            this.CreatedAt = DateTime.Today;
            this.UpdatedAt = DateTime.Today;
            this.Status = 1;
            this.Salt = new byte[128 / 8];
            this.Password = "a";
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(this.Salt);
            }
        }

        public void EncryptPassword(string password)
        {
            this.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: this.Salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
        }
        [Key]
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }

        public Customer Customer { get; set; }
    }
}
