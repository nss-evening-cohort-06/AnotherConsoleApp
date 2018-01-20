namespace AnotherConsoleApp
{
    class Kindle
    {
        public double BatteryPercent { get; set; }
        public int NumberOfBooks { get; set; }

        public string KindleStatus()
        {
            return (BatteryPercent > 0.33) 
                ? $"You kindle has a good charge at {BatteryPercent}, now's a good time to read one of your {NumberOfBooks} book options" 
                : $"You kindle should probably be charged, it's at {BatteryPercent}.";
        }

    }
}

