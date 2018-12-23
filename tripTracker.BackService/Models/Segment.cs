using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tripTracker.BackService.Models
{
    public class Segment
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


    }
}
