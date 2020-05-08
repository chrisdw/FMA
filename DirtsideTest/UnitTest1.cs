using NUnit.Framework;

namespace DirtsideTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetWeapons();
        }

        [Test]
        public void Test2()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetWeaponSizes("HEL");
        }

        [Test]
        public void Test3()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetFireControl();
        }

        [Test]
        public void Test4()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetArmour();
        }

        [Test]
        public void Test5()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetArmour(7);
        }

        [Test]
        public void Test6()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetInfantry();
        }

        [Test]
        public void Test7()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetInfantry(7);
        }

        [Test]
        public void Test8()
        {
            var db = new org.DownesWard.FMA.Dirtside.DatabaseHelper();
            var res = db.GetInfantryForCampaignNationality(1, 1);
        }
    }
}