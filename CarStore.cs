using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CarStore
    {
        public List<Car> Cars { get; set; }
        public CarStore()
        {
            Cars = new List<Car>(); 
        }
        public CarStore(List<Car> cars)
        {
            Cars = cars; 
        }
        public List<Car> getallstoredcars()
        {
            return Cars;
        }

        public void addcar(Car car)
        {
            Cars.Add(car);
        }
        public void addcars(List<Car> cars)
        {
            Cars.AddRange(cars); 
        }


    }
}
