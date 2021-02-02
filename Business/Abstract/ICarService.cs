﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car Car);
        void Uptade(Car car);
        void Delete(Car car);
        Car GetById(int Id);

    }
}
