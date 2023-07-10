using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProperties
{

    /// <summary>
    /// This is Example of Read Only Properties.
    /// </summary>

    public class Car
    {
        private int model = 2023;

        private string manufacturer = "Tesla Pro Max";

        public int Model_ID
        {
            get
            {
                return model;
            }
        }
        public string Manufact_Name
        {
            get
            {
                return manufacturer;
            }
        }


        ///<summary>
        /// This is Example of Write only properties
        /// </summary>


        private int carModel = -1;
        
        private string owner = string.Empty;

        public int _carModel
        {
            set { carModel = value; }
        }

        public string _owner
        {
            set { owner = value; }
        }

        public void DisplayData()
        {
            Console.WriteLine("====== Car =========");
            Console.WriteLine("Model: {0}", carModel);
            Console.WriteLine("Owner: {0}", owner);
        }



        ///<summary>
        /// This is Example of Auto Implemented property
        /// </summary>
        

        public int Price { get;set; }
        public string CarName { get;set; }





    }
}



