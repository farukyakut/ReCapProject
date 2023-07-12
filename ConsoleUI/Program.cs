// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
CarManager carManager = new CarManager(new InMemoryCarDal());
//Listeleme

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Id);
}

carManager.Add(new Car() { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 1500, ModelYear = new DateTime(2011, 10, 12), Description = "Güzel Ürün" });

Console.WriteLine("--------------------------------------");

//Ekleme

foreach (var car in carManager.GetAll())
{
    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice" + car.DailyPrice + " Model Year : " + car.ModelYear
        + " Description :" + car.Description);
}
Console.WriteLine("------------------------------------------");

//Silme

carManager.Delete(new Car() { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 1500, ModelYear = new DateTime(2011, 10, 12), Description = "Güzel Ürün" });

foreach (var car in carManager.GetAll())
{
    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice" + car.DailyPrice + " Model Year : " + car.ModelYear
        + " Description :" + car.Description);
}

