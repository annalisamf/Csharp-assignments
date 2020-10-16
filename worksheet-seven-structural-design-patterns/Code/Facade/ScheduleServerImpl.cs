using System;

namespace Facade
{
    public class ScheduleServerImpl: IScheduleServer
    {
        public void StartBooting()
        {
            Console.WriteLine("Booting...");
        }

        public void ReadSystemConfigFile()
        {
            Console.WriteLine("ReadSystemConfigFile...");
        }

        public void InitializeContext()
        {
            Console.WriteLine("InitializeContext...");
        }

        public void InitializeListeners()
        {
            Console.WriteLine("InitializeListeners...");
        }

        public void CreateSystemObjects()
        {
            Console.WriteLine("CreateSystemObjects...");
        }

        public void ReleaseProcesses()
        {
            Console.WriteLine("ReleaseProcesses...");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy...");
        }

        public void DestroySystemObjects()
        {
            Console.WriteLine("DestroySystemObjects...");
        }

        public void DestroyListeners()
        {
            Console.WriteLine("DestroyListeners...");
        }

        public void DestroyContext()
        {
            Console.WriteLine("DestroyContext...");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down...");
        }
    }
}