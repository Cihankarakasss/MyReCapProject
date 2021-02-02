using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   
        public class InMemoryCarDal : ICarDal
        {
            List<Car> _cars;
            public InMemoryCarDal()
            {
                _cars = new List<Car> {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 1999, DailyPrice = 22025, Description = "Açıklama 1"},
                new Car {Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2001, DailyPrice = 45050, Description = "Açıklama 2"},
                new Car {Id = 3, BrandId = 2, ColorId = 3, ModelYear = 2008, DailyPrice = 10070, Description = "Açıklama 3"},
                new Car {Id = 4, BrandId = 3, ColorId = 2, ModelYear = 2009, DailyPrice = 10609, Description = "Açıklama 4"},
                new Car {Id = 5, BrandId = 3, ColorId = 3, ModelYear = 2009, DailyPrice = 10069, Description = "Açıklama 5"},
            };
            }
            public void Add(Car car)
            {
                _cars.Add(car);
            }
            public void Update(Car car)
            {
                Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
            public void Delete(Car car)
            {
                Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
                _cars.Remove(carToDelete);
            }
            public List<Car> GetAll()
            {
                return _cars;
            }
        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Add(object car)
        {
            throw new NotImplementedException();
        }
    }
    }