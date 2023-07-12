using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _car;

    public InMemoryCarDal()
    {
        _car = new List<Car>
        {
            new Car { Id = 1, BrandId=1, ColorId=1, DailyPrice=100, ModelYear= new DateTime(2020,09,12), Description = "Başarılı Ürün"},
            new Car { Id = 2, BrandId=1, ColorId=1, DailyPrice=1000, ModelYear= new DateTime(2000,08,14), Description = "Kullanışlı"},
            new Car { Id = 3, BrandId=2, ColorId=1, DailyPrice=50, ModelYear= new DateTime(2012,09,13), Description = "Allah'a Emanet"},
            new Car { Id = 4, BrandId=2, ColorId=3, DailyPrice=1500, ModelYear= new DateTime(2011,10,12), Description = "Başarısız Ürün"},
        };
    }

    public void Add(Car car)
    {
        _car.Add(car);
    }

    public void Delete(Car car)
    {
        Car removeCar = _car.SingleOrDefault(c => c.Id == car.Id);
        _car.Remove(removeCar);
    }

    public List<Car> GetAll()
    {
        return _car;
    }

    public int GetById(int id)
    {
        Car oneCar = _car.SingleOrDefault(c => c.Id == id);
        return oneCar.Id;
    }

    public void Update(Car car)
    {
        Car updateCar = _car.SingleOrDefault(c => c.Id == car.Id);

        updateCar.BrandId = car.BrandId;
        updateCar.ColorId = car.ColorId;
        updateCar.DailyPrice = car.DailyPrice;
        updateCar.Description = car.Description;
        updateCar.ModelYear = car.ModelYear;
  
    }
}
