using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10projectday1
{
    class DVD:Resource
    {
       
        public override void ViewTitle()
        {
            Console.WriteLine("\nTitle: {0}", this.Title);
            Console.WriteLine("ISBN: {0}", this.ISBN);
            Console.WriteLine("Length: {0} Minutes", this.Length);
            Console.WriteLine("Status: {0}", this.Status);
        }
        public override void AddTitle()
        {
            Console.Write("\nTitle: ");
            this.Title = Console.ReadLine();
            Console.Write("ISBN: ");
            this.ISBN = Console.ReadLine();
            Console.Write("Length in minutes: ");
            this.Length = Console.ReadLine();
        }
    }
}
