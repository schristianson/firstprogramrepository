using System;
namespace Lessons
{
    public class Lesson11
    {
        public const int MY_VALUE = 25;

        /*
            Method to demonstrate a constant
            Which cannot change its value;
         */
        public void SampleLesson11()
        {
            const string today = "Wednesday";
            // MY_VALUE = 35; // Can not change the value
            // Can use it with other variables
            int total = MY_VALUE * 2;
            Console.WriteLine(total);

            // Cant change value of method level constant
            //today = "Friday";
        }

        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old.");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
        }

        public void OutSample(string name, out string firstName, out string lastName, out string middle)
        {

            int myIndex = name.IndexOf(' ');
            firstName = name.Substring(0, myIndex);

            string otherName = name.Substring(myIndex + 1);
            int myOther = otherName.LastIndexOf(' ');

            middle = otherName.Substring(0, myOther);
            lastName = otherName.Substring(myOther + 1);
        }


    }
}