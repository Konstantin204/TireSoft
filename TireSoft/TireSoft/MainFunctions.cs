using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TireSoft
{
    [Serializable]
    public class MainFunctions
    {
        public List<string> ReadInfo(List<string> list, string[] items)
        {
            foreach (var i in items)
            {
                list.Add(i);
            }     
            return list;
        }
        public virtual void Input_Data(string brand, string model, string coupe, string tire_size)
        {
            using (var writer = File.Open("Cars.txt", FileMode.Append))
            {
                string line = "BRAND " + brand + " / MODEL " + model + " / TYPE " + coupe + " / TIRESIZE " + tire_size + ";" + '\n';
                byte[] lineBytes = Encoding.UTF8.GetBytes(line);
                writer.Write(lineBytes, 0, lineBytes.Length);
            }


        }

    }
}
