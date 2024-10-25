using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class CarDAL
    {
        private CarStoreContext _context;

        public CarDAL()
        {
            _context = new CarStoreContext();
        }

        // Lấy danh sách tất cả xe
        public List<Car> GetCars()
        {
            return _context.Cars.ToList();
        }

        // Lấy một xe theo ID
        public Car GetCarById(int carId)
        {
            return _context.Cars.Find(carId);
        }

        // Thêm xe mới
        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        // Sửa thông tin xe
        public void UpdateCar(Car car)
        {
            var existingCar = _context.Cars.Find(car.CarId);
            if (existingCar != null)
            {
                existingCar.Brand = car.Brand;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;

                _context.SaveChanges();
            }
        }

        // Xóa xe
        public void DeleteCar(int carId)
        {
            var car = _context.Cars.Find(carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}

