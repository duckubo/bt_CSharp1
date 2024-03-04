using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2CSharp
{
    class Truck : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public static IList<Truck> Trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck  { name = "Volvo VNR", price = 1323313 , year = 2010 , manufacture="Volvo", model="VNR",NumberOfWheels=12},
                    new Truck { name = "Ford VNX", price = 42635243 , year = 2015 , manufacture="Ford", model="VNX",NumberOfWheels=16},
                    new Truck { name = "Chevrolet VAH", price = 11132990 , year = 2005 , manufacture="Chevrolet", model="VAH",NumberOfWheels=18},
                    new Truck  { name = "Toyota GMC", price = 642434 , year = 2008 , manufacture="Toyota", model="GMC",NumberOfWheels=20},
                    new Truck { name = "Merc GMC", price = 9345353 , year = 2018  , manufacture="Merc", model="GMC",NumberOfWheels=24}
                };
            }
        }
    }
}
