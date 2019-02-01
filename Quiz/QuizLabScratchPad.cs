using System;

namespace Quiz
{
    public class QuizLab3
    {
        private int[] numbers = new int[5] { 2016, 2017, 2018, 2019, 2020 };

        public int Length
        {
            get { return numbers.Length; }
        }

        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }

        static int Year.Length(int value)
        {
            Console.WriteLine(Year.Length);
        }

        static int GetIntegerDigitCountString(int value)
        {
            return value.ToString().Length;
            Console.WriteLine(GetIntegerDigitCount(9999));
        }
    }
}