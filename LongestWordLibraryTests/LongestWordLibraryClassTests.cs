using System;
using LongestWordLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWordLibraryTests
{
    [TestClass]
    public class LongestWordLibraryClassTests
    {
        //Проверка на пустую строку
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
        //Проверка на наличие самого длинного слова в русском тексте
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
        //Проверка на наличие самого длинного слова в английском тексте
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
    }
}
