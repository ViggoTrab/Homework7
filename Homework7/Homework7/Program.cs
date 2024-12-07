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

        public Car(string brand, string model, int year, int mileage)
        {
            _Brand = brand;
            _Model = model;
            _Year = year;
            _Mileage = mileage;
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

    //2
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _Pages;
        private int _CurrentPage = 0;

        public Book(string title, string author, int pages)
        {
            _Title = title;
            _Author = author;
            _Pages = pages;
        }

        public void Read()
        {
            Console.Write("Enter the number of pages you have read: ");
            Console.WriteLine();

            int PagesToRead;

            if (int.TryParse(Console.ReadLine(), out PagesToRead) && PagesToRead > 0)
            {
                _CurrentPage += PagesToRead;

                if (_CurrentPage > _Pages)
                {
                    _CurrentPage = _Pages;
                    Console.WriteLine("You have most likely finished the book already");
                }
            }
        }

        public void DisplayProgress()
        {
            Console.WriteLine($"Reading '{_Title}' by {_Author}: {_CurrentPage}/{_Pages} pages read");
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("Toyota", "Corolla", 2020, 15000);

            myCar1.DisplayCarInfo();

            myCar1.Drive();

            myCar1.DisplayCarInfo();

            Car myCar2 = new Car("Porsche", "Cayenne", 2015, 2500);

            myCar2.DisplayCarInfo();

            myCar2.Drive();

            myCar2.DisplayCarInfo();

            Book myBook1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

            myBook1.DisplayProgress();

            myBook1.Read();

            myBook1.DisplayProgress();

            Book myBook2 = new Book("Olive Kitteridge", "Elizabeth Strout", 200);

            myBook2.DisplayProgress();

            myBook2.Read();

            myBook2.DisplayProgress();

        }
    }
}
