using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        // Define an event handler which has the same signature as defined by the delegate in the publisher
        public void OnVideoEncoded(object source, EventArgs e)
        {
            System.Console.WriteLine("MessageService: Sending a text message ...");

        }


    }










}
