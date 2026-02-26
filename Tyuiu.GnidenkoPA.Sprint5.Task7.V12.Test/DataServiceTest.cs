using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GnidenkoPA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.GnidenkoPA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave_ValidFile_ReplacesLowercaseRussian()
        {
            // Создаём временный файл с тестовыми данными
            string tempDir = Path.GetTempPath();
            string inputFile = Path.Combine(tempDir, "TestInput.txt");
            string[] inputLines = {
                "Привет, мир!",
                "ёжик и Ёлка",
                "123 АБВГД"
            };
            File.WriteAllLines(inputFile, inputLines, Encoding.UTF8);

            // Ожидаемый результат после замены
            string[] expectedLines = {
                "ПРИВЕТ, МИР!",
                "ЁЖИК И ЁЛКА",
                "123 АБВГД"
            };

            DataService ds = new DataService();
            string outputFile = ds.LoadDataAndSave(inputFile);

            // Проверяем, что выходной файл существует
            Assert.IsTrue(File.Exists(outputFile));

            // Читаем результат
            string[] resultLines = File.ReadAllLines(outputFile, Encoding.UTF8);
            CollectionAssert.AreEqual(expectedLines, resultLines);

            // Очистка
            File.Delete(inputFile);
            File.Delete(outputFile);
        }

        [TestMethod]
        public void TestLoadDataAndSave_EmptyFile_ReturnsEmptyFile()
        {
            string tempDir = Path.GetTempPath();
            string inputFile = Path.Combine(tempDir, "TestEmpty.txt");
            File.WriteAllText(inputFile, "", Encoding.UTF8);

            DataService ds = new DataService();
            string outputFile = ds.LoadDataAndSave(inputFile);

            Assert.IsTrue(File.Exists(outputFile));
            string result = File.ReadAllText(outputFile, Encoding.UTF8);
            Assert.AreEqual("", result);

            File.Delete(inputFile);
            File.Delete(outputFile);
        }

    }
}