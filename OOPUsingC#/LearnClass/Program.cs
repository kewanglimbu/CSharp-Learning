using System;

namespace LearnClass
{
    class Program
    {
        static void Main(string[] args)
        {
           
            FLOWER flow;  //create object of Class FLOWER
            flow = new FLOWER("YELLOW");  //constructor of class FLOWER wuth Yellow Color
            Console.WriteLine(flow.display());
            Console.ReadLine();
        }
    }
}


