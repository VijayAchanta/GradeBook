//using System.Speech.Synthesis;

using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();

            GradeBook book = new GradeBook();

            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2);
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;

            book.Name = "Vijay's grade book";
            book.Name = "Samhita's grade book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(65.5f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest Grade", (int)stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
            //synth.Speak("Average grade - " + stats.AverageGrade);
            //synth.Speak("Highest Grade - " + stats.HighestGrade);
            //synth.Speak("Lowest Grade - " + stats.LowestGrade);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing name from {args.existingName} to new name {args.newName}");
        }
        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("****");
        }

    }
}
