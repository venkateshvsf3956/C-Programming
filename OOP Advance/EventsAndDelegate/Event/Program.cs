using System;
namespace Event;
class Program 
{
    public static void Main(string[] args)
    {
        Events event1=new Events("Quiz");
        Events event2=new Events("Debugging");
        Events event3=new Events("Presentation");
        Events event4=new Events("Games");

        //Even registration by management
        Events.eventLink += new EventManager(event1.ShowEvents);
        Events.eventLink += new EventManager(event2.ShowEvents);
        Events.eventLink += new EventManager(event3.ShowEvents);
        Events.eventLink += new EventManager(event4.ShowEvents);


        //unnsubcribe
        Events.eventLink=new EventManager(event1.ShowEvents);
        Events.HandleMethod();

        
    }
}