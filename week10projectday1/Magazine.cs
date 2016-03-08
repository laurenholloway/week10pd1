using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10projectday1
{
    class Magazine: Resource
    {
        public override void CheckOut()
        {
            Status = "Checked Out";
            DateTime dueDate = DateTime.Today.AddDays(2);
            Console.WriteLine("\n{0} has been checked out.", this.Title);
            Console.WriteLine("Due Date: {0}", dueDate);
        }
    }
}
