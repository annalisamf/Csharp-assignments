using System;
using System.Threading;

namespace command
{
    public class EmailJob : IJob
    {
        private Email _email;
        
        public void Run()
        {
            Console.WriteLine($"Job ID: ... executing email jobs.");
            if (_email != null)
            {
                _email.SendEmail();
            }

            try
            {
                Thread.Sleep(1000);
            }
            catch(ThreadInterruptedException e)
            {
                // Thread.CurrentThread(e);
            }
        }

        public void Email(Email email) //this sets the email
        {
            _email = email;

        }
    }
}