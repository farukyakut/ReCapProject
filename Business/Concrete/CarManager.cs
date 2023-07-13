using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Drawing;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    public void Add(Car car)
    {
        if(car.CarName.Length < 2 || car.DailyPrice<0)
        {
            Console.WriteLine("yetersiz karakter");
        }
        _carDal.Add(car);
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public List<Car> GetAll()
    {
       return _carDal.GetAll();
    }


    public List<Car> GetCarsByBrandId(int BrandId)
    {
        return _carDal.GetAll(p=>p.BrandId == BrandId);
    }

    public List<Car> GetCarsByColorId(int ColorId)
    {
        return _carDal.GetAll(p => p.ColorId == ColorId);
    }

    public List<Car> GetCarsId(int Id)
    {
        return _carDal.GetAll(p => p.Id == Id);

    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }
}
