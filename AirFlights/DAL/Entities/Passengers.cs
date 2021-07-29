using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class Passengers : BaseClass
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PassportNumber { get; set; }

        
        [MaxLength(3)]
        public string LuggageKG { get; set; }

        public Flights FlightsId { get; set; }

    }
}
