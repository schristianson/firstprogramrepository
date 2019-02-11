using System;

namespace Quiz
{
    public class QuizLab2
    {

        //Enums are treated as a int data type, with default values
        public enum FeetConvert { Centimeters, Inches, Meters, Millimeters, Yards, All };  //All converts all of them; remove All if 1 at a time

        //Method that takes 2 parameters
        public void ConversionFeet(double value, FeetConvert feetConvert)
        {
            switch (feetConvert)
            {
                case FeetConvert.Millimeters:
                    double total = value * 304.8;
                    Console.WriteLine(total + " millimeters");
                    break;
                case FeetConvert.All:                     // All of the conversions, rather than 1 at a time

                    break;

            }

            {
                double multiplr = 2;
                double mmm = 304.8;
                double cm = 30.48;
                double iii = 12;
                double m = 0.3048;
                double yd = 0.33333333333;
                double total;

                //int cm = (int)UnitOfMeasure.centimeter;
                //if (FeetConvert.Centimeters = 1)

                total = multiplr * cm;
                Console.WriteLine("Centimeters = {0}", total);
                Console.WriteLine();

                //Console.WriteLine(UnitOfMeasure.centimeter, (cm* multiplr));
                //Console.WriteLine((int)UnitofMeasure.centimeter);

                Console.WriteLine(FeetConvert.Centimeters);
                //cm = Convert.ToDouble(Console.ReadLine());

                //multiplr = Convert.ToDouble(Console.ReadLine());

                //total = multiplr * mmm;

                //Console.WriteLine("Total is : " + total);
                //Console.ReadKey();

            }
        }
    }
}

//           int = mm = (int)UnitOfMeasure.millimeter;
//           int = cm = (int)UnitOfMeasure.centimeter;
//           int = in = (int)UnitOfMeasure.inches;
//           int = m = (int)UnitOfMeasure.meter;
//           int = yd = (int)UnitOfMeasure.yard;