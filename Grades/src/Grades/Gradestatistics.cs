using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  public class Gradestatistics
    {
        public Gradestatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

       public float AverageGrade;
       public float LowestGrade;
       public float HighestGrade;
    }
}
