using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class BallisticCalcTests
    {
        [TestMethod]
        public void Windage()
        {
            //arrange
            BallisticCalcsWindage calcs = new BallisticCalcsWindage();
            //act
            decimal deflection = calcs.Windage(400, 5);
            //asserting
            Assert.AreEqual(5.333m, deflection);
        }
        [TestMethod]
        public void Elevation()
        {
            //arrange
            BallisticCalcsElevation calculations = new BallisticCalcsElevation();
            //act
            decimal elevation = calculations.Elevation(1000, 3000, 0);
            //asseting
            Assert.AreEqual(-193.045m, elevation);
        }
    }
}
