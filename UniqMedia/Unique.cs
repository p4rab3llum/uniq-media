using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace UniqMedia
{
    internal class Unique
    {
        public static void ProcessImage(List<string> images)
        {
            foreach (string image in images)
            {
                try
                {
                    Random random = new Random();

                    string filename = Path.GetFileName(image);
                    string final_filename = Utils.exec_path + "Result\\Images\\" + Path.GetFileNameWithoutExtension(image) + "_uniqmedia.png";

                    Bitmap bitmap = new Bitmap(image);
                    Bitmap bitmap1 = new Bitmap(bitmap.Width, bitmap.Height);

                    Graphics graphics = Graphics.FromImage(bitmap1);
                    SolidBrush brush = new SolidBrush(Color.FromArgb(10, random.Next(256), random.Next(256), random.Next(256)));
                    Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                    graphics.FillRectangle(brush, rectangle);
                    graphics.DrawImage(bitmap1, new Rectangle(1, 1, bitmap.Width, bitmap.Height));

                    Graphics.FromImage(bitmap).DrawImage(bitmap1, new Rectangle(1, 1, bitmap.Width, bitmap.Height));
                    if (File.Exists(final_filename))
                    {
                        File.Delete(final_filename);
                    }
                    bitmap.Save(final_filename, ImageFormat.Png);

                    bitmap.Dispose();
                    bitmap1.Dispose();
                }
                catch
                {
                    Console.WriteLine("Error during processing image: " + Path.GetFileName(image));
                    Console.WriteLine();
                    continue;
                }
            }

            Console.WriteLine("Finished processing images!");
        }
    }
}
