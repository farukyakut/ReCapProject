// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.Entityframework;

Console.WriteLine("Hello, User!");

ColorManager colorManager = new ColorManager(new EfColorDal());


foreach (var color in colorManager.GetAll())
{
    Console.WriteLine(color.Name);
}

var result = colorManager.GetById(1);
Console.WriteLine(result.Name);


Console.WriteLine("--------------------------------------");
CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine("{0} , {1} , {2} , {3}", car.CarName,car.ColorName, car.BrandName, car.DailyPrice );
}
