using System;
using System.Collections.Generic;
using System.IO;

namespace UniqMedia
{
    internal class Utils
    {
        public static void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine();
            Console.WriteLine("██╗   ██╗███╗   ██╗██╗ ██████╗ ███╗   ███╗███████╗██████╗ ██╗ █████╗ ");
            Console.WriteLine("██║   ██║████╗  ██║██║██╔═══██╗████╗ ████║██╔════╝██╔══██╗██║██╔══██╗");
            Console.WriteLine("██║   ██║██╔██╗ ██║██║██║   ██║██╔████╔██║█████╗  ██║  ██║██║███████║");
            Console.WriteLine("██║   ██║██║╚██╗██║██║██║▄▄ ██║██║╚██╔╝██║██╔══╝  ██║  ██║██║██╔══██║");
            Console.WriteLine("╚██████╔╝██║ ╚████║██║╚██████╔╝██║ ╚═╝ ██║███████╗██████╔╝██║██║  ██║");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═══╝╚═╝ ╚══▀▀═╝ ╚═╝     ╚═╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═╝");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static List<string> GetImages()
        {
            try
            {
                List<string> images = new List<string>();
                foreach (string image in Directory.GetFiles(exec_path + "Images\\"))
                {
                    if (Path.GetExtension(image) == ".png" || Path.GetExtension(image) == ".jpg"
                        || Path.GetExtension(image) == ".jpeg")
                        images.Add(image);
                }

                return images;
            }
            catch
            {
                return null;
            }
        }

        public static readonly string exec_path = AppDomain.CurrentDomain.BaseDirectory;
    }
}
