using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10projectday1
{
    abstract class Resource
    {
        private string title;
        private string isbn;
        private int length;
        private string status;
        protected string type;

        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Length { get; set; }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
            
        }


        public virtual void ViewTitle()
        {
            Console.WriteLine("\nTitle: {0}",this.Title);
            Console.WriteLine("ISBN: {0}", this.ISBN);
            Console.WriteLine("Length: {0} Pages", this.Length);
            Console.WriteLine("Status: {0}", this.Status);
        }

        public virtual void AddTitle()
        {
            Console.Write("\nTitle: ");
            this.Title = Console.ReadLine();
            Console.Write("ISBN: ");
            this.ISBN = Console.ReadLine();
            Console.Write("Length in pages: ");
            this.Length = Console.ReadLine();
            this.Status = "Available";
            Console.Write("Status: {0}", Status);
            
        }
        public virtual void CheckOut()
        {
            Status = "Checked Out";
            DateTime dueDate = DateTime.Today.AddDays(3);
            Console.WriteLine("\n{0} has been checked out.", this.Title);
            Console.WriteLine("Due Date: {0}", dueDate);
        }
        public void CheckIn()
        {
            Status = "Available";
        }
    }
}
