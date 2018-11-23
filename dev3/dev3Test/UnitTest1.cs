using Microsoft.VisualStudio.TestTools.UnitTesting;
using dev3;

namespace dev3Test
{
    [TestClass]
    public class ConverterTests
    {
        SignConverter signConverter = new SignConverter();

        public bool ÑonvertIntegerToOtherSystem(int notation, int integer, string expected)
        {
            string result = signConverter.TotalRecordOfTheConvertedNumber(notation, integer);
            bool res = expected.Equals(result);
            return res;
        }

        [TestMethod]
        public void Ñonvert8To2System()
        {
            bool res = ÑonvertIntegerToOtherSystem(2, 8, "1000");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ÑonvertMinus8To2System()
        {
            bool res = ÑonvertIntegerToOtherSystem(2, -8, "-1000");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Ñonvert254To16System()
        {
            bool res = ÑonvertIntegerToOtherSystem(16, 254, "FE");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ÑonvertMinus254To16System()
        {
            bool res = ÑonvertIntegerToOtherSystem(16, -254, "-FE");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ÑonvertMaxIntValueTo2System()
        {
            bool res = ÑonvertIntegerToOtherSystem(2, int.MaxValue, "1111111111111111111111111111111");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ÑonvertMinusMaxIntValueTo16System()
        {
            bool res = ÑonvertIntegerToOtherSystem(16, -int.MaxValue, "-7FFFFFFF");
            Assert.IsTrue(res);
        }  
    }
}
