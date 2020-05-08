using org.DownesWard.FMA.Dirtside.Domain;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace org.DownesWard.FMA.Dirtside
{
    public class DatabaseHelper
    {
        SQLiteConnection db;

       public DatabaseHelper()
        {
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "toe.db");

            db = new SQLiteConnection(databasePath);
        }

        public IEnumerable<Domain.Weapon> GetWeapons()
        {
            return db.Query<Weapon>("SELECT WeaponType, Description FROM WeaponType ORDER BY WeaponType");
        }

        public IEnumerable<Domain.Weapon> GetWeaponSizes(String WeaponType)
        {
            return db.Query<Weapon>("SELECT WeaponSize FROM WeaponTypeSize WHERE WeaponType = ? ORDER BY WeaponSize", WeaponType );
        }

        public IEnumerable<Domain.FireControlSystem> GetFireControl()
        {
            return db.Query<FireControlSystem>("SELECT FireControl FROM FireControl ORDER BY Points");
        }

        public IEnumerable<Domain.Armour> GetArmour()
        {
            return db.Query<Armour>("SELECT ArmourTypeId, Description, Factor FROM Armour ORDER BY ArmourTypeId");
        }

        public IEnumerable<Domain.Armour> GetArmour(Int32 ArmourTypeId)
        {
            return db.Query<Armour>("SELECT ArmourTypeId, Description, Factor, ShortCode, Biological FROM Armour WHERE ArmourTypeId = ? ",  ArmourTypeId );
        }

        public IEnumerable<Domain.Infantry> GetInfantry()
        {
            return db.Query<Infantry>("SELECT InfantryId, Description FROM Infantry ORDER BY Description");
        }

        public IEnumerable<Domain.Infantry> GetInfantry(Int32 InfantryId)
        {
            return db.Query<Infantry>("SELECT InfantryId, Description, Size, CampaignId, Nationality, Notes, PersonnelCount, Cost, ArtilleryObserver, Flying, Engineering, Teleport, LAD, IAVR, Biological, InfantryMovementId, InfantryFPId, InfantryHTKId, InfantryRangeId, WeaponTypeId, WeaponSizeId, WeaponGuidanceId FROM Infantry WHERE InfantryId = ?", InfantryId);
        }

        public IEnumerable<Domain.Infantry> GetInfantryForCampaignNationality(Int32 CampaignId, Int32 NationalityID)
        {
            return db.Query<Infantry>("SELECT InfantryId, Description FROM Infantry WHERE campaignId = ? AND nationality = ? ORDER BY Description", CampaignId, NationalityID);
        }

        public IEnumerable<Domain.ECM> GetECM()
        {
            return db.Query<ECM>("SELECT Rating FROM ECM ORDER BY Cost");
        }

        public List<Domain.ECM> GetDieForECM(String ECMRating)
        {
            return db.Query<ECM>("SELECT Die FROM ECM WHERE Rating = ?", ECMRating);
        }
    }
}
