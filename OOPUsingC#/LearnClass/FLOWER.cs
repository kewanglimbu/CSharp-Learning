using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    /*
     
    In this example we have created the class FLOWER. In this class we declared one public variable flowercolor. Our FLOWER 6
    class defines a constructor. It takes a parameter that allows us to initialize FLOWER objects with a color. In our case we
    initialize it with the color yellow. The Describe() method shows the message. It simply returns a string with the
    information we provided.

     */


    class FLOWER
    {
        public string flowercolor;

        public FLOWER(string color)
        {
            this.flowercolor = color;
        }

        public string display()
        {
            return "Color of the Flower: "+ this.flowercolor;
        }
    }
}
//Note: Method name FLOWER and class FLOWER are the same name but the method is a constructor of the class.