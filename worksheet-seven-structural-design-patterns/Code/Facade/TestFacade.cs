using System;

namespace Facade
{
    public static class TestFacade
    {
        public static void Main(string[] args)
        {
            IScheduleServer scheduleServer = new ScheduleServerImpl();
            ScheduleServerFacade facadeServer = new ScheduleServerFacade(scheduleServer);
            
            Console.WriteLine("Start working......");
            facadeServer.StartServer();
            Console.WriteLine("After the work has been completed.........");
            facadeServer.StopServer();
        }
    }
}