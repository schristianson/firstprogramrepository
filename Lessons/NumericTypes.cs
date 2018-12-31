using System;

namespace Lessons
{
    public class NumericTypes
    {
        /*Integral - Signed ...THESE ARE CLASS LEVEL VARIABLES */
        // range -128 to 127
        sbyte _mySbyteValue = 2;

        // range -32,768 to 32,767
        short _myShortValue = 4;

        // range -2,147,483,468 to 2,147,483,647
        int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;

        /*Integral - Unsigned  */
        // range 0 to 255
        byte _myByte = 3;

        // range 0 to 65,535
        ushort _myUShortValue = 35;

        // range 0 to 4,294,967,295
        uint _myUInt = 2345U;

        // RANGE 0 TO 18,446,744,073,709,551,615
        ulong _myULongValue = 123456UL;

        /* Real Numbers */
        // range 3.4E +/- 38(7 digits)
        float _myFloatValue = -123.6589F;

        // range 1.7E +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        // range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;

        // Type Inference; the getType method returns the variable type
        public void GetSomeType()
        {
            // double
            Console.WriteLine(3.0.GetType());
            // float
            Console.WriteLine(_myFloatValue.GetType());
        }

        public int ConvertFloatToInt(float value)
        {
            int total = (int)value;
            return total;
        }

        // Method to demonstrate an Implicit Cast from int to Long
        public long LongFromInt(int value)
        {
            long total = value;
            return total;
        }

    }
}