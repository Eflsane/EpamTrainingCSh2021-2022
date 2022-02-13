using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of.
            //Some text some text I wrote. This text is mine text and mine only. Everybody who thinks otherwise will go to the mine.
            Console.WriteLine("Hello user! \n" +
                "Please paste your text here:");
            string sInput = Console.ReadLine();

            string output = TextAnalyser.StartAnalyse(sInput);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0, -20}", output);
            Console.ReadKey();
        }
    }
}
