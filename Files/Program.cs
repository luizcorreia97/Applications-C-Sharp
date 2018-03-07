using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/TEMPORARY_FILES";
            if(!Directory.Exists(path)) 
            {
                Directory.CreateDirectory(path);
            }

            string path2 = @"C:/TEMPORARY_BACKUP";
            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }

            string path_of_the_file = @"C:/TEMPORARY_FILES/test.txt";

            //StreamWriter my_file = new StreamWriter(path_of_the_file);
            //my_file.WriteLine("My first file in C#");
            //my_file.Close();

            // Change file, saving register old.
            //using(StreamWriter my_file = new StreamWriter(path_of_the_file, true)) {
            //    my_file.WriteLine("Current date: " + DateTime.Now.ToString() + " User: Luiz");
            //}            

            // Show in the console what is in the file
            /* if(File.Exists(path_of_the_file)) {
                using (StreamReader file = new StreamReader(path_of_the_file))
                {
                    string row = string.Empty;
                    while ((row = file.ReadLine()) != null)
                    {
                        Console.WriteLine(row);
                    }
                }
            } */

            string path_origin = @"C:/TEMPORARY_FILES/test.txt";
            string path_destiny = @"C:/TEMPORARY_BACKUP/test.txt";

            string path_2 = @"C:/TEMPORARY_BACKUP/test.txt";

            //if (File.Exists(path_2))
            //{
            //    using (StreamReader file = new StreamReader(path_2))
            //    {
            //        string row = string.Empty;
            //        while ((row = file.ReadLine()) != null)
            //        {
            //            File.Copy(path_origin, path_destiny);
            //            Console.WriteLine(row);
            //        }
            //    }
            //}

            //File.Copy(path_origin, path_destiny);
            //File.Move(path_origin, path_destiny);
            File.Delete(path_destiny);

            Console.ReadKey();

        }
    }
}
