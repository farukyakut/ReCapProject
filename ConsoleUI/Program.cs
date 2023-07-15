// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello User!");

//CarTest();

ColorManager colorManager = new ColorManager(new EfColorDal());


foreach (var color in colorManager.GetAll())
{
    Console.WriteLine(color.Name);
}

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    //Listeleme

//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine("{0} , {1} , {0} , {3} , {4} , {5}, {6}", car.Id, car.CarName, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
//    }

//    //Ekleme

//    //carManager.Add(new Car() { BrandId = 2, CarName = "Megan2", ColorId = 1, DailyPrice = 1500, ModelYear = new DateTime(2020, 11, 12), Description = "Megan 2020 Model" });

//    //Console.WriteLine("--------------------------------------");



//    //foreach (var car in carManager.GetAll())
//    //{
//    //    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice" + car.DailyPrice + " Model Year : " + car.ModelYear
//    //        + " Description :" + car.Description);
//    //}
//    Console.WriteLine("------------------------------------------");

//    //Silme

//    //carManager.Delete(new Car() { Id = 10, BrandId = 2, ColorId = 2, DailyPrice = 1500, ModelYear = new DateTime(2011, 10, 12), Description = "Megan Güzel Ürün" });

//    //foreach (var car in carManager.GetAll())
//    //{
//    //    Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice: " + car.DailyPrice + " Model Year : " + car.ModelYear
//    //        + " Description :" + car.Description);
//    //}


//    // Id'ye göre getirme

//    //var result = carManager.GetById(1);
//    //Console.WriteLine(result.CarName);

//    carManager.Update(new Car() { Id = 11, BrandId = 2, CarName = "Megan2", ColorId = 1, DailyPrice = 1500, ModelYear = new DateTime(2020, 11, 12), Description = "Megan 2020 Modelll" });

//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine("Id :" + car.Id + " Marka Numarası :" + car.BrandId + " ColorId :" + car.ColorId + " DailyPrice: " + car.DailyPrice + " Model Year : " + car.ModelYear
//            + " Description :" + car.Description);
//    }
//}