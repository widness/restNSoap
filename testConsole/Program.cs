using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UserManager.GetUID("user"));
        }
    }
}
