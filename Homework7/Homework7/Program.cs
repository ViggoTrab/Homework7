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
            Car myCar1 = new Car();

            myCar1.DisplayCarInfo();

            myCar1.Drive();

            myCar1.DisplayCarInfo();

            Car myCar2 = new Car();

            myCar2.DisplayCarInfo();

            myCar2.Drive();

            myCar2.DisplayCarInfo();

            Book myBook1 = new Book();

            myBook1.DisplayProgress();

            myBook1.Read();

            myBook1.DisplayProgress();

            Book myBook2 = new Book();

            myBook2.DisplayProgress();

            myBook2.Read();

            myBook2.DisplayProgress();

        }
    }
}
