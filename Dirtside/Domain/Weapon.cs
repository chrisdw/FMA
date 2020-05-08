using System;
using System.Collections.Generic;
using System.Text;

namespace org.DownesWard.FMA.Dirtside.Domain
{
    public class Weapon
    {
        public const String GUIDED_MISSILE = "GMS";
	    public const String HIGH_VELOCITY_MISSILE = "HVMS";
        public const String SLAM = "SLAM";
        public const String IAVR = "IAVR";
        public const String APSW = "APSW";
        public const String HIGH_ENERGY_LASER = "HEL";
        public const String POWER_GUN = "PNG";

        public String WeaponType { get; set; }
        public String WeaponSize { get; set; }
        public String Description { get; set; }
        public Boolean EngeryUsing { get; set; }
        public Int32 Points { get; set; }
        public Boolean Biological { get; set; }

        public String LongName
        {
            get
            {
                return WeaponType + "(" + Description + ")";
            }
        }

        public String Name
        {
            get
            {
                return WeaponType + "/" + WeaponSize;
            }
        }

        public Int32 EffectiveSize()
        {
            if (this.WeaponType.Equals(GUIDED_MISSILE)
                    || this.WeaponType.Equals(HIGH_VELOCITY_MISSILE))
            {
                if (this.WeaponSize.Equals("L"))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
            else
            {
                return Int32.Parse(this.WeaponSize);
            }
        }
    }
}
