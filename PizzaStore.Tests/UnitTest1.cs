using System;
using Xunit;
using PizzaStore.Library.Models;

namespace PizzaStore.Tests
{
    public class UnitTest1
    {
        private readonly Prime _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void Test1()
        {
            //Given/Arrange
            //create instance of subject - System Under Test
            var result = _primeService.IsPrime(1);


            //When/Act
            //execute the action
            Assert.False(result, "1 should not be prime");

            //Then/Assert
            //finally execute assert - expected vs actual
            //Test must be true in both cases, test should come out as true or false
            //positive if expectation match actuality
            //negative if expectation doesn't match actuality

        }
    }
}


/*
Unit Test
Tests one specific unit, unit testing is making sure it runs

     Arrange/Expectation
           create instance of subject - System Under Test

      Act/actuality
           execute the action

     Assert
            finally execute assert - expected vs actual
                 
                Test must be true in both cases, test should come out as true or false
                         positive if expectation match actuality

                         negative if expectation doesn't match actuality
*/