using System;
namespace Lessons
{
    // Apple extends Fruit
    public class Apple : Fruit
    {
        public override void EatFruit()
        {
            Console.WriteLine("I eat apples");
        }

        public void Cobbler()
        {
            Console.WriteLine("I like Cobbler");
        }
    }
}