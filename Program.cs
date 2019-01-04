﻿using System;
using Lessons;
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
            MyStringExamples();
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
