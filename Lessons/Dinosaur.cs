using System;
namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric
    {
        public string Travel { get; set; } = "Walk";

        public abstract void EatFood();

        public virtual void Move()
        {
            Console.WriteLine("The Dinosaur Moves");
        }

        public abstract void SkinType();

        public abstract void Teeth();


    }
}