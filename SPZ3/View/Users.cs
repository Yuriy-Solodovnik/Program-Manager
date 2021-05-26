using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{
    public class Users
    {
        string _Name;
        string _Password;
        public List<Programs> PRR = new List<Programs>();
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == "")
                    _Name = "User";
                else
                    _Name = value;
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (value == "")
                    _Password = "12345678";
                else
                    _Password = value;
            }
        }
        public Programs PR
        {
            set
            {
                if (value == null)
                    PRR.Add(new Programs());
                else
                    PRR.Add(value);
            }
        }
        public int getSize()
        {
            return PRR.Count;
        }
        public string CheckPassword (string pass)
        {
            if (pass == _Password)
                return _Password;
            else
                return null;
        }
        public static bool operator <(Users u1, Users u2)
        {
            return u1.getSize() < u2.getSize();
        }
        public static bool operator  >(Users u1, Users u2)
        {
            return u1.getSize() > u2.getSize();
        }
        public static bool operator ==(Users u1, Users u2)
        {
            return u1.getSize() == u2.getSize();
        }
        public static bool operator !=(Users u1, Users u2)
        {
            return u1.getSize() != u2.getSize();
        }
    }
}
