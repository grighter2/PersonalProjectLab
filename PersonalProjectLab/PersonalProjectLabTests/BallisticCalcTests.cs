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
            decimal deflection = calcs.Windage(755, 15);
            //asserting
            Assert.AreEqual(8.7115m, deflection);
        }
        public void Elevation()
        {
            //arrange

            //act

            //asseting

        }
    }
}
