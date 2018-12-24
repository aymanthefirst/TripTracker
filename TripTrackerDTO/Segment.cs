using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerDTO
{
    public class Segment
    {

        public int Id { get; set; }

        [Required]
        public int TripId { get; set; }

        [Required]
        public string Name { get; set; }

        public string description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }


    }
}
