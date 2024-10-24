using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aafeben.Models
{
    public enum Lang {
        en, fr
    }

    public class OpportunityModel
    {
        public int Id {get; set;}
        public required string Job { get; set; }
        public required string Description { get; set; }
        public required string JobRequirements { get; set;}

        public required Lang Lang { get; set;}

        public required string JobType {get; set;}
        
    }
}