using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class FourKTV : AbstractTV
    {
        public FourKTV(int size, bool IsMountable)
            : this(size, 8, 949.50m, IsMountable)
        {

        }
        public FourKTV(int size, int ports, decimal price, bool IsMountable)
            : base(size, ports, 999, true) { }

        public override void Remote()
        {
            Console.WriteLine("FourKTV smartapp");
        }
    }
}