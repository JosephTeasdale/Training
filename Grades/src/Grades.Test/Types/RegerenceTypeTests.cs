using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {


        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrade(grades);
           
            Assert.AreEqual(89.1f, grades[1]);
         

        }

        private void AddGrade(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
           name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);

        }



        [TestMethod]
        public void AddDaysToDateTimeVariable()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);
            
            Assert.AreEqual(2, date.Day);
        }




        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number = number + 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A GradeBook";
            
        }


        [TestMethod]
        public void MyTestMethod()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1 = new Gradebook();
            g1.Name = "Joseph's grade book";

            Assert.AreNotEqual(g1.Name, g2.Name);

        }
        [TestMethod]
        public void IntVariableHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void valuereferencetest()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            book2.year = 1988;

            book1 = new Gradebook();



            Assert.AreNotEqual(book1.year, book2.year);

           }
                
                [TestMethod]
        public void valuetest()
        {
            int z1 = 300;
            int z2 = 350;


            z2 = z1;
            z1 = 175;

            Assert.AreNotEqual(z1, z2);

        }

        }

    }

