namespace classwork
{
    // The following are Fields (aka: Class-level variables)
    public class House
    {
        string _foundation;
        string _roof;
        string _window;
        string _door;

        //The standard long way of a Property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }
        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }

        // Short hand property + field; Auto Property
        public string Roof { get; set; }

        public string PaintDoor { get; set; }
        // The following are Methods (aka: Function performs an action / verb)
        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }
    }
}
