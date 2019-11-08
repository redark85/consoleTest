using log4net;
using log4net.Config;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace LoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(args[0]);
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));

            logger.Info(args[0]);

            //logger.Info("OK");

            string fecha = "05/11/2019";
            DateTime parsedDate;

            bool pare = DateTime.TryParseExact(fecha, "dd/MM/yyyy", null,DateTimeStyles.None, out parsedDate);

            string fecha2 = Convert.ToDateTime(parsedDate).ToString("MMMM dd, yyyy");

            string texto = "All subscription errors are returned successfully from our payment processor. All subscription errors are returned";

  
            

            //FileStream fs;
            //try
            //{
            //    // Opens a text tile.
            //    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            //    var sr = new StreamReader(fs);

            //    // A value is read from the file and output to the console.
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (FileNotFoundException e)
            //{
            //    logger.Error($"[Data File Missing] {e}");
            //    Console.WriteLine($"[Data File Missing] {e}");
            //    throw new FileNotFoundException(@"[data.txt not in c:\temp directory]", e);
            //}
            //finally
            //{
            //    if (fs != null)
            //        fs.Close();
            //}
            Console.WriteLine(fecha2);
            Console.WriteLine(texto.Length);
        }
    }
}
