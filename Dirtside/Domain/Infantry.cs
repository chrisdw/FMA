using System;
using System.Collections.Generic;
using System.Text;

namespace org.DownesWard.FMA.Dirtside.Domain
{
    public class Infantry
    {
        public Int32 InfantryId { get; set; }
        public String Description { get; set; }
        public Int32 Size { get; set; }
        public Int32 CampaignId { get; set; }
        public Int32 Nationality { get; set; }
        public String Notes { get; set; }
        public float Cost { get; set; }
        public Int32 PersonnelCount { get; set; }
        public Boolean ArtilleryObserver { get; set; }
        public Boolean Engineering { get; set; }
        public Boolean Flying { get; set; }
        public Boolean Teleport { get; set; }
        public Boolean IAVR { get; set; }
        public Boolean LAD { get; set; }
        public Boolean Biological { get; set; }
        public Int32 InfantryMovementId { get; set; }
        public Int32 InfantryFPId { get; set; }
        public Int32 InfantryHTKId { get; set; }
        public Int32 InfantryRangeId { get; set; }
        public String WeaponTypeId { get; set; }
        public String WeaponSizeId { get; set; }
        public String WeaponGuidanceId { get; set; }
    }
}
