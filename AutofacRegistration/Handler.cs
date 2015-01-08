using System;

namespace AutofacRegistration
{
    public class Handler : IHandleMessages<WebEvent1>, IHandleMessages<WebEvent2>
    {
        public void Handle(WebEvent1 message)
        {
            Console.WriteLine("Handler 1");
        }

        public void Handle(WebEvent2 message)
        {
            Console.WriteLine("Handler 2");
        }
    }
}