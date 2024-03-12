using NUnit.Framework.Internal;

namespace Bai3
{
	public class GiaiThua
	{
		public int TinhGiaiThua(int n)
		{
			try
			{
				if (n < 0|| n == int.MaxValue)
				{
					return -1;
				}
				int result = 1;
				for (int i = 1; i <= n; i++)
				{
					result *= i;
				}
				if (result == 0)
				{
					return -1;
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
		GiaiThua _giaiThua;
		[SetUp]
		public void Setup()
		{
			_giaiThua = new GiaiThua();
		}


		[Test]
		public void TC_Bien1()
		{
			Assert.That(_giaiThua.TinhGiaiThua(-1), Is.EqualTo(-1));
		}
		[Test]
		public void TC_Bien2()
		{
			Assert.That(_giaiThua.TinhGiaiThua(0), Is.EqualTo(1));
		}
		[Test]
		public void TC_Bien3()
		{
			Assert.That(_giaiThua.TinhGiaiThua(1), Is.EqualTo(1));
		}
		[Test]
		public void TC_Bien4()
		{
			Assert.That(_giaiThua.TinhGiaiThua(int.MaxValue - 1), Is.EqualTo(-1));
		}
		[Test]
		public void TC_Bien5()
		{
			Assert.That(_giaiThua.TinhGiaiThua(int.MaxValue), Is.EqualTo(-1));
		}
		[Test]
		public void TC_TuongDuong1()
		{
			Assert.That(_giaiThua.TinhGiaiThua(5), Is.EqualTo(120));
		}
		[Test]
		public void TC_TuongDuong2()
		{
			Assert.That(_giaiThua.TinhGiaiThua(-5), Is.EqualTo(-1));
		}
		[Test]
		public void TC_TuongDuong3()
		{
			Assert.That(_giaiThua.TinhGiaiThua(-75), Is.EqualTo(-1));
		}
		[Test]
		public void TC_TuongDuong4()
		{
			Assert.That(_giaiThua.TinhGiaiThua(665), Is.EqualTo(-1));
		}
		[Test]
		public void TC_TuongDuong5()
		{
			Assert.That(_giaiThua.TinhGiaiThua(10), Is.EqualTo(3628800));
		}
	}
}