using Tyuiu.StachinskiiVS.Sprint6.Task7.V25.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V25.csv");

            string testData = "1;2;3;4;5;6;7;8;9;10\n11;12;13;14;15;16;17;18;19;20\n21;22;23;24;25;26;27;28;29;30";
            File.WriteAllText(path, testData);

            int[,] res = ds.GetMatrix(path);
            int[,] wait = new int[3, 10];

            wait[0, 0] = 1; wait[0, 1] = 2; wait[0, 2] = 3; wait[0, 3] = 4; wait[0, 4] = 5;
            wait[0, 5] = 6; wait[0, 6] = 2; wait[0, 7] = 8; wait[0, 8] = 9; wait[0, 9] = 10;
            wait[1, 0] = 11; wait[1, 1] = 12; wait[1, 2] = 13; wait[1, 3] = 14; wait[1, 4] = 15;
            wait[1, 5] = 16; wait[1, 6] = 2; wait[1, 7] = 18; wait[1, 8] = 19; wait[1, 9] = 20;
            wait[2, 0] = 21; wait[2, 1] = 22; wait[2, 2] = 23; wait[2, 3] = 24; wait[2, 4] = 25;
            wait[2, 5] = 26; wait[2, 6] = 2; wait[2, 7] = 28; wait[2, 8] = 29; wait[2, 9] = 30;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V25.csv");

            string testData = "10;20;30;40;50;60;70;80;90;100";
            File.WriteAllText(path, testData);

            int[,] res = ds.GetMatrix(path);

            Assert.AreEqual(2, res[0, 6]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V25.csv");

            string testData = "3;6;9;12;15;18;21;24;27;30";
            File.WriteAllText(path, testData);

            int[,] res = ds.GetMatrix(path);

            Assert.AreEqual(2, res[0, 6]);
        }
    }
}