using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace LINQ_First_And_FirstOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "IronMan", "SuperMan", "BatMan", "SpiderMan", "Bora" };

            var FirstItem = Names.FirstOrDefault(a => a.StartsWith("Z")); // BatMan 

            // In case of writing Unexistant instruction Exception will happned

            // For example : Names.First(a => a.StartsWith("Z"));
            // Here ther is no element in list start with Z Soo Programm Error for Avoide this problem 
            // We use FirstOrDefault Method . 

            Console.Write(FirstItem == null);
        }
    }
}
