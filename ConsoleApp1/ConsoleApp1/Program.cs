﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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


        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");
        }
        class Network
        {
           static  ArrayList WebPageContents = new ArrayList();
            public static  async Task  Download()
            {
                HttpClient client = new HttpClient();
                var data = await client.GetStringAsync("http://torontopubliclibrary.com");
               // Console.WriteLine(data);
               foreach (var i in data)
                {
                    WebPageContents.Add(i);
                }

            }
        }
    }
}
