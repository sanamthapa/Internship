using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    internal class Day1
    {
        static void Main(string[] args)
        {
            AmnilInterns name = new AmnilInterns();
            name.Set("Rabin Shrestha", "Ktm", "BCA\n");
            AmnilInterns name1 = new AmnilInterns();
            name1.Set("Sanam Thapa", "Bhaktapur", "CSIT\n");
            AmnilInterns name2 = new AmnilInterns();
            name2.Set("Rajendra Lungeli", "Bhaktapur", "BIT\n");
            AmnilInterns name3 = new AmnilInterns();
            name3.Set("Sandip Sharma", "Sanepa", "Computer Engineering\n");
            AmnilInterns name4 = new AmnilInterns();
            name4.Set("Bibek Neupane", "Duwakot", "CSIT\n");
            name.get();
            name1.get();
            name2.get();
            name3.get();
            name4.get();
            Console.ReadKey();

        }
    }
}












    
    
