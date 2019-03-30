using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   // this is a comment
        static void Main(string[] args)
        {

            Console.WriteLine("Downloading File");
            Download();
            Console.ReadLine();

        }


        static void Download()
        {
            await Network.Download();
        }
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download complete");
                Thread.Sleep(7000);
            });
            Thread.Sleep(3000);
            Console.WriteLine("Download complete");
        }
       class
    }
}

