using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class HDTV : AbstractTV
    {
        public HDTV(int size, bool IsMountable)
            : this(size, 6, 549.50m, IsMountable)
        {

        }
        public HDTV(int size, int ports, decimal price, bool IsMountable)
                    : base(size, ports, 549, false) { }

        public override void Remote()
        {
            Console.WriteLine("HDTV remote");
        }
    }
}
