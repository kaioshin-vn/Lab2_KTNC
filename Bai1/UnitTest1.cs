namespace Bai1
{
	public class Tong2So
	{
		public int Tong(int a, int b)
		{
			return a + b;
		}

	}
	[TestFixture]

	public class Tests
	{
		private Tong2So _sumT;
		[SetUp]
		public void Setup()
		{
			_sumT = new Tong2So();
		}

		[Test]
		public void TestTuongDuong1()
		{
			Assert.That(_sumT.Tong(4, 1), Is.EqualTo(5));
		}

		[Test]
		public void TestTuongDuong5()
		{
			Assert.That(_sumT.Tong(14, 1), Is.EqualTo(15));
		}
		[Test]
		public void TestTuongDuong4()
		{
			Assert.That(_sumT.Tong(6, 4), Is.EqualTo(10));
		}
		[Test]
		public void TestTuongDuong3()
		{
			Assert.That(_sumT.Tong(3, 3), Is.EqualTo(6));
		}
		[Test]
		public void TestTuongDuong2()
		{
			Assert.That(_sumT.Tong(3, 2), Is.EqualTo(5));
		}
		[Test]
		public void TestBien1()
		{
			Assert.That(_sumT.Tong(0, 1), Is.EqualTo(1));
		}
		[Test]
		public void TestBien2()
		{
			Assert.That(_sumT.Tong(0, -1), Is.EqualTo(-1));
		}
		[Test]
		public void TestBien3()
		{
			Assert.That(_sumT.Tong(9, 1), Is.EqualTo(10));
		}
		[Test]
		public void TestBien4()
		{
			Assert.That(_sumT.Tong(11, -1), Is.EqualTo(10));
		}
		[Test]
		public void TestBien5()
		{
			Assert.That(_sumT.Tong(-1, 9), Is.EqualTo(8));
		}
	}
}