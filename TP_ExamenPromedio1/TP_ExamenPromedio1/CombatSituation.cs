using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class CombatSituation : SituationCore
    {

        public int damage;

        public CombatSituation(string id, string description, int damage) : base(id, description)
        {
            this.damage = damage;
        }

        public override void Execute(Player player)
        {
            Console.WriteLine(description);
            player.health -= damage;
            Console.WriteLine("Pierdes " + damage + " de vida");
        }



    }
}
