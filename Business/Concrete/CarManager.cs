using Business.Abstract;
using Business.Constants;
using Business.ValidationtRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System.Drawing;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    [ValidationAspect(typeof(CarValidator))]
    public IResult Add(Car car)
    {
        


        //var context = new ValidationContext<Car>(car);
        //CarValidator carValidator = new CarValidator();
        //var result = carValidator.Validate(context);
        //if (!result.IsValid) 
        //{
        //    throw new ValidationException(result.Errors);
        //}

        _carDal.Add(car);
        return new SuccessResult(Messages.CarAded);
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);

    }

    public IDataResult<List<Car>> GetAll()
    {
        if(DateTime.Now.Hour == 9)
        {
            return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
    }

    public IDataResult<Car> GetById(int CarId)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == CarId));
        
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        if (DateTime.Now.Hour == 9)
        {
            return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
        }

        return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
    {
        return new SuccessDataResult<List<Car>>( _carDal.GetAll(p=>p.BrandId == BrandId));
    }

    public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == ColorId));
    }

    public IResult Update(Car car)
    {
        if(car.CarName.Length < 2)
        {
            return new ErrorResult(Messages.CarNameInvalid);
        }
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }
}
