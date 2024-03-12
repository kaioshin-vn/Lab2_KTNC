namespace Bai3
{
    public class GiaiThua
    {
        public int TinhGiaiThua (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            } 
            return result;

        }
}
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}