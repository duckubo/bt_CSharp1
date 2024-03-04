using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2CSharp
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        

        public static IList<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { name = "Honda CRV", price = 313232  , year = 1990 , manufacture="Honda", model="CRV",NumberOfDoors=2},
                    new Car { name = "Mazda 3", price = 256234  , year = 1870 , manufacture="Mazda", model="SUV",NumberOfDoors=3},
                    new Car { name = "VinFast Vfe34", price = 24123 , year = 1677 , manufacture="Vinfast", model="CRV",NumberOfDoors=4},
                    new Car { name = "BMW i8", price = 199432 , year = 1999 , manufacture="BMW", model="CRV",NumberOfDoors=5},
                    new Car { name = "Merc G63", price = 156500 , year = 1565 , manufacture="Merc", model="SUV",NumberOfDoors=6},
                     new Car { name = "Mazda 2", price = 216234  , year = 1670 , manufacture="Mazda", model="SUV",NumberOfDoors=3}
                };
            }
        }
    }
}
