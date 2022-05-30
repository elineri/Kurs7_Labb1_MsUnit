using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs7_Labb1_MsUnit;
using System;
using System.Collections.Generic;

namespace Kurs7_Labb1_MsUnit.Test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //[Description("This test is about checking that the method doesn't withdraw money when there aren't enought balance in the account.")]
        //[Owner("Elin Ericstam")]
        //[TestCategory("Withdraw money")]
        //public void Withdraw_Customer_444444_Return_X()
        //{
        //    // Arrange
        //    Customer testCustomer = new Customer("444444", "Gillian Brown", "password") {};
            

        //    // Act
        //    Bank.Withdraw(testCustomer);

        //    // Assert
        //}

        //[TestMethod]
        //[Description("")]
        //[Owner("Elin Ericstam")]
        //[TestCategory("Login")]
        //public void Login_User_444444_Password_password_Return_True()
        //{
        //    // Arrange
        //    string testUser = "444444";
        //    string testPassword = "password";
        //    bool expected = true;

        //    // Act
        //    var actual = Bank.Login(testUser, testPassword);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        [Description("This test is to check that ")]
        [Owner("Elin Ericstam")]
        [TestCategory("Withdrawal")]
        public void EnoughBalance_1000m_Return_False()
        {
            // Arrange
            Account testAccount = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444") {};
            var expected = false;

            // Act
            var actual = testAccount.EnoughBalance(1001m);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
