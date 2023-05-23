
namespace LearnProperties
{
    class Program
    {
         static void Main(string[] args)
        {
            BikeColor bikeColor = new BikeColor("Red");

            //ERROR!!occur : 'bikeColor.MyBikeColor' is inaccessible due to its protection level LearnProperties
            //Console.WriteLine("User Demad ike Color is " + bikeColor.MyBikeColor);

            //Now we will try to access the private variable using the property _MyBikeColor. Then it will work fine.
            Console.WriteLine("User Demand Bike Color is " + bikeColor._MyBikeColor);

        }
    }
}