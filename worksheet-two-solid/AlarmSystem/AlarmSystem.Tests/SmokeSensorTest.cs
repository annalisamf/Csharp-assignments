using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class SmokeSensorTest
    {
        [TestMethod]
        public void TestThatIsTriggeredReturnsFalse()
        {
            SmokeSensor sensor = FactoryMethod.CreateSmokeSensor();
            bool isTriggered = sensor.IsTriggered;
            Assert.AreEqual(false, isTriggered);
        }

        [TestMethod]
        public void TestThatGetLocationReturnsNull()
        {
            SmokeSensor sensor = FactoryMethod.CreateSmokeSensor();
            string location = sensor.GetLocation();
            Assert.AreEqual(string.Empty, location);
        }

        [TestMethod]
        public void TestThatGetSensorTypeReturnsNull()
        {
            SmokeSensor sensor = FactoryMethod.CreateSmokeSensor();
            string sensorType = sensor.GetSensorType();
            Assert.AreEqual(string.Empty, sensorType);
        }

        [TestMethod]
        public void TestThatGetBatteryPercentageReturnsNegativeOne()
        {
            SmokeSensor sensor = FactoryMethod.CreateSmokeSensor();
            double batteryPercentage = sensor.GetBatteryPercentage();
            Assert.AreEqual(-1.0, batteryPercentage);
        }
    }
}
