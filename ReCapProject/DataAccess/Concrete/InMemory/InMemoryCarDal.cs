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
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice=1000, ModelYear= 2001, Description = "Fast"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice=1500, ModelYear= 2001, Description = "Medium Speed"},
                new Car{Id = 3, BrandId = 3, ColorId = 3, DailyPrice=2000, ModelYear= 2001, Description = "Fast"},
                new Car{Id = 4, BrandId = 3, ColorId = 4, DailyPrice=600, ModelYear= 2001, Description = "Slow"},
                new Car{Id = 5, BrandId = 2, ColorId = 3, DailyPrice=300, ModelYear= 2001, Description = "Medium Speed"},
                new Car{Id = 6, BrandId = 1, ColorId = 2, DailyPrice=400, ModelYear= 2001, Description = "Slow"},
                new Car{Id = 7, BrandId = 4, ColorId = 1, DailyPrice=1000, ModelYear= 2001, Description = "Fast"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car carToGet = _cars.SingleOrDefault(c => c.Id == id);
            return carToGet;
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
    }
}
