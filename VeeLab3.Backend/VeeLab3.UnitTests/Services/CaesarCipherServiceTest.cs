using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeeLab3.Domain.Services.Implementation;
using VeeLab3.Domain.Services.Interfaces;

namespace VeeLab3.UnitTests.Services
{
    [TestClass]
    public class CaesarCipherServiceTest
    {
        private readonly ICaesarCipherService caesarCipherService;

        public CaesarCipherServiceTest()
        {
            caesarCipherService = new CaesarCipherService();
        }

        [TestMethod]
        public async Task EncryptAsync_WhenStringHaveOnlyLetters_ReturnsRightString()
        {
            // Arrange
            string str = "abcd";
            int key = 3;

            // Act
            string result = await caesarCipherService.EncryptAsync(str, key);

            // Assert
            string expected = "defg";
            Assert.AreEqual(expected, result, $"{result} is not equal {expected}");
        }

        [TestMethod]
        public async Task EncryptAsync_WhenStringIsUpperCase_ReturnsRightString()
        {
            // Arrange
            string str = "ABCD";
            int key = 3;

            // Act
            string result = await caesarCipherService.EncryptAsync(str, key);

            // Assert
            string expected = "DEFG";
            Assert.AreEqual(expected, result, $"{result} is not equal {expected}");
        }

        [TestMethod]
        public async Task EncryptAsync_WhenStringHaveSymbols_ReturnsRightString()
        {
            // Arrange
            string str = "!#%@";
            int key = 3;

            // Act
            string result = await caesarCipherService.EncryptAsync(str, key);

            // Assert
            string expected = "!#%@";
            Assert.AreEqual(expected, result, $"{result} is not equal {expected}");
        }

        [TestMethod]
        public async Task EncryptAsync_WhenStringHaveNumbers_ReturnsRightString()
        {
            // Arrange
            string str = "1234";
            int key = 3;

            // Act
            string result = await caesarCipherService.EncryptAsync(str, key);

            // Assert
            string expected = "1234";
            Assert.AreEqual(expected, result, $"{result} is not equal {expected}");
        }

        [TestMethod]
        public async Task EncryptAsync_WhenStringHaveZ_ReturnsStringWithA()
        {
            // Arrange
            string str = "zzz";
            int key = 1;

            // Act
            string result = await caesarCipherService.EncryptAsync(str, key);

            // Assert
            string expected = "aaa";
            Assert.AreEqual(expected, result, $"{result} is not equal {expected}");
        }
    }
}
