﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847
{
    class Program
    {
        static void Main(string[] args)
        {
			HelloWorld hw = new HelloWorld();
			hw.Hello();
        }
    }
	class HelloWorld
	{
		public void Hello()
	{
		Console.WriteLine("Hello World");
	}
}
}
