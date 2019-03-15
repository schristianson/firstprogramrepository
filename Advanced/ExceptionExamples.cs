using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string _exampleNull = null;

        public void MyException()
        {
            try
            {
                Console.WriteLine(_exampleNull);
                Console.WriteLine("Try ran");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Exception thrown " + ex.Message);
            }
        }
        public void MyArrayException()
        {
            string[] names = { "Dave", "Matt", "Jody" };
            string[] values = { "243333", "42444444", "38543" };
            try
            {
                //byte b = byte.Parse(names[1]);
                byte b = byte.Parse(values[1]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least 1 argument");
            }
            catch (FormatException e)
            {
                Console.WriteLine("That is not a number");
            }
            catch (OverflowException eo)
            {
                Console.WriteLine("You have given me more than a byte");
            }
        }
    }
}