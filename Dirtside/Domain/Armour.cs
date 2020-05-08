using System;
using System.Collections.Generic;
using System.Text;

namespace org.DownesWard.FMA.Dirtside.Domain
{
    public class Armour
    {
        public Int32 ArmourTypeId { get; set; }
        public String Description { get; set; }
        public float Factor { get; set;  }
        public String ShortCode { get; set; }
        public Boolean Biological { get; set; }
    }
}
