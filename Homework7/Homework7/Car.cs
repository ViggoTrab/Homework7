using System;
using System.Collections.Generic;
using System.Linq;
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

        public Car()
        {
            Console.Write("Enter the brand of the car: ");
            _Brand = Console.ReadLine();

            Console.Write("Enter the model of the car: ");
            _Model = Console.ReadLine();

            Console.Write("Enter the year of the car: ");
            _Year = int.Parse(Console.ReadLine());

            Console.Write("Enter the mileage of the car: ");
            _Mileage = int.Parse(Console.ReadLine());
        }

        public void Drive()
        {
            Console.Write("Enter the number of kilometers you have driven: ");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int kilometers) && kilometers > 0)
            {
                _Mileage += kilometers;
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {_Brand}, " + $"Model: {_Model}, " + $"Year: {_Year}, " + $"Mileage: {_Mileage} km");
            Console.WriteLine();

        }
    }
}
