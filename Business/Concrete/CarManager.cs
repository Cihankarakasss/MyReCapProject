using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        private Car car;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car Car)
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

        public Car GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public void Uptade(Car car)
        {
            _carDal.Update(car);
        }
    }
}
