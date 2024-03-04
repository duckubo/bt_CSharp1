using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2CSharp
{
    public class  Vehicle
    {
        public string name { get; set; }
        public double price { get; set; }
        public int year { get; set; }
        public string manufacture { get; set; }

        public string model { get; set; }
      
        public string GetInfo()
        {
            return $" {name} {price} {year} {model}";
        }
    }
}
