using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum CarType
    {
        BMW,
        Audi,
        Marcedes,
        Toyota,
        Honda
    }

    public enum DriveMods
    {
        Stopped,
        Forward,
        Reverse
    }

    public class Car
    {
        public CarType Type { get; set; }
        public double Velocity { get; set; }
        public string carownermail { get; set; }

        public DriveMods DriveMod { get; set; } = DriveMods.Stopped;
        public Car() { }

        public void addownermail(string mail)
        {
            this.carownermail = mail; 
        }

        public double Timetocoverdistance(double distance)
        {
            return distance / Velocity;
        }
        public Car getmycar()
        {
            return new Car(); 
        }

        public DriveMods getdirection()
        {
            return DriveMod;
        }


        public string getownermail()
        {
            return this.carownermail; 
        }

    }

    



}
