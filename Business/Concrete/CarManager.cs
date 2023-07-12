using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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

    public int GetById(int carId)
    {
       return _carDal.GetById(carId);
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }
}
