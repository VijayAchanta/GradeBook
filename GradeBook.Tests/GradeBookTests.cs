using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Tests
{
    /// <summary>
    /// Summary description for GradeBookTests
    /// </summary>
    [TestClass]
    public class GradeBookTests
    {
        public GradeBookTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ComputeHighestGrade()
        {
            //
            // TODO: Add test logic here
            //
            GradeBook book = new GradeBook();
            book.AddGrade(70);
            book.AddGrade(80);
            book.AddGrade(90);
            Assert.AreEqual(90, book.ComputeStatistics().HighestGrade);
        }
        [TestMethod]
        public void ComputeLowestGrade()
        {
            //
            // TODO: Add test logic here
            //
            GradeBook book = new GradeBook();
            book.AddGrade(70);
            book.AddGrade(80);
            book.AddGrade(90);
            Assert.AreEqual(70, book.ComputeStatistics().LowestGrade);
        }
        [TestMethod]
        public void ComputeAverageGrade()
        {
            //
            // TODO: Add test logic here
            //
            GradeBook book = new GradeBook();
            book.AddGrade(70);
            book.AddGrade(80);
            book.AddGrade(90);
            Assert.AreEqual(80, book.ComputeStatistics().AverageGrade);
        }

    }
}
