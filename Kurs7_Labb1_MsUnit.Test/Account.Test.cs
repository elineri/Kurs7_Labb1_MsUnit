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
        [Description("This test is to check that more money than what's available in the account can't be withdrawn")]
        [Owner("Elin Ericstam")]
        [TestCategory("Withdrawal")]
        public void EnoughBalance_1000m_Return_False()
        {
            // Arrange
            Account testAccount = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");

            // Act
            var result = testAccount.EnoughBalance(1001m);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Description("This test checks that money is added to the new account when making a transfer")]
        [Owner("Elin Ericstam")]
        [TestCategory("Transfer money")]
        public void MakeTransfer_100_testAccountTo_Return_1100m()
        {
            // Arrange
            Account testAccountFrom = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            Account testAccountTo = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            var expected = 1100m;

            // Act
            testAccountFrom.MakeTransfer(100m, testAccountTo);
            var actual = testAccountTo._balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("This test checks that money is withdrawn from the account when making a transfer")]
        [Owner("Elin Ericstam")]
        [TestCategory("Transfer money")]
        public void MakeTransfer_100_testAccountFrom_Return_900m()
        {
            // Arrange
            Account testAccountFrom = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            Account testAccountTo = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            var expected = 900m;

            // Act
            testAccountFrom.MakeTransfer(100m, testAccountTo);
            var actual = testAccountFrom._balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
