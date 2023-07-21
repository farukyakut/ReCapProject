// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;

Console.WriteLine("Hello, User!");

ColorManager colorManager = new ColorManager(new EfColorDal());


foreach (var color in colorManager.GetAll().Data)
{
    Console.WriteLine(color.Name);
}

var result = colorManager.GetById(1).Data;
Console.WriteLine(result.Name);


Console.WriteLine("--------------------------------------");
CarManager carManager = new CarManager(new EfCarDal());

var resultt = carManager.GetCarDetails();

if(resultt.Success == true)
{
    foreach (var car in resultt.Data)
    {
        Console.WriteLine("{0} , {1} , {2} , {3}", car.CarName, car.ColorName, car.BrandName, car.DailyPrice);
    }

}

else
{
    Console.WriteLine(resultt.Message);
}


Console.WriteLine("-------------------------------------------");

RentalManager rentalManager = new RentalManager(new EfRentalDal());
var Messagess = rentalManager.Add(new Rental() { CustomerId = 2, CarId = 3, RentDate = new DateTime(2011, 10, 12), ReturnDate = null });
Console.WriteLine(Messagess.Message);

var result2 = rentalManager.GetAll();

if (result2.Success == true)
{
    foreach (var rental in result2.Data)
    {
        Console.WriteLine("{0} , {1} , {2} , {3},{4}",rental.RentalId,rental.CustomerId,rental.CarId,rental.RentDate,rental.ReturnDate );
    }

}

else
{
    Console.WriteLine(resultt.Message);
}
