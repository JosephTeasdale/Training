using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("hello! This is a grade book program");

            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            Gradestatistics stats = book.ComputeStatistics();
            synth.Speak("The average grade in the grade book was");

            WriteResult("Average", stats.AverageGrade);

            synth.Speak("The Highest overall grade was");

            WriteResult("Highest", stats.HighestGrade);

            synth.Speak("The lowest overall grade was");
            WriteResult("Lowest", stats.LowestGrade);

            synth.Speak("Please press any key to continue, Thank you");
            Console.WriteLine("added extra the dog is still lost");

            Gradebook book2 = new Gradebook();
            book2.AddGrade(18);
            book2.AddGrade(78);

            Gradestatistics info = book2.ComputeStatistics();


        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }



    }
}
