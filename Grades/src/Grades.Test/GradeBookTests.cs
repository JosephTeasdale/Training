using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
   public class GradeBookTests
    {
        [TestMethod]

        public void ComputesHighestGrade()
        {
            // Arrange

            Gradebook book = new Gradebook();
            book.AddGrade(17);
            book.AddGrade(89.5f);

            float expected = 89.5f;
            //Act

            Gradestatistics result = book.ComputeStatistics();

            //Assert
            Assert.AreEqual(expected, result.HighestGrade);

        }

        [TestMethod]

        public void ComputesAverageGrade()
        {
            // Arrange

            Gradebook book = new Gradebook();
            book.AddGrade(17);
            book.AddGrade(89.5f);
            book.AddGrade(67);

            float expected = 57.83f;
            //Act

            Gradestatistics result = book.ComputeStatistics();

            //Assert
            Assert.AreEqual(expected, result.AverageGrade,0.01);

        }

        [TestMethod]

        public void ComputesLowestGrade()
        {
            // Arrange

            Gradebook book = new Gradebook();
            book.AddGrade(17);
            book.AddGrade(89.5f);
            book.AddGrade(3);

            float expected = 4;
            //Act

            Gradestatistics result = book.ComputeStatistics();

            //Assert
            Assert.AreNotEqual(expected, result.LowestGrade);

        }




    }
}
