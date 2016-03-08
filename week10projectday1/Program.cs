using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10projectday1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();
            newBook.AddTitle();
            newBook.ViewTitle();
            newBook.CheckOut();
            newBook.ViewTitle();
            newBook.CheckIn();
            newBook.ViewTitle();

            DVD newDVD = new DVD();
            newDVD.AddTitle();
            newDVD.ViewTitle();
            newDVD.CheckOut();
            newDVD.ViewTitle();
            newDVD.CheckIn();
            newDVD.ViewTitle();

            Magazine newMag = new Magazine();
            newMag.AddTitle();
            newMag.ViewTitle();
            newMag.CheckOut();
            newMag.ViewTitle();
            newMag.CheckIn();
            newMag.ViewTitle();

        }
    }
}
