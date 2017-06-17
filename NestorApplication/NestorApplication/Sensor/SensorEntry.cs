namespace NestorApplication.Sensor
{
    public struct SensorEntry
    {
        public int Time;
        public int Tens;
        public int Offset;
    }

    public struct SensorInfo
    {
        public string version;
        public string compiled;
    }
}