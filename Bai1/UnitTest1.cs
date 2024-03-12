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
			Assert.That(_sumT.Tong(8, 1), Is.EqualTo(9));
		}
		[Test]
		public void TestTuongDuong4()
		{
			Assert.That(_sumT.Tong(1, 6), Is.EqualTo(7));
		}
		[Test]
		public void TestTuongDuong3()
		{
			Assert.That(_sumT.Tong(9, 8), Is.EqualTo(17));
		}
		[Test]
		public void TestTuongDuong2()
		{
			Assert.That(_sumT.Tong(2, 1), Is.EqualTo(3));
		}
		[Test]
		public void TestBien1()
		{
			Assert.That(_sumT.Tong(5, 9), Is.EqualTo(14));
		}
		[Test]
		public void TestBien2()
		{
			Assert.That(_sumT.Tong(1, 5), Is.EqualTo(6));
		}
		[Test]
		public void TestBien3()
		{
			Assert.That(_sumT.Tong(9,2), Is.EqualTo(11));
		}
		[Test]
		public void TestBien4()
		{
			Assert.That(_sumT.Tong(7, 1), Is.EqualTo(8));
		}
		[Test]
		public void TestBien5()
		{
			Assert.That(_sumT.Tong(4, 9), Is.EqualTo(13));
		}
	}
}