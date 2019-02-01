using System;

namespace Quiz
{
    public class QuizLab
    {
        enum UnitOfMeasure: long { millimeter, centimeter, inches, meter, yard };

        int ConversionMultiplier = 2;
        
        static void Main()
        {
             int iii = (int)UnitOfMeasure.inches;
             Console.WriteLine("inches = {0}", iii);
        }
    }
}

//           int = mm = (int)UnitOfMeasure.millimeter;
//           int = cm = (int)UnitOfMeasure.centimeter;
//           int = in = (int)UnitOfMeasure.inches;
//           int = m = (int)UnitOfMeasure.meter;
//           int = yd = (int)UnitOfMeasure.yard;