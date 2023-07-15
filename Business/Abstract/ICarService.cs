using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Identity.Client;

namespace Business.Abstract;

public interface ICarService
{
    
    Car GetById(int CarId);
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);
    List<Car> GetCarsByBrandId(int BrandId);
    List<Car> GetCarsByColorId(int ColorId);
    List<CarDetailDto> GetCarDetails();


}
