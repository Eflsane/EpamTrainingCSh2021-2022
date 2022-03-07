using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.GameObjects.Players;
using Task2_2.Positions;

namespace Task2_2.GameObjects.Enemies
{
    class Goblin : Enemy
    {
        public override char Symbol => 'n';

        public override ConsoleColor Color => ConsoleColor.Red;

        public Goblin(Vector2 position)
        {
            Name = "Goblin";
            Position = position;
        }

        public override void Attack(Player player)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
