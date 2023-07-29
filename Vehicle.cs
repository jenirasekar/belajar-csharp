namespace interfaces
{
    class Vehicle
    {
        string LicensePlate
        { get; }
        double Speed
        { get; private set; }
        int Wheels
        { get; }
        void Honk();
    }
}