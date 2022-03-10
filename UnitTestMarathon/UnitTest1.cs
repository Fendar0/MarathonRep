using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Marathon;

namespace UnitTestMarathon
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Проверка авторизации как бегун
        /// </summary>
        [TestMethod]
        public void TestMethodRunner()
        {
            string login = "1";
            string password = "1";
            int expected = 1;

            Authorization auth = new Authorization();
            int res = auth.Auth(login, password);
            
            Assert.AreEqual(res, expected);
        }

        /// <summary>
        /// Проверка авторизации как спонсор
        /// </summary>
        [TestMethod]
        public void TestMethodSponsor()
        {
            string login = "2";
            string password = "2";
            int expected = 2;

            Authorization auth = new Authorization();
            int res = auth.Auth(login, password);

            Assert.AreEqual(res, expected);
        }

        /// <summary>
        /// Проверка авторизации как администратор
        /// </summary>
        [TestMethod]
        public void TestMethodAdminstrator()
        {
            string login = "3";
            string password = "3";
            int expected = 3;

            Authorization auth = new Authorization();
            int res = auth.Auth(login, password);

            Assert.AreEqual(res, expected);
        }

        /// <summary>
        /// Пользователь существует
        /// </summary>
        [TestMethod]
        public void UserExists()
        {
            string login = "2@mail.ru";
            string password = "222";
            int expected = 1;

            WorkAccount wa = new WorkAccount();
            int res = wa.Exists(login, password);

            Assert.AreEqual(res, expected, "This user already exists");
        }

        /// <summary>
        /// Пользователя не существует
        /// </summary>
        [TestMethod]
        public void UserNotExists()
        {
            string login = "232@mail.ru";
            string password = "232";
            int expected = 0;

            WorkAccount wa = new WorkAccount();
            int res = wa.Exists(login, password);

            Assert.AreEqual(res, expected, "This user not already exists");
        }

        /// <summary>
        /// Поле Логина не заполнено
        /// </summary>
        [TestMethod]
        public void LoginIsNullable()
        {
            string login = "";

            WorkAccount wa = new WorkAccount();
            bool res = Convert.ToBoolean(wa.NullableLog(login));

            Assert.IsTrue(res, "Field login not filled");
        }

        /// <summary>
        /// Поле логина заполнено
        /// </summary>
        [TestMethod]
        public void LoginIsFilled()
        {
            string login = "3@mail.ru";

            WorkAccount wa = new WorkAccount();
            bool res = Convert.ToBoolean(wa.NullableLog(login));

            Assert.IsFalse(res, "Field login filled");
        }

        /// <summary>
        /// Поле пароля не заполнено
        /// </summary>
        [TestMethod]
        public void PasswordIsNullable()
        {
            string password = "";

            WorkAccount wa = new WorkAccount();
            bool res = Convert.ToBoolean(wa.NullablePass(password));

            Assert.IsTrue(res, "Field password not filled");
        }

        /// <summary>
        /// Поле пароля заполнено
        /// </summary>
        [TestMethod]
        public void PasswordIsFilled()
        {
            string password = "3@mail.ru";

            WorkAccount wa = new WorkAccount();
            bool res = Convert.ToBoolean(wa.NullablePass(password));

            Assert.IsFalse(res, "Field password filled");
        }
    }
}
