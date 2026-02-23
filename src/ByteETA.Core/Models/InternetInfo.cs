namespace ByteETA.Core.Models
{
    public class InternetInfo
    {
        public double Value { get; set; }
        public SpeedUnit Unit { get; set; }
        
        public InternetInfo(double value, SpeedUnit unit) 
        {
            Value = value;
            Unit = unit;
        }
    }

    public enum SpeedUnit
    {
        Kbps,
        Mbps,
        Gbps
    }
}