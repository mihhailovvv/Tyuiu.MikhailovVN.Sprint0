
using Tyuiu.MikhailovVN.Sprint0.Task5.V0.Lib;
namespace Tyuiu.MikhailovVN.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalVolid()
        {
            Assert.AreEqual(10, DataService.Additional(5, 5));
        }
        public void CheckedSubtractionVolid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        public void CheckedMultiplication()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionVolid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}
