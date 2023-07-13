﻿using Entities.Concrete;
using Microsoft.Identity.Client;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetCarsId(int Id);

    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);
    List<Car> GetCarsByBrandId(int BrandId);
    List<Car> GetCarsByColorId(int ColorId);


}
