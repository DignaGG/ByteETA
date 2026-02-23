namespace ByteETA.Core.Models
{
    public class FileInfo
    {
        public double Value {  get; set; }
        public FileUnit Unit { get; set; }

        public FileInfo(double value, FileUnit unit)
        {
            Value = value;
            Unit = unit;
        }
    }

    public enum FileUnit
    {
        KB, 
        MB,
        GB
    }
}