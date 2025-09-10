using Tyuiu.ZakachurinIE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZakachurinIE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChechGetMessageValid()
        {
            var name = "Иван";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Иван", res);
        }
    }
}
