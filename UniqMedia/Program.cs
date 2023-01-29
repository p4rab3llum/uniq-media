using System;
using System.Collections.Generic;
using System.Threading;

namespace UniqMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintBanner();

            images = Utils.GetImages();

            Console.WriteLine();
            Console.WriteLine("Found " + images.Count + " images!");

            Console.WriteLine();
            if (images.Count != 0)
            {
                Console.WriteLine("Started processing images...");
                Thread thread1 = new Thread(new ThreadStart(Image));
                thread1.Start();
            }
            Console.WriteLine();
        }

        private static void Image()
        {
            Unique.ProcessImage(images);
        }

        private static List<string> images;
    }
}
