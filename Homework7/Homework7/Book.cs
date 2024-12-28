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

        public Book(string title, string author, int pages)
        {
            _Title = title;
            _Author = author;
            _Pages = pages;
        }

        public void Read(int pagesToRead)
        {
            Console.WriteLine("Progress in reading.");

            if (pagesToRead > 0)
            {
                _CurrentPage += pagesToRead;

                if (_CurrentPage > _Pages)
                {
                    _CurrentPage = _Pages;
                    Console.WriteLine("You have most likely finished the book already.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number for pages.");
            }
        }

        public void DisplayProgress()
        {
            Console.WriteLine($"Reading '{_Title}' by {_Author}: {_CurrentPage}/{_Pages} pages read");
            Console.WriteLine();
        }

    }
}
