using System;
namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventLink=null;//User Defined event
        public static int i; 
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleMethod()
        {
            i=0;
            System.Console.WriteLine("User Registration.");
            System.Console.WriteLine("Starting the following events.");
            eventLink();
        }
        public void ShowEvents()
        {
            ++i;
            System.Console.WriteLine("Events No: "+i+"is "+_eventName+" Started");
        }

    }
}