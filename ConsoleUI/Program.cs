// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
CarManager carManager = new CarManager(new EfCarDal());
//Listeleme

foreach (var car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine(car.Description);
}

carManager.Add(new Car() { BrandId = 2, CarName = "Megan", ColorId = 2, DailyPrice = 1500, ModelYear = new DateTime(2011, 10, 12), Description = "Megan Güzel Ürün" });

Console.WriteLine("--------------------------------------");

//Ekleme

foreach (var car in carManager.GetAll())
{
    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice" + car.DailyPrice + " Model Year : " + car.ModelYear
        + " Description :" + car.Description);
}
//Console.WriteLine("------------------------------------------");

////Silme

//carManager.Delete(new Car() { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 1500, ModelYear = new DateTime(2011, 10, 12), Description = "Güzel Ürün" });

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice" + car.DailyPrice + " Model Year : " + car.ModelYear
//        + " Description :" + car.Description);
//}

foreach (var car in carManager.GetCarsId(1))
{
    Console.WriteLine(car.Description);
}

