using Microsoft.VisualStudio.TestTools.UnitTesting;
using dev3;

namespace dev3Test
{
    [TestClass]
    public class ConverterTests
    {
        SignConverter signConverter = new SignConverter();

        public bool �onvertIntegerToOtherSystem(int notation, int integer, string expected)
        {
            string result = signConverter.TotalRecordOfTheConvertedNumber(notation, integer);
            bool res = expected.Equals(result);
            return res;
        }

        [TestMethod]
        public void �onvert8To2System()
        {
            bool res = �onvertIntegerToOtherSystem(2, 8, "1000");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void �onvertMinus8To2System()
        {
            bool res = �onvertIntegerToOtherSystem(2, -8, "-1000");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void �onvert254To16System()
        {
            bool res = �onvertIntegerToOtherSystem(16, 254, "FE");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void �onvertMinus254To16System()
        {
            bool res = �onvertIntegerToOtherSystem(16, -254, "-FE");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void �onvertMaxIntValueTo2System()
        {
            bool res = �onvertIntegerToOtherSystem(2, int.MaxValue, "1111111111111111111111111111111");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void �onvertMinusMaxIntValueTo16System()
        {
            bool res = �onvertIntegerToOtherSystem(16, -int.MaxValue, "-7FFFFFFF");
            Assert.IsTrue(res);
        }  
    }
}
