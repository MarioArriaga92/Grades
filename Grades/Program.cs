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
            GradeBook book = new GradeBook();

            // Commented to cause NullReferenceException
            book.NameChanged += new NameChangedDelegate(OnNameChanged);

            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong!");
            }
            //This is dangerous!:
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            book.AddGrade(95);
            book.AddGrade(71);
            book.AddGrade(83.3f);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
    }
}
