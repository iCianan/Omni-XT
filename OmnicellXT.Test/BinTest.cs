using NUnit.Framework;
using System;

namespace OmnicellXT.Test
{
    public class Tests
    {

        [Test]
        public void SmallBinShouldHaveACapacityOfFiveUnits()
        {
            AppUser appUser = new AppUser { UserId = 0, UserName = "Tester" };

            Cabinet LansingCabinet = new Cabinet(appUser);

            Assert.That(LansingCabinet.SmallBin.UnitCapacity, Is.EqualTo(5));
        }        

        [Test]
        public void SmallBinShouldHaveATotalCapacityOfFifteenUnits()
        {
            AppUser appUser = new AppUser { UserId = 0, UserName = "Tester" };

            Cabinet sut = new Cabinet(appUser);

            Assert.That(sut.SmallBin.UnitCapacity * sut.SmallBin.NumberOfUnits, Is.EqualTo(15));
        }        
        
        [Test]
        public void SmallBinShouldDisplayCapacityMessageIfFull()
        {
            AppUser appUser = new AppUser { UserId = 0, UserName = "Tester" };

            Cabinet sut = new Cabinet(appUser);
            for (int i = 0; i < 15; i++)
            {
                sut.SmallBin.AddMedicationUnit(i.ToString());
            }

            var ex = Assert.Throws<InvalidOperationException>(
                () => sut.SmallBin.AddMedicationUnit("15"));

            Assert.That(ex.Message, Is.EqualTo("Bin is full, please remove an item and try again"));
        }
    }
}