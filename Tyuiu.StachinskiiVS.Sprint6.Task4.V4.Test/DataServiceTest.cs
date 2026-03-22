using Tyuiu.StachinskiiVS.Sprint6.Task4.V4.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = Math.Round((2 * (-5) + 6) / (Math.Cos(-5) + (-5)) - 3, 2);
            valueWaitArray[1] = Math.Round((2 * (-4) + 6) / (Math.Cos(-4) + (-4)) - 3, 2);
            valueWaitArray[2] = Math.Round((2 * (-3) + 6) / (Math.Cos(-3) + (-3)) - 3, 2);
            valueWaitArray[3] = Math.Round((2 * (-2) + 6) / (Math.Cos(-2) + (-2)) - 3, 2);
            valueWaitArray[4] = Math.Round((2 * (-1) + 6) / (Math.Cos(-1) + (-1)) - 3, 2);
            valueWaitArray[5] = Math.Round((2 * 0 + 6) / (Math.Cos(0) + 0) - 3, 2);
            valueWaitArray[6] = Math.Round((2 * 1 + 6) / (Math.Cos(1) + 1) - 3, 2);
            valueWaitArray[7] = Math.Round((2 * 2 + 6) / (Math.Cos(2) + 2) - 3, 2);
            valueWaitArray[8] = Math.Round((2 * 3 + 6) / (Math.Cos(3) + 3) - 3, 2);
            valueWaitArray[9] = Math.Round((2 * 4 + 6) / (Math.Cos(4) + 4) - 3, 2);
            valueWaitArray[10] = Math.Round((2 * 5 + 6) / (Math.Cos(5) + 5) - 3, 2);

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}