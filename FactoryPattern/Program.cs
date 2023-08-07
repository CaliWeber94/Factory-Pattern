namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like a vehicle with two or four wheels?");
            var NumberofWheels = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(NumberofWheels);


            vehicle.Drive();
         




        }
    }
}
