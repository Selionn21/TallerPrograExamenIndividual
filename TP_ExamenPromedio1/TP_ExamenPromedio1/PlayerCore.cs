using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class PlayerCore
    {

        public string name;
        public int health;

        public PlayerCore(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public void ShowStats()
        {
            Console.WriteLine("Vida: " + health);
        }



    }
}
