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
            new Car { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 300, Description = "Range Rover Sport", ModelYear = 2019 },
            new Car { Id = 2, BrandId = 7, ColorId = 8, DailyPrice = 200, Description = "Lamborghini Huracan", ModelYear = 2017},
            new Car { Id = 3, BrandId = 5, ColorId = 5, DailyPrice = 200, Description = "Bugatti Veyron Ettore", ModelYear = 2015},
            new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 100, Description = "Lamborghini Egoista", ModelYear = 2014},
            new Car { Id = 5, BrandId = 2, ColorId = 2, DailyPrice = 100, Description = "Porsche 918 Spyder", ModelYear = 2015}
        
            };
            
            
            
        }
        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            foreach (var c in _cars)
            {
                if(car.Description == c.Description)
                {
                    carToDelete = c;
                }
            }

            carToDelete = _cars.SingleOrDefault(c => c.Description == car.Description);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Description == car.Description);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
