namespace Facade
{
    public class ScheduleServerFacade
    {
        private IScheduleServer _scheduleServer;
        public ScheduleServerFacade(IScheduleServer scheduleServer)
        {
            _scheduleServer = scheduleServer;
        }

        public void StartServer()
        {
            _scheduleServer.StartBooting();
            _scheduleServer.ReadSystemConfigFile();
            _scheduleServer.InitializeContext();
            _scheduleServer.InitializeListeners();
            _scheduleServer.CreateSystemObjects();
        }

        public void StopServer()
        {
            _scheduleServer.ReleaseProcesses();
            _scheduleServer.Destroy();
            _scheduleServer.DestroySystemObjects();
            _scheduleServer.DestroyListeners();
            _scheduleServer.DestroyContext();
            _scheduleServer.Shutdown();
            
        }
    }
}