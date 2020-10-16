namespace Facade
{
    public interface IScheduleServer
    {
        void StartBooting();
        void ReadSystemConfigFile();
        void InitializeContext();
        void InitializeListeners();
        void CreateSystemObjects();
        void ReleaseProcesses();
        void Destroy();
        void DestroySystemObjects();
        void DestroyListeners();
        void DestroyContext();
        void Shutdown();
    }
}