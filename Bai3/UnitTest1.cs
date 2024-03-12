namespace Bai3
{
    public class GiaiThua
    {
        public int TinhGiaiThua (int n)
        {
            try
            {
                if (n < 0)
                {
                    return -1;
                }
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
             catch (Exception e)
            {
                return -1;
            }
            
        }
}
    public class Tests
    {
        GiaiThua giaiThua;
        [SetUp]
        public void Setup()
        {
            giaiThua = new GiaiThua();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}