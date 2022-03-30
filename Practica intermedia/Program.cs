using System;

namespace Practica_intermedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value=new Random().Next(0,999);           
            String message = value > 500 ? "Greater than 500" : "Less than";
            Console.WriteLine( value.ToString() + " "+  message);
        }
    }
}

