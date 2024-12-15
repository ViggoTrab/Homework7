using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    //2
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _Pages;
        private int _CurrentPage = 0;

        public Book()
        {
            Console.Write("Enter the title of the book: ");
            _Title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            _Author = Console.ReadLine();

            Console.Write("Enter the amount of pages of the book: ");
            _Pages = int.Parse(Console.ReadLine());

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
}
