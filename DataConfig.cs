namespace ConfigsLoaderMockUp
{
    static class DataConfig
    {
        public static int? OrdersPerHour { get; set; } //Number of Orders per Hour
        public static int? OrderLinesPerOrder { get; set; }
        public static string? InboundStrategy { get; set; }
        public static string? PowerSupply { get; set; } //System Power Supply (normal/big)
        public static TimeOnly? ResultStartTime { get; set; } //Result-Tracking Start Time (hours:minutes:seconds)
        public static int? ResultInterval { get; set; } //Result-Tracking Interval (m)
        public static int? NumberOfAisles { get; set; } //The number of shuttle aisles in the system
    }
}
