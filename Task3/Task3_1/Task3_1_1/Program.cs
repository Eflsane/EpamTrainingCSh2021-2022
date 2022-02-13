using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            int count = 0;
            do
            {
                Console.WriteLine("Enter humans count (Must be more than Zero): ");
            } while (!int.TryParse(Console.ReadLine(), out count) && count <= 0);
            HumanContainer humanContainer = new HumanContainer(count);

            int killNum = 0;
            do
            {
                Console.WriteLine("Enter human on which number should be killed (Must be greater than 0 and less than humans count)");
            } while (!int.TryParse(Console.ReadLine(), out killNum) && killNum <= 0 && killNum >= count);
            while(humanContainer.Count >= killNum)
            {
                string name = humanContainer.KillHumanOnCircle(killNum);
                humanContainer.VisualizeHumansInConsole(killNum);
                Console.WriteLine($"human {name} has been eliminated. {humanContainer.Count} humans has left.");
            }

            Console.WriteLine("Finished, there is not enough humans to continue");
            Console.ReadKey();
        }
    }
}
