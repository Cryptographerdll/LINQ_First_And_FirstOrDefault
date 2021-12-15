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
            
         #comment =>   // var FirstItem = Names.First(); // IronMan .
            
         #comment =>  // var FirstItem = Names.FirstOrDefault(a => a.StartsWith("B")); // BatMan 

            var FirstItem = Names.FirstOrDefault(a => a.StartsWith("Z")); // Exception Error 

            // In case of writing Unexistant instruction Exception will happned

            #comment => // For example : Names.First(a => a.StartsWith("Z"));
            // Here ther is no element in list start with Z Soo Programm Error for Avoide this problem 
            #comment =>  // We use FirstOrDefault(); Method . 

            Console.Write(FirstItem == null);
        }
    }
}
