namespace Bai4
{
    public class Login
    {
        public bool LoginAccount (string username, string password)
        {
            var db = new MyDbContext();
            return db.NhanViens.Any(a => a.SoDienThoai == username && a.MatKhau == password);
        }
    }
    public class Tests
    {
        Login _login;
        [SetUp]
        public void Setup()
        {
            _login = new Login();
        }

        [Test]
        public void Tc_TuongDuong1()
        {
            //Trường hợp nhập đúng tk , mk
            Assert.That(_login.LoginAccount("0978040960" , "1234") , Is.EqualTo(true));
        }
        [Test]
        public void Tc_TuongDuong2()
        {
            //Trường hợp nhập sai định dạng tk (sđt) 

            Assert.That(_login.LoginAccount("097804096011", "1234"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_TuongDuong3()
        {
            //Trường hợp nhập đúng tk , sai mk

            Assert.That(_login.LoginAccount("0978040960", "12345"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_TuongDuong4()
        {
            //Trường hợp nhập sai định dạng tk 

            Assert.That(_login.LoginAccount("353535", "123554"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_TuongDuong5()
        {
            //Trường hợp nhập sai tk , mk

            Assert.That(_login.LoginAccount("0974858585", "1"), Is.EqualTo(false));
        }

        [Test]
        public void Tc_Bien1()
        {
            //Trường hợp nhập bỏ trống tk(biên min ) 

            Assert.That(_login.LoginAccount("", "1234"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_Bien2()
        {
            //Trường hợp nhập tk 1 kí tự ( biên min + 1)

            Assert.That(_login.LoginAccount("1", "1234"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_Bien3()
        {
            //Trường hợp nhập tk đúng định dạng ( biên max)
            
            Assert.That(_login.LoginAccount("0978040960", "123"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_Bien4()
        {
            //Trường hợp nhập tk thừa 1 số  ( biên max + 1)

            Assert.That(_login.LoginAccount("09780409601", "1234"), Is.EqualTo(false));
        }
        [Test]
        public void Tc_Bien5()
        {
            //Trường hợp nhập bỏ trống mk(biên min ) 

            Assert.That(_login.LoginAccount("0978040960", ""), Is.EqualTo(false));
        }
    }
}