using System;
using Lessons;
using Quiz;
/* This namespace represents the file folder that the class is in. */
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        /* Statis is only one, Void is a return type; 
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {
            //Console is a class, Writeline is a method with a parameter
            //Console.WriteLine("Hello World!");

            //BookLibraryResults();
            //MyNumericExamples();
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            //HouseSample();
            //StructSample();
            //QuizWork1();
            FruitSample();

        }

        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Apple();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue"); ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }

        static void QuizWork1()
        {
            QuizClass1 myQuiz = new QuizClass1();
            string result = myQuiz.GetGradeMessage('A');
            Console.WriteLine(result);
            myQuiz.DivisibleByThree5();
        }

        static void StructSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");

            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);
        }


        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");

            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);

            myHouse.OpenDoor(true);

            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");
        }

        //static void BookLibrary()
        //{
        //    BookLibrary myBook = new Book("fiction", "McMichael");
        //
        //          Console.WriteLine(myBook.Genre);
        //        Console.WriteLine(myBook.Publisher);
        //
        //          myBook.OpenBook(true);
        //    }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleFor();          // displays values FOR 1 thru 9, individually
            //se.SampleForEach();      // displays EACH of the letters individually in the word "something"
            //string myString = se.JumpStatementExample("Tuesday");
            //Console.WriteLine(myString);
            BottlesSong();
        }


        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }


        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceHolderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }

        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();

            myTypes.CheckOperators();

            myTypes.IncrementDecrement();

            myTypes.SpecialValues();

            myTypes.ComparisonOperators();

            myTypes.OtherOperators();
        }

        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();
        }

        static void BookLibraryResults()
        {
            // Created an object instance of Book called myBook
            BookLibrary myBook = new BookLibrary();
            // This sets the value of Biography to the object
            myBook.OpenBook(); // the book genre appears // the door opens
            myBook.Genre = "Genre Biography";
            //
            // This gets the value of Biography from the object
            Console.WriteLine(myBook.Genre); // biography
                                             // This is a second object instance of Book.
            BookLibrary mySecondBook = new BookLibrary();
            mySecondBook.Genre = "fiction exists";
            Console.WriteLine(mySecondBook.Genre); // fiction
            Console.WriteLine(myBook.Genre); // biography

        }
    }
}
