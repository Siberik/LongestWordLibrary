using System;
using LongestWordLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWordLibraryTests
{
    [TestClass]
    public class LongestWordLibraryClassTests
    {

        /// <summary>
        ///  Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void FindLongestWord_StringEmpty_ReturnedStringEmpty()
        {
            //Arrange
            string text = string.Empty;
            string excepted = string.Empty;
            //Act
            string actual = LongestWordLibraryClass.FindLongestWord(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка на наличие самого длинного слова в русском тексте
        /// </summary>
        [TestMethod]
        public void FindLongestWord_RuLongWond_ReturnedString()
        {
            //Arrange
            string text = "Папайя самая";
            string excepted = "папайя";
            //Act
            string actual = LongestWordLibraryClass.FindLongestWord(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка на наличие самого длинного слова в английском тексте
        /// </summary>
        [TestMethod]
        public void FindLongestWord_EngLongWord_ReturnedString()
        {
            //Arrange
            string text = "Hard Pneumonoultramicroscopicsilicovolcanokoniosis";
            string excepted = "pneumonoultramicroscopicsilicovolcanokoniosis";
            //Act
            string actual = LongestWordLibraryClass.FindLongestWord(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка слов с символами пунктуации
        /// </summary>
        [TestMethod]
        public void FindLongestWord_SpecialSymbols_ReturnedString()
        {
            //Arrange
            string text = "Ахахах! Смешно.Нонетнесмешно";
            string excepted = "нонетнесмешно";
            //Act
            string actual = LongestWordLibraryClass.FindLongestWord(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка на числа
        /// </summary>
        [TestMethod]
        public void FindLongestWord_Numbers_ReturnedString()
        {
            //Arrange
            string text = "3232442334";
            string excepted = string.Empty;
            //Act
            string actual = LongestWordLibraryClass.FindLongestWord(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
