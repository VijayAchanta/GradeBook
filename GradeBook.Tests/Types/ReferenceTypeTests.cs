using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseAString()
        {
            string name = "vijay";
            name = name.ToUpper();

            Assert.AreEqual("VIJAY", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 09, 05);
            date= date.AddDays(1);

            Assert.AreEqual(6, date.Day);
        }
        [TestMethod]
        public void ValueTypesByValue()
        {
            int x1 = 100;
            IncrementNumber(x1);
            Assert.AreEqual(100, x1);
        }

        private void IncrementNumber(int x2)
        {
            x2 = +1;
        }

        [TestMethod]
        public void ReferenceTypesByValue()
        {
            GradeBook b1 = new GradeBook();
            GradeBook b2 = b1;

            GiveBookAName(b1);
            Assert.AreEqual("Vijay's grade book", b2.Name);
        }
        private void GiveBookAName(GradeBook gb)
        {
            gb.Name = "Vijay's grade book";
        }
        [TestMethod]
        public void StringComparisons()
        {
            string s1 = "Vijay";
            string s2 = "vijay";

            bool result = String.Equals(s1, s2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 200;
            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradeBookHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Vijay's Grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
