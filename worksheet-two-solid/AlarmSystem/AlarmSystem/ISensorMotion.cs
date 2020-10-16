namespace AlarmSystem
{
    public interface ISensorMotion
    {
        bool IsTriggered { get; set; }
        string GetLocation();
        string GetSensorType();
        // double GetBatteryPercentage();
    }
}