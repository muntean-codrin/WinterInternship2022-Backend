using SantaClauseConsoleApp.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClauseConsoleApp
{
    public static partial class Questions
    {
        // For my implementation of the solution to all the questions, a Singleton implementation
        // would be possible only to the LetterReader and LetterWriter classes. The data classes
        // Address, Child, Item and Letter would not benefit from a Singleton implementation since
        // the application needs more instances of these classes at the same time. 
        // I have implemented the singleton pattern in the classes LetterReaderSingleton and LetterReaderSingleton
        // This was possible since different instances of the 2 classes do not need to hold data specific to
        // that instance. They only have methods who do internal work and then return an object.
        public static void Question5()
        {
            Console.WriteLine("======== QUESTION 5 =========\n\n");

            LetterReaderSingleton reader1 = LetterReaderSingleton.GetInstance();
            LetterReaderSingleton reader2 = LetterReaderSingleton.GetInstance();

            LetterReader reader3 = new LetterReader();
            LetterReader reader4 = new LetterReader();

            if(reader1 == reader2)
            {
                Console.WriteLine("LetterReaderSingleton objects are the same instance.");
            }

            if (reader3 == reader4)
            {
                Console.WriteLine("LetterReader objects are the same instance.");
            }

            var child1 = reader1.ReadLetter("letter1.txt");
            var child2 = reader2.ReadLetter("letter2.txt");



            LetterWriterSingleton writer1 = LetterWriterSingleton.GetInstance();
            LetterWriterSingleton writer2 = LetterWriterSingleton.GetInstance();

            LetterWriter writer3 = new LetterWriter();
            LetterWriter writer4 = new LetterWriter();

            if (writer1 == writer2)
            {
                Console.WriteLine("LetterWriterSingleton objects are the same instance.");
            }

            if (writer3 == writer4)
            {
                Console.WriteLine("LetterWriter objects are the same instance.");
            }

            writer1.WriteLetter(child1, "test_singleton_1.txt");
            writer2.WriteLetter(child2, "test_singleton_2.txt");

            Console.WriteLine("\n\n======== END OF QUESTION 5 ========\n\n");
        }
    }
}
