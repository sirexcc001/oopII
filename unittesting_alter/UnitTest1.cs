using lab4_task1_alt;

namespace unittesting_alter
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void TestSatisfySedanForTakingTrip()
            {
            Trip trip = new Trip(Vehicletype.SEDAN, 20, 45, 3);
            Assert.IsTrue(trip.canTakeTrip());
        }


            [TestMethod]
            public void TestSatisfySevenSeaterForTakingTrip()
            {
                Trip trip = new Trip(Vehicletype.SEVENSEATER, 15, 30, 6);
                Assert.IsTrue(trip.canTakeTrip());
            }

            [TestMethod]
            public void TestSatisfyMotorbikeForTakingTrip()
            {
                Trip trip = new Trip(Vehicletype.MOTORBIKE, 10, 15, 1);
                Assert.IsTrue(trip.canTakeTrip());
            }

            [TestMethod]
            public void TestPerHeadFairCalculationForSevenSeater()
            {
                Trip trip = new Trip(Vehicletype.SEVENSEATER, 40, 40, 5);
                Assert.AreEqual(240, trip.perheadfare());
            }

            [TestMethod]
            public void TestPerHeadFairCalculationForMotorbike()
            {
                Trip trip = new Trip(Vehicletype.MOTORBIKE, 15, 20, 2);
                Assert.AreEqual(150, trip.perheadfare());
            }

            [TestMethod]
            public void TestPerHeadFairCalculationForSedan()
            {
                Trip trip = new Trip(Vehicletype.SEDAN, 25, 60, 4);
                Assert.AreEqual(230, trip.perheadfare());
            }
        }
}