﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ColorManager : IColorService
{
    IColorDal _colorDal;
    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public void Add(Color brand)
    {
        _colorDal.Add(brand);
    }

    public void Delete(Color brand)
    {
        _colorDal.Delete(brand);
    }

    public List<Color> GetAll()
    {
        return _colorDal.GetAll();
    }

    public Color GetById(int id)
    {
        return _colorDal.Get(p=>p.Id == id);
    }

    public void Update(Color brand)
    {
        _colorDal.Update(brand);
    }
}
