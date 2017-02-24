using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook
    {

        public Gradebook()
        {
            grades = new List<float>();
        }

        public Gradestatistics ComputeStatistics()
        {
           Gradestatistics stats =  new Gradestatistics();

            
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }


        public string Name;
        public int year;

        List<float> grades;
    }
}
