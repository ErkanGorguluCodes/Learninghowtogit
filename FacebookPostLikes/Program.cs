using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPostLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            List<string> name = new List<string>();
            int i = 0;
            do
            {
                name[i] = Console.ReadLine();

            } while (name[i] != null);
        }
    }
}
