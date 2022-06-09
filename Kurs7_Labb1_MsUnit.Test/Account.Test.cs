using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs7_Labb1_MsUnit;
using System;
using System.Collections.Generic;

namespace Kurs7_Labb1_MsUnit.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        [Description("This test is to check that more money than what's available in the account can't be withdrawn")]
        [Owner("Elin Ericstam")]
        [TestCategory("Withdrawal")]
        public void EnoughBalance_Withdraw_1000_Return_False()
        {
            // Arrange
            Account testAccount = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");

            // Act
            var result = testAccount.EnoughBalance(1001m);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Description("This test is to check that money are withdraw if there is enough balance in the account")]
        [Owner("Elin Ericstam")]
        [TestCategory("Withdrawal")]
        public void EnoughBalance_Withdraw_100_Return_True()
        {
            // Arrange
            Account testAccount = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");

            // Act
            var result = testAccount.EnoughBalance(100m);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Description("This test checks that money is added to the new account when making a transfer")]
        [Owner("Elin Ericstam")]
        [TestCategory("Transfer money")]
        public void MakeTransfer_TransferSum_100_Return_testAccountToBalance_1100m()
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
        public void MakeTransfer_TransferSum_100_Return_testAccountFromBalance_900m()
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

        [TestMethod]
        [Description("This test checks that money is added to the new account when making an external transfer")]
        [Owner("Elin Ericstam")]
        [TestCategory("Transfer money externally")]
        public void MakeExternalTransfer_TransferSum_100_Return_testAccountToBalance_1500m()
        {
            // Arrange
            Account testAccountFrom = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            Account testAccountTo = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            var expected = 1500m;

            // Act
            testAccountFrom.MakeExternalTransfer(500m, testAccountTo);
            var actual = testAccountTo._balance; 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("This test checks that money is withdrawn from the account when making an external transfer")]
        [Owner("Elin Ericstam")]
        [TestCategory("Transfer money externally")]
        public void MakeExternalTransfer_TransferSum_500_Return_testAccountToBalance_500m()
        {
            // Arrange
            Account testAccountFrom = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            Account testAccountTo = new Account("Test", "Test Account", "123456789", 1000m, "SEK", "444444");
            var expected = 500m;

            // Act
            testAccountFrom.MakeExternalTransfer(500m, testAccountTo);
            var actual = testAccountFrom._balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
