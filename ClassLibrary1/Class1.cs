using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int idrole;

        public static int Auth(string login, string password)
        {
            Authorization a = new Authorization();
            a.Auth(login, password);
            return idrole;
        }
    }
}
