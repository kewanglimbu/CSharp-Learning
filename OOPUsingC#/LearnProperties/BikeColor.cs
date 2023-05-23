using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProperties
{
    class BikeColor
    {
        private string MyBikeColor; //private variable

        public BikeColor(string UserDemandColor)
        {
            this. MyBikeColor = UserDemandColor;
        }

        
        //property of a class use to display the message on the console
        public string _MyBikeColor
        {
            get
            {
                return MyBikeColor;
            }

            set
            {
                MyBikeColor = value;
            }
        }
    }
}
