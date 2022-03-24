using System.Security.Cryptography;
using System.Text;

namespace TestSonarQube
{
    public class CustomerLogic
    {
        private Customer customer;
        
        public CustomerLogic()
        {

        }

        public Customer Get()
        {
            return new Customer();
        }

        public int Insert(Customer c)
        {
            return 0;
        }

        private Customer VeryBadLogic()
        {
            var test = false;
            string nice = "http://test.com";
            int counter = 1;   
	    int test = 2;
            string hashedNice = Hash(nice);
            
            for(int i = 0; i < 10; i++)
            {
                customer = new Customer();
                for (int q = 0; q < 10; q++)
                {
                    if(DateTime.Now > DateTime.MaxValue)
                    {
                        nice = nice + "ff";
                        customer = new Customer();
                        test = true;
                        counter = -6;
                    }
                    else
                    {
                        if(DateTime.Now > DateTime.MinValue)
                        {
                            nice = "ff" + "asdfas" + DateTime.Now;
                        }
                        test = false;
                    }
                }

                for (int q = 0; q < 10; q++)
                {
                    if (DateTime.Now > DateTime.MaxValue)
                    {
                        nice = nice + "ff";
                        customer = new Customer();
                        test = true;
                    }
                    else
                    {
                        if (DateTime.Now > DateTime.MinValue)
                        {
                            nice = "ff" + "asdfas" + DateTime.Now;
                        }
                        test = false;
                    }
                }


                for (int q = 0; q < 10; q++)
                {
                    for (int f = 0; f < 10; q++)
                    {
                        if (DateTime.Now > DateTime.MaxValue)
                        {
                            nice = nice + "ff";
                            customer = new Customer();
                            test = true;
                        }
                        else
                        {
                            if (DateTime.Now > DateTime.MinValue)
                            {
                                nice = "ff" + "asdfas" + DateTime.Now;
                            }
                            test = false;
                        }
                    }

                    if (DateTime.Now > DateTime.MaxValue)
                    {
                        nice = nice + "ff";
                        customer = new Customer();
                        test = true;
                    }
                    else
                    {
                        if (DateTime.Now > DateTime.MinValue)
                        {
                            nice = "ff" + "asdfas" + DateTime.Now;
                        }
                        test = false;
                    }
                }
            }

            return new Customer();
        }

        private void UnusedLogic()
        {

        }

        private async Task<object> TestAsync()
        {
            return 0;
        }

        override
        public string ToString()

        {
            return null;
        }

        public string Hash(string password)
        {
            var salt = Encoding.UTF8.GetBytes("Hardcoded salt");
            var fromHardcoded = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, salt is hardcoded

            salt = Encoding.UTF8.GetBytes(password);
            var fromPassword = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, password should not be used as a salt as it makes it predictable

            var shortSalt = new byte[8];
            RandomNumberGenerator.Create().GetBytes(shortSalt);
            var fromShort = new Rfc2898DeriveBytes(password, shortSalt);   // Noncompliant, salt is too short (should be at least 16 bytes, not 8)

            return fromShort.ToString();
        }


        public string Hash2f(string password)
        {
            var salt = Encoding.UTF8.GetBytes("Hardcoded salt");
            var fromHardcoded = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, salt is hardcoded

            salt = Encoding.UTF8.GetBytes(password);
            var fromPassword = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, password should not be used as a salt as it makes it predictable

            var shortSalt = new byte[8];
            RandomNumberGenerator.Create().GetBytes(shortSalt);
            var fromShort = new Rfc2898DeriveBytes(password, shortSalt);   // Noncompliant, salt is too short (should be at least 16 bytes, not 8)

            return fromShort.ToString();
        }

        public string Hash2fff(string password)
        {
            var salt = Encoding.UTF8.GetBytes("Hardcoded salt");
            var fromHardcoded = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, salt is hardcoded

            salt = Encoding.UTF8.GetBytes(password);
            var fromPassword = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, password should not be used as a salt as it makes it predictable

            var shortSalt = new byte[8];
            RandomNumberGenerator.Create().GetBytes(shortSalt);
            var fromShort = new Rfc2898DeriveBytes(password, shortSalt);   // Noncompliant, salt is too short (should be at least 16 bytes, not 8)

            return fromShort.ToString();
        }
        //private Customer VeryBadLogic()
        //{

        //            return new Customer();
        //      }

    }
}
