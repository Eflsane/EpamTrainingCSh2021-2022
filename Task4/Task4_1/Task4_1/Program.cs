using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4_1.Helpers;
using Task4_1.VersionController;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SerilogHelper.InitializeLogger();

            //args = new string[] { "/r" };

                FileVersionController versionController
                    = new FileVersionController(@"C:\Users\super\Task4_1\WatchFolder"
                    , @"C:\Users\super\Task4_1\LogsFolder\Logs.txt");
            try
            {
                if(args.Length == 1)
                {
                    if (args[0] == @"/w")
                    {
                        versionController.WatchForChanges();
                        Console.WriteLine("Watch started");

                        Console.ReadLine();

                        versionController.SaveLogs();
                    }
                    else if (args[0] == @"/r")
                    {
                        Console.WriteLine("Enter a date (in format yyyy.MM.dd HH:mm) files will be revert to:");
                        string input = Console.ReadLine();
                        string dateFormat = "yyyy.MM.dd HH:mm";
                        DateTime dateTimeToReturn = DateTime.ParseExact(input, dateFormat, null);


                        versionController.RevertChanges(dateTimeToReturn);
                        Console.WriteLine($"Changes reverted to date {dateTimeToReturn}");
                    }
                    else
                    {
                        Console.WriteLine("Task4_1 arg " +
                        "\n/w - starts watcher for files" +
                        "\n/r - revert changes to date");
                    }
                }
                else
                {
                    Console.WriteLine("Task4_1 arg " +
                        "\n/w - starts watcher for files" +
                        "\n/r - revert changes to date");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");

                Console.ReadLine();
            }
            finally
            {
                if (args.Length > 0)
                {
                    if (args[0] == @"/w")
                    {
                        versionController.SaveLogs();
                    }
                }                
            }
        }
    }
}
