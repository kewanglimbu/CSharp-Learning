
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
           // Console.WriteLine("User Demand Bike Color is " + bikeColor._MyBikeColor);


           ///<summary>
           /// Read only proerties
           ///</summary>

          //Car evCar = new Car();
          //Console.WriteLine("Model: {0}", evCar.Model_ID);
          //Console.WriteLine("Model: {0}", evCar.Manufact_Name);


          ///<summary>
          /// Write only properties
          /// </summary>
          
          //Car car2 = new Car();
          //car2._carModel = 2023;
          //car2._owner = "Kewang";
          //car2.DisplayData();



            ///<summary>
            ///  Auto Implemented property
            /// </summary>

            Car car3 = new Car();
            car3.Price = 5000000;
            car3.CarName = "BMW";
            Console.WriteLine("===  CAR ==========");
            Console.WriteLine("Price: {0}", car3.Price);
            Console.WriteLine( "Brand: {0}",car3.CarName);


        }
    }
}