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

            synth.Speak("Hello! This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(71);
            book.AddGrade(83.3f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

        }
    }
}
