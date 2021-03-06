using System;
namespace classwork
{
    // The following are Fields (aka: Class-level variables)
    public class BookLibrary
    {
        string _diminsions;
        string _typeofcover;
        string _genre;
        string _publisher;

        //The standard long way of a Property
        public string diminsions
        {
            get
            {
                return _diminsions;
            }
            set
            {
                this._diminsions = value;
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                this._genre = value;
            }
        }

        // Short hand property + field; Auto Property
        public string Typeofcover { get; set; }

        public string Publisher { get; set; }
        // The following are Methods (aka: Function performs an action / verb)
        public void OpenBook()
        {
            Console.WriteLine("The book opens");
        }

        // METHOD OVERLOAD
        public void OpenBook(string bookmark)
        {
            Console.WriteLine("I put my" + bookmark + "in the openbook");
        }

        public void CloseBook()
        {

        }
        public void TurnPage()
        {

        }

        // DEFAULT CONSTRUCTOR
        public BookLibrary() { }

        // CONSTRUCTOR OVERLOAD
        public BookLibrary(string diminsions, string typeofcover, string genre, string publisher)
        {
            this._diminsions = diminsions;
            this._typeofcover = typeofcover;
            this._genre = genre;
            this._publisher = publisher;
        }

    }
}
