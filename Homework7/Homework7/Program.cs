using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    //3
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("Toyota", "Corolla", 2020, 15000);

            myCar1.DisplayCarInfo();

            myCar1.Drive(100);

            myCar1.DisplayCarInfo();

            Car myCar2 = new Car("Ford", "Focus", 2018, 25000);

            myCar2.DisplayCarInfo();

            myCar2.Drive(150);

            myCar2.DisplayCarInfo();

            Book myBook1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 200);

            myBook1.DisplayProgress();

            myBook1.Read(50);

            myBook1.DisplayProgress();

            Book myBook2 = new Book("1984", "George Orwell", 328);

            myBook2.DisplayProgress();

            myBook2.Read(100);

            myBook2.DisplayProgress();

        }
    }

}
