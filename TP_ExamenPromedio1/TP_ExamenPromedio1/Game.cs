using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class Game
    {

        public PlayerCore player;
        public List<SituationCore> allSituations;
        public string currentId;

        public void Start()
        {
            bool playing = true;

            while (playing)
            {
                player.health = 100;
                currentId = "room";

                RunGame();

                ShowEnding();

                Console.WriteLine("¿Quieres jugar otra vez? (s/n)");
                string answer = Console.ReadLine().ToLower();

                if(answer != "s")
                {
                    playing = false;
                }
            }
        }

        private void RunGame()
        {

            while(player.health > 0)
            {
                SituationCore current = GetSituation(currentId);

                current.Execute(player);

                if (current is FinalSituation)
                    break;

                for (int i = 0; i < current.options.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + current.options[i].text);
                }

                int choice =  int.Parse(Console.ReadLine()) - 1;

                OptionCore selected = current.options[choice];

                player.health += selected.healthChange;

                player.ShowStats();

                currentId = selected.nextId;
            }


        }

        private SituationCore GetSituation(string id)
        {
            for(int i = 0; i < allSituations.Count; i++)
            {
                if (allSituations[i].id == id)
                    return allSituations[i];

               
            }

            return null;
        }

        private void ShowEnding()
        {
            SituationCore current = GetSituation(currentId);

            if(player.health <= 0)
            {
                Console.WriteLine("Has muerto");
                return;
            }

            if(current is FinalSituation)
            {
                FinalSituation final = (FinalSituation)current;

                if (final.ending == "Good") Console.WriteLine("Conseguiste el final bueno");
                else if (final.ending == "Neutral") Console.WriteLine("Conseguiste el final neutral");
                else Console.WriteLine("Conseguiste el final malo");
            }
        }








    }
}
