using System;
namespace Quiz
{
    public class QuizClass1
    {
        /*
            Write a method to accept a grade and return  a description of the grade. If a grade entered is not correct, display a message that it is not a valid grade.
         */

        public string GetGradeMessage(char grade)
        {
            if (grade == 'E')
            {
                return "Excellent";
            }
            else if (grade == 'V')
            {
                return "Very Good";
            }
            else if (grade == 'G')
            {
                return "Good";
            }
            else if (grade == 'A')
            {
                return "Average";
            }
            else if (grade == 'F')
            {
                return "Fail";
            }
            else
            {
                return "Not a valid grade";
            }
        }

        public string GetGradeMessage2(char grade)
        {
            string message;
            if (grade == 'E')
            {
                message = "Excellent";
            }
            else if (grade == 'V')
            {
                message = "Very Good";
            }
            else if (grade == 'G')
            {
                message = "Good";
            }
            else if (grade == 'A')
            {
                message = "Average";
            }
            else if (grade == 'F')
            {
                message = "Fail";
            }
            else
            {
                message = "Not a valid grade";
            }
            return message;
        }

        public string GetGradeMessage3(char grade)
        {
            string message = "";
            switch (grade)
            {
                case 'E':
                    message = "Excellent";
                    break;
                case 'V':
                    message = "Very Good";
                    break;
                case 'G':
                    message = "Good";
                    break;
                case 'A':
                    message = "Average";
                    break;
                case 'F':
                    message = "Fail";
                    break;
                default:
                    message = "Not a valid grade";
                    break;
            }
            return message;
        }

        public string GetGradeMessage4(char grade)
        {
            switch (grade)
            {
                case 'E':
                    return "Excellent";
                case 'V':
                    return "Very Good";
                case 'G':
                    return "Good";
                case 'A':
                    return "Average";
                case 'F':
                    return "Fail";
                default:
                    return "Not a valid grade";
            }
        }

        public void DivisibleByThree()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void DivisibleByThree2()
        {
            int i = 0;
            while (i < 50)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public void DivisibleByThree3()
        {
            int i = 0;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 50);
        }
        public void DivisibleByThree4()
        {
            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            foreach (int item in values)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void DivisibleByThree5()
        {
            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 3 == 0)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }

    }
}