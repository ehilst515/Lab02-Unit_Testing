using System;
using Xunit;
using UnitTesting;

namespace Lab02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalances_displays_balance_and_returns()
        {
            //Arange
            decimal balance = 100.00M;

            //Act
            decimal result = Program.ViewBalance(balance);

            //Assert
            decimal expected = balance;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Withdraw_reduces_balance()
        {
            //Arange
            decimal inBalance = 100.00M;
            decimal withdrawAmount = 25.00M;

            //Act
            decimal result = Program.Withdraw(withdrawAmount, inBalance);

            //Assert
            decimal expected = 75.00M;
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Deposit_increases_balance()
        {
            //Arange
            decimal inputBalance = 100.00M;
            decimal depositAmount = 50.00M;

            //Act
            decimal result = Program.Deposit(depositAmount, inputBalance);

            //Assert
            decimal expected = 150.00M;
            Assert.Equal(expected, result);
        }
    }
}
