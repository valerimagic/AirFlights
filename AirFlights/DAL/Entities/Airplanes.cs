using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Airplanes : BaseClass
    {
        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string SerialNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string CompanyOwner { get; set; }


    }
}
