using Tyuiu.StachinskiiVS.Sprint6.Task5.V14.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask5V14.txt");

            string testData = "5.6 12.3 8.9 15.7 3.2 20.1 10.0 7.4 18.5 25.3";
            File.WriteAllText(path, testData);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 5.6, 12.3, 8.9, 15.7, 3.2, 20.1, 10.0, 7.4, 18.5, 25.3 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask5V14.txt");

            string testData = "1.234 2.567 3.891 4.123 5.456";
            File.WriteAllText(path, testData);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 1.234, 2.567, 3.891, 4.123, 5.456 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask5V14.txt");

            string testData = "10.5 20.3 30.7";
            File.WriteAllText(path, testData);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 10.5, 20.3, 30.7 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}