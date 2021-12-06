using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TireSoft
{
    public class CarTires : Tires
    {

        public override void Input_Data(string brand, string size, string capacity, string price)
        {
            if (Convert.ToInt32(capacity) <= 100)
            {
                using (var writer = File.Open("CarTires.txt", FileMode.Append))
                {
                    string line = "BRAND " + brand + " / SIZE " + size + " / CAPACITY " + capacity + " / PRICE " + price + '\n';
                    byte[] lineBytes = Encoding.UTF8.GetBytes(line);
                    writer.Write(lineBytes, 0, lineBytes.Length);
                }
            }

        }
    }
}
