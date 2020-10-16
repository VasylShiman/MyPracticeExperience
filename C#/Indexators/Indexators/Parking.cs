using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexators
{
    class Parking
    {
        private List<Car> _car = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this[string number]
        {
            get
            {
                var car = _car.FirstOrDefault(c => c.Number == number);
                return car;
            }
        }


        public int Count => _car.Count;

        public string Name { get; set; }

        public int Add(Car car)
            {
            if(car== null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }
                if (_car.Count < MAX_CARS)
                {
                    _car.Add(car);
                    return _car.Count - 1;
                }
            return -1;
            }
        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or empty");
            }
            var car = _car.FirstOrDefault(c => c.Number == number);
            if (car!=null)
            {
                _car.Remove(car);
            }
        }
    }
}
