namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int VehicleCount = 10;
            
            Vehicle TempVehicle = new Vehicle();

            for (int i = 0; i < VehicleCount; i++)
            {
                TempVehicle.addRandom();
            }

            TempVehicle.print();
        }
    }
}