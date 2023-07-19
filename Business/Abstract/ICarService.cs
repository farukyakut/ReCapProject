using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Identity.Client;

namespace Business.Abstract;

public interface ICarService
{
    
    IDataResult<Car> GetById(int CarId);
    IDataResult<List<Car>> GetAll();
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
    IDataResult<List<Car>> GetCarsByBrandId(int BrandId);
    IDataResult<List<Car>> GetCarsByColorId(int ColorId);
    IDataResult<List<CarDetailDto>> GetCarDetails();


}
