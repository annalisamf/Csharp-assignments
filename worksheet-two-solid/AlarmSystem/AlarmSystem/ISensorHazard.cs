namespace AlarmSystem
{
    public interface ISensorHazard:ISensorMotion
    {
        double GetBatteryPercentage();
        public double BatteryPercentage { get; }
    }
}