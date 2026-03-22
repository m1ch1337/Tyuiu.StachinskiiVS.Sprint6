namespace Tyuiu.StachinskiiVS.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix()
        {
            string filePath = @"C:\Users\stach\source\repos\Tyuiu.StachinksiiVS.Sprint6\Tyuiu.StachinksiiVS.Sprint6.Task7.V2\bin\Debug\InPutFileTask7V25.csv";

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}