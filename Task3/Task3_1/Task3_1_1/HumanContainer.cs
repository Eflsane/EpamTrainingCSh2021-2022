using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_1
{
    class HumanContainer
    {
        private List<string> _humans;
        public int Count 
        {
            get => _humans.Count;
        }


        public HumanContainer(int count)
        {
            _humans = new List<string>();

            FillContainerWithHumans(count);
        }

        private void FillContainerWithHumans(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("count  must be greater than 0");

            for(int i = 0; i < count; i++)
            {
                _humans.Add(NameGenerator.GenerateAbsoluteRandomName());
            }
        }

        public string KillHumanOnCircle(int numInCircle = 2)
        {
            if (numInCircle > Count)
                throw new ArgumentOutOfRangeException("numInCircle must be less than humans count");

            string name = "";
            int index = numInCircle - 1;
            name = _humans[index];            
            _humans.RemoveAt(index);
            return name;
        }

        public int VisualizeHumansInConsole()
        {
            Console.WriteLine();
            
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for(int i = 0; i < Count; i++)
            {
                Console.Write(' ');
            }
            Console.ResetColor();

            int linesPassed = Count / Console.WindowWidth;
            return linesPassed;
        }

        //Draw Humans Count plus one that have been killed
        public void VisualizeHumansInConsole(int killedNum)
        {
            if (killedNum <= 0)
                throw new ArgumentException("killedNum must be greater than 0");
            int linesPassed = VisualizeHumansInConsole();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(' ');

            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(killedNum - 1, Console.CursorTop - linesPassed);
            Console.Write(' ');
            Console.ResetColor();

            Console.SetCursorPosition(1, Console.CursorTop + linesPassed + 1);
        }
    }
}
