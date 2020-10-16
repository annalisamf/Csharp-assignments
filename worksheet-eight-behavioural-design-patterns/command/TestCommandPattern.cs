using System;

namespace command
{
    public static class TestCommandPattern
    {
        public static void Main(string[] args)
        {
            const int numberOfThreads = 10;
            const int numberOfJobs = 5;

            var pool = new ThreadPool<IJob>(numberOfThreads);

            var emailJob = new EmailJob();
            var smsJob = new SmsJob();
            var fileIOJob = new FileIOJob();
            var logJob = new LoggingJob();

            for (var i = 0; i < numberOfJobs; i++)
            {
                emailJob.Email(new Email());
                smsJob.Sms(new Sms());
                fileIOJob.FileIO(new FileIO());
                logJob.Logging = new Logging();
                pool.AddJob(emailJob);
                pool.AddJob(smsJob);
                pool.AddJob(fileIOJob);
                pool.AddJob(logJob);
            }

            pool.ShutdownPool();
        }
    }
}


// Job ID: 9 executing email jobs.
// Sending email.......
// Job ID: 12 executing logging jobs.
// Job ID: 17 executing email jobs.
// Sending email.......
// Job ID: 13 executing email jobs.
// Sending email.......
// Job ID: 10 executing sms jobs.
// Sending SMS...
// Job ID: 11 executing fileIO jobs.
// Executing File IO operations...
// Job ID: 18 executing sms jobs.
// Sending SMS...
// Logging...
// Job ID: 16 executing logging jobs.
// Logging...
// Job ID: 15 executing fileIO jobs.
// Executing File IO operations...
// Job ID: 14 executing sms jobs.
// Sending SMS...
// Job ID: 12 executing fileIO jobs.
// Executing File IO operations...
// Job ID: 10 executing logging jobs.
// Logging...
// Job ID: 18 executing email jobs.
// Sending email.......
// Job ID: 16 executing sms jobs.
// Sending SMS...
// Job ID: 14 executing fileIO jobs.
// Executing File IO operations...
// Job ID: 9 executing logging jobs.
// Logging...
// Job ID: 17 executing email jobs.
// Sending email.......
// Job ID: 13 executing sms jobs.
// Sending SMS...
// Job ID: 15 executing fileIO jobs.
// Executing File IO operations...
// Job ID: 11 executing logging jobs.
// Logging...
