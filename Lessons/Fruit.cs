using System;
namespace Lessons
{
    public class Fruit
    {
        public virtual void EatFruit()
        {
            Console.WriteLine("I eat fruit");
            // ThrowFruit();
        }

        // Private is only accessible from within the class.
        private void ThrowFruit()
        {
            Console.WriteLine("Throwing Fruit");
        }
    }
}