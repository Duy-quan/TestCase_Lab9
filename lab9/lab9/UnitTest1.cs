using StudentServiceLib;

namespace lab9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student s = new Student();
            s.Score = 8.85;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Student s = new Student();
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Student s = new Student();
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Student s = new Student();
            s.Score = 2;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}