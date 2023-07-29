namespace interfaces
{
    class Sedan : Vehicle, IAutomobile
    {
        public string LicensePlate { get; }
        public double Speed { get; private set; }
        public int Wheels { get; }
        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }
        public void SpeedUp()
        {
            Speed += 5;
        }
        public void SlowDown()
        {
            Speed -= 5;
        }
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
    }
}