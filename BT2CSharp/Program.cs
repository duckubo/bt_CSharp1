using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newcar = new Car
            {
                name= "Toyota Camry ",
                manufacture = "Toyota",
                model = "Camry",
                year = 2022,
                price=122,
                NumberOfDoors = 4
            };


            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Car Info: " + newcar.GetInfo());

            var cars = Car.Cars;
            var trucks = Truck.Trucks;
           

            Console.WriteLine("Câu 2a: Các xe có giá trong khoảng 100.000 đến 250.000:");
           
            var filteredCars = cars.Where(car => car.price >= 100000 && car.price <= 250000);
            foreach (var car in filteredCars)
            {
                Console.WriteLine($"Name: {car.name}, Year: {car.year }, Price: {car.price}");
            }
            Console.WriteLine();
            Console.WriteLine("Câu 2b: Các xe có năm sản xuất > 1990.");
            var listCars = from item in cars where item.year >= 1990 select item;
            foreach (var item in listCars)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine();
            Console.WriteLine("Câu 2c: gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
            var groupedCars = cars.GroupBy(car => car.manufacture)
                              .Select(group => new { Name  = group.Key, TotalPrice = group.Sum(car => car.price ) });
            foreach (var group in groupedCars)
            {
                Console.WriteLine($"Name : {group.Name }, Total Price: {group.TotalPrice}");
            }
            Console.WriteLine();
            Console.WriteLine("Câu 3a: hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất");
            var orderedTrucks = trucks.OrderByDescending(truck => truck.year);
            foreach (var truck in orderedTrucks)
            {
                Console.WriteLine($"Name: {truck.name}, Year: {truck.year}, Manufacture: {truck.manufacture}");
            }
            Console.WriteLine();
            Console.WriteLine("Câu 3b: hiển thị tên cty chủ quản của Truck");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"Name: {truck.name}, Manufacture: {truck.manufacture}");
            }
            Console.ReadKey();
        }

    
    }
}
