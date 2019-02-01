using System;

namespace Lessons
{
    public class LabResults
    {
        public void OhmsLaw()
        {
            int I = 2;                  // Initilization of Current or first Variable
            int R = 6;                  // Initilization of Resistance or second Variable
            int V = I * R;              
            int Current = V / R;
            int Resistance = V / I;

            Console.WriteLine(V);      // Voltage
            Console.WriteLine(I);      // Current in amps
            Console.WriteLine(R);      // Resistance in ohms
        }
    }
}