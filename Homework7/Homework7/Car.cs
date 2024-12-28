using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    //1
    public class Car
    {
        private string _Brand;
        private string _Model;
        private int _Year;
        private int _Mileage;

        public Car(string brand, string model, int year, int mileage)
        {
            _Brand = brand;
            _Model = model;
            _Year = year;
            _Mileage = mileage;
        }

        public void Drive(int kilometers)
        {
            Console.WriteLine("Update in mileage.");

            _Mileage += kilometers;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {_Brand}, " + $"Model: {_Model}, " + $"Year: {_Year}, " + $"Mileage: {_Mileage} km");
            Console.WriteLine();

        }
    }
}
