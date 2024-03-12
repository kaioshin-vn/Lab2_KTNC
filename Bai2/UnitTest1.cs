namespace Bai2
{
    public class Tich
    {
        public int tinhTich(int a, int b)
        {
            if(a == int.MinValue || b == int.MinValue)
            {
                return 0;
            }
            if (a == int.MaxValue || b == int.MaxValue)
            {
                if(a != 0 && a != 1 || b != 0 && b != 1)
                return 0;
            }
            return a * b;
        }
    }
    public class Tests
    {
        Tich tich;
        [SetUp]
        public void Setup()
        {
            tich = new Tich();
        }

        [Test]
        public void testVungBien1()
        {
            Assert.That(tich.tinhTich(1, 7), Is.EqualTo(7));
        }

        [Test]
        public void testVungBien2()
        {
            Assert.That(tich.tinhTich(2, 8), Is.EqualTo(16));
        }

        [Test]
        public void testVungBien3()
        {
            Assert.That(tich.tinhTich(0, 9), Is.EqualTo(0));
        }

        [Test]
        public void testVungBien4()
        {
            Assert.That(tich.tinhTich(2, 6), Is.EqualTo(12));
        }

        [Test]
        public void testVungBien5()
        {
            Assert.That(tich.tinhTich(1, 9), Is.EqualTo(9));
        }

    

    }
}