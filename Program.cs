using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{

    public class AmnilInterns
    {

        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;

        public string Faculty { get; set; } = default!;

        public void Set(string name, string address, string faculty)
        {

            this.Name = name;
            this.Address = address;
            this.Faculty = faculty;

        }
        public void get()
        {
            Console.WriteLine("Name =" + " " + Name);
            Console.WriteLine("Address =" + " " + Address);
            Console.WriteLine("Faculty =" + " " + Faculty);
        }
    }
}
        



    