using System;

namespace observer
{
    public class SMSUsers : IObserver
    {
        public  ISubject Subject { get; }
        public string S { get; } //info
        public string Description { get; set; }
        
        public SMSUsers(ISubject subject, string s)
        {
            //if subject is null, throws an exception
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            S = s;
        }

        public void Update(string desc)
        {
            Description = desc;
            Console.WriteLine($"[{S}]: {Description}");
        }
        
        public void Subscribe()
        {
            Console.WriteLine($"Subscribing {S} to {Subject.SubjectDetails()}...");
            Subject.SubscribeObserver(this);
            Console.WriteLine("Subscribed successfully.");
        }

        public void UnSubscribe()
        {
            Console.WriteLine($"Unsubscribing {S} to {Subject.SubjectDetails()}...");
            Subject.UnSubscribeObserver(this);
            Console.WriteLine("Unsubscribed successfully.");
        }
    }
}