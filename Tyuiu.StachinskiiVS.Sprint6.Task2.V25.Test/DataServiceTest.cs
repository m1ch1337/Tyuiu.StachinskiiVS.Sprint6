using Tyuiu.StachinskiiVS.Sprint6.Task2.V25.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = new double[11];

            for (int i = 0; i < 11; i++)
            {
                int x = start + i;
                double denominator = Math.Sin(x) - 2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    wait[i] = 0;
                }
                else
                {
                    wait[i] = Math.Round((5 * x + 2.5) / denominator + 2, 2);
                }
            }

            CollectionAssert.AreEqual(wait, res);
        }
    }
}