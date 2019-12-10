using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputHelperLibrary;
using System.Linq;
using System;

namespace RobotCrosswordSolverTests
{
    [TestClass]
    public class InputLineTests
    {
        [TestMethod]
        public void TestGetRow_GetTotal()
        {
            var testInput = "1 1";

            var result = InputLine.GetRow(testInput);

            Assert.AreEqual(1, result.Total);
        }

        [TestMethod]
        public void TestGetRow_GetOneCellValue()
        {
            var testInput = "1 1";

            var result = InputLine.GetRow(testInput);

            Assert.AreEqual(1, result.Cells.First().Value);
        }

        [TestMethod]
        public void TestGetRow_GetNullTotal()
        {
            var testInput = "1";

            var result = InputLine.GetRow(testInput);

            Assert.IsFalse(result.Total.HasValue);
        }

        [TestMethod]
        public void TestGetRow_GetSeveralCellValues()
        {
            var testInput = "12 1";

            var result = InputLine.GetRow(testInput);

            Assert.AreEqual(2, result.Cells.Count());
        }

        [TestMethod]
        public void TestGetRow_NullInput()
        {
            var testInput = "";

            Assert.ThrowsException<ArgumentNullException>(() => InputLine.GetRow(testInput));
        }
    }
}
