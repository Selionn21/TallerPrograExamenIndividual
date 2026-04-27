using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayerCore player = CreatePlayer();

            List<SituationCore> situations = CreateSituations();

            Game game = new Game();
            game.player = player;
            game.allSituations = situations;

            game.Start();

        }

        static PlayerCore CreatePlayer()
        {
            Console.WriteLine("Ingresa tu nombre");
            string name  = Console.ReadLine();
            return new PlayerCore(name, 100);
        }

        static List<SituationCore> CreateSituations()
        {
            List<SituationCore> list = new List<SituationCore>();

            TextSituation room = new TextSituation("room", "");
            CombatSituation monster = new CombatSituation("monster", "", 20);
            TextSituation end = new TextSituation("end", "");

            FinalSituation goodEnding = new FinalSituation("goodEnding", "", "Good");
            FinalSituation neutralEnding = new FinalSituation("neutralEnding", "", "Neutral");
            FinalSituation badEnding = new FinalSituation("badEnding", "", "Bad");

            list.Add(room);
            list.Add(monster);
            list.Add(end);
            list.Add(goodEnding);
            list.Add(neutralEnding);
            list.Add(badEnding);

            room.options.Add(new OptionCore("", -20, "monster"));
            room.options.Add(new OptionCore("", -20, "monster"));

            monster.options.Add(new OptionCore("", -20, "end"));
            monster.options.Add(new OptionCore("", -20, "end"));

            end.options.Add(new OptionCore("", -20, "goodEnding"));
            end.options.Add(new OptionCore("", -20, "neutralEnding"));
            end.options.Add(new OptionCore("", -20, "badEnding"));


            return list;

        }
    }
}
