using System;
using Lessons;
using Quiz;
using Advanced;
/* This namespace represents the file folder 
 * that the class is in. */
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        public delegate void TryOn(string type);

        /* Static is only one, Void is a return type; 
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {

            // Console is a class, WriteLine is a method with a parameter
            //Console.WriteLine("Hello World!");
            //BookLibraryResults();
            //MyHouseResults();
            //MyNumericExamples();
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            //HouseSample();
            //StructSample();
            //QuizWork1();
            //FruitSample();
            // ParamsSample();
            // ModifierExamples();
            // Lesson12();
            //AbstractDemo();
            //DeconstructSample();
            //FinalizerSample();
            //IndexerSample();
            //PartialSample();
            //AnotherHouseExample();
            //GenricSample();
            //CollectionSample();
            //MyLabResults();          // QuizLab2 assignment, #1
            //MyQuizLab();             // QuizLab2 assignment, #4
            //MyTVResults();           // QuizLab2 assignment, #3
            //DelegateSample();        //the Call for this method in the main method
            MultiDelegateSample();
            EventSample();
        }

        private static void EventSample()
        {
            Coats myCoat = new Coats();
            string result = myCoat.MyResult;
            Console.WriteLine(result);
        }

        private static void MultiDelegateSample()
        {
            Hats moreHats = new Hats(7);
            TryOn someHats, niceHat, sadHat;

            niceHat = moreHats.FindLuckyHat;
            niceHat("Top");

            sadHat = moreHats.FindUglyHat;
            sadHat("Dunce");

            someHats = niceHat + sadHat;
            someHats("Cowboy");

        }

        private static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I tried on a " + myHat.HatType +
                " hat that was size " + myHat.HatSize);

            Hats mySecondHat = new Hats();
        }

        // #1. LabResults - Ohm's Law
        static void MyLabResults()
        {
            LabResults myTypes = new LabResults();

            myTypes.OhmsLaw();
        }

        static void MyTVResults()
        {
            HDTV myTV = new HDTV(42, false);
            Console.WriteLine(myTV.Size);
            myTV.Remote();

        }
        // #3. QuizLab2 - Enum
        static void MyQuizLab()
        {

            QuizLab2 myTypes = new QuizLab2();

            myTypes.ConversionFeet(2, QuizLab2.FeetConvert.Millimeters);

            //myTypes.LeapYear();
        }

        //static void BookLibrary()
        //{
        //    BookLibrary myBook = new Book("fiction", "McMichael");
        //
        //          Console.WriteLine(myBook.Genre);
        //        Console.WriteLine(myBook.Publisher);
        //
        //          myBook.OpenBook(true);
        // }

        static void CollectionSample()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);

            GenericList<string> mySecondList = new
            GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTRexList = new
            GenericList<TRex>();
            myTRexList.Add(new TRex());
        }

        static void AnotherHouseExample()
        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Window = "Double Pane",
                PaintDoor = "Red",
                Foundation = "Concrete"
            };

            Console.WriteLine("My windows choice is {0}",
            myHouse.Window);
        }

        static void PartialSample()
        {
            Pear pear = new Pear("Yellow");
        }

        static void IndexerSample()
        {
            IndexerExample indexerExample = new IndexerExample();

            indexerExample[2] = 250;

            for (int i = 0; i < indexerExample.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, indexerExample[i]);

            }
        }


        static void FinalizerSample()
        {
            FinalizerExample finalizerExample = new
            FinalizerExample("John", "Doe");


        }

        static void DeconstructSample()
        {
            string first = "Tom", last = "Jones";

            Lesson13 lesson13 = new Lesson13("John", "Doe");

            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);

            lesson13.Deconstruct(out first, out last);

            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);

        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();
            trex.SkinType();

            triceratops.EatFood();
            triceratops.Move();
            triceratops.Teeth();
        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }

        static void ModifierExamples()
        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);

            string first, second, middle;
            myLesson.OutSample("John Doe Riley", out first, out second, out middle);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(middle);
        }

        static void ParamsSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.OptionalParam("Roger");
            lesson.OptionalParam("Matthew", 19);

        }


        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Apple();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
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

            Console.WriteLine("The book " + bookSample.title +
            " by " + bookSample.author + " is $" + bookSample.price);
        }

        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);
            myHouse.OpenDoor(true);


        }

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
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.SampleForEach();
            //string myString = se.JumpStatementExample("Sunday");
            //Console.WriteLine(myString);
            //BottlesSong();
            se.SampleDays(DaysOfWeek.Wed);
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

        }

        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();
        }

        static void MyHouseResults()
        {
            // Created and object instance of House called myHouse
            House myHouse = new House();
            // This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor(); // the door closes
                                 // This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor); // red
                                                  // This is a second object instance of House.
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); // green
            Console.WriteLine(myHouse.PaintDoor); // red
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