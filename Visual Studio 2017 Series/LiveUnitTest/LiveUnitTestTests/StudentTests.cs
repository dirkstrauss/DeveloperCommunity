using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUnitTest.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student _student;

        [TestInitialize]
        public void Setup()
        {
            _student = new Student();
            _student.FirstName = "John";
            _student.LastName = "Smith";
            _student.Grade = 80;
        }

        [TestMethod()]
        public void AdjustedGradeByPercentageTest()
        {
            double val = _student.AdjustedGradeByPercentage();
            Assert.IsTrue(_student.AdjustedGrade < 100);
        }
    }
}