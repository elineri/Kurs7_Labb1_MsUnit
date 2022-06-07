using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs7_Labb1_MsUnit;
using System;
using System.Collections.Generic;

namespace Kurs7_Labb1_MsUnit.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [Description("This test checks that a user can't log in if the userID doesn't exist in the system")]
        [Owner("Elin Ericstam")]
        [TestCategory("Login")]
        public void CheckUserName_InputID_123455_Return_False()
        {
            // Arrange
            Customer testCustomer = new Customer("123456", "Elin Test", "Password123");
            List<User> testUsers = new List<User>();
            testUsers.Add(testCustomer);

            // Act
            var result = User.CheckUserName(testUsers, "123455");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Description("This test checks that a user can log in if the userID exist in the system")]
        [Owner("Elin Ericstam")]
        [TestCategory("Login")]
        public void CheckUserName_InputID_123456_Return_True()
        {
            // Arrange
            Customer testCustomer = new Customer("123456", "Elin Test", "Password123");
            List<User> testUsers = new List<User>();
            testUsers.Add(testCustomer);

            // Act
            var result = User.CheckUserName(testUsers, "123456");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Description("This test checks that null is returned (can't log in) when password is incorrect even though the user exists" +
            " in the system.")]
        [Owner("Elin Ericstam")]
        [TestCategory("Login")]
        public void CheckPassword_UserId_123456_And_Password_Password122_Return_Null()
        {
            // Arrange
            Customer testCustomer = new Customer("123456", "Elin Test", "Password123");
            List<User> testUsers = new List<User>();
            testUsers.Add(testCustomer);

            // Act

            var result = User.CheckPassword(testUsers, "123456", "Password122");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        [Description("This test checks that the given user is returned (can log in) when the correct password which is matching with " +
            "the user when trying to log in.")]
        [Owner("Elin Ericstam")]
        [TestCategory("Login")]
        public void CheckPassword_UserId_123456_And_Password_Password123_Return_testCustomer()
        {
            // Arrange
            Customer testCustomer = new Customer("123456", "Elin Test", "Password123");
            List<User> testUsers = new List<User>();
            testUsers.Add(testCustomer);
            var expected = testCustomer;

            // Act

            var actual = User.CheckPassword(testUsers, "123456", "Password123");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
