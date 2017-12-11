using System;
using PizzaStore.Library.Models;
using Xunit;

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
            //Given
            var result = _primeService.IsPrime(1);

            //When
            Assert.False(result, "1 should not be prime");

            //Then

        }
    }
}
