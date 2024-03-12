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
			Assert.AreEqual(5, _sumT.Tong(4, 1));
		}

		[Test]
		public void TestTuongDuong5()
		{
			Assert.AreEqual(5, _sumT.Tong(4, 1));
		}
		[Test]
		public void TestTuongDuong4()
		{
			Assert.AreEqual(10, _sumT.Tong(6, 4));
		}
		[Test]
		public void TestTuongDuong3()
		{
			Assert.AreEqual(6, _sumT.Tong(3, 3));
		}
		[Test]
		public void TestTuongDuong2()
		{
			Assert.AreEqual(5, _sumT.Tong(3, 2));
		}
		[Test]
		public void TestBien1()
		{
			Assert.AreEqual(1, _sumT.Tong(0, 1));
		}
		[Test]
		public void TestBien2()
		{
			Assert.AreEqual(-1, _sumT.Tong(0, -1));
		}
		[Test]
		public void TestBien3()
		{
			Assert.AreEqual(10, _sumT.Tong(9, 1));
		}
		[Test]
		public void TestBien4()
		{
			Assert.AreEqual(10, _sumT.Tong(11, -1));
		}
		[Test]
		public void TestBien5()
		{
			Assert.AreEqual(8, _sumT.Tong(-1, 9));
		}
	}
}