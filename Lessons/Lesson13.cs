using System;
namespace Lessons
{
    public class Lesson13
    {
        string _firstName, _lastName;

        public Lesson13(string _firstName, string _lastName)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            Console.WriteLine("Constructor Called");
        }

        public void Deconstruct(out string _firstName, out string _lastName)
        {
            _firstName = this._firstName;
            _lastName = this._lastName;
            Console.WriteLine("Deconstructor Called");
        }
    }
}