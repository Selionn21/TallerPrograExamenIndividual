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

            TextSituation room = new TextSituation("room", "Te pierdes en el bosque, sin linterna ni artículos que faciliten tu visión. Es de noche y estás solo, así que solo puedes refugiarte en lo que tu creas que es un lugar seguro. " +
                "Decides dormir, pero cuando estás apunto de lograrlo, escuchas ruidos de pisadas cercanas a tu posición.... algo se acerca");
            CombatSituation monster = new CombatSituation("monster", "El monstruo salta de entre los escombros realizando un golpe aéreo que logra acertar en tu pierna aunque intentas esquivarlo. Logras golpearlo con una piedra y pararte con dificultad..", 20);
            TextSituation end = new TextSituation("end", "Logras alejarte, pero el monstruo es más rápido que tú, por lo que eventualmente empieza a alcanzarte. Llegas a una puerta con 3 interruptores que tienen" +
                " un texto escrito en el centro: Un botón abre la puerta, otro despliega una trampa y otro no acciona nada....tienes que elegir.");

            FinalSituation goodEnding = new FinalSituation("goodEnding", "Abres la puerta y escapas esquivando a duras penas un ataque del monstruo. Por fin estás a salvo", "Good");
            FinalSituation neutralEnding = new FinalSituation("neutralEnding", "Activas la trampa pero justo antes de caer, el monstruo logra alcanzarte y arrancándote un brazo con sus garras, pero muriendo en el proceso", "Neutral");
            FinalSituation badEnding = new FinalSituation("badEnding", "Presionas el botón incorrecto y el monstruo logra alcanzarte, atravesándote ferozmente", "Bad");

            list.Add(room);
            list.Add(monster);
            list.Add(end);
            list.Add(goodEnding);
            list.Add(neutralEnding);
            list.Add(badEnding);

            room.options.Add(new OptionCore("Decides investigar el sonido esperanzado en que solo es la hierba o algún conejo rondandote", -25, "monster"));
            room.options.Add(new OptionCore("Te mueves silenciosamente lejos de tu ubicación en busca de un mejor refugio, algo más.... seguro", -10, "monster"));

            monster.options.Add(new OptionCore("Echas a correr lo más rápido que puedes, pero te tropiezas y caes al suelo, clavandote la rodilla con una madera", -15, "end"));
            monster.options.Add(new OptionCore("Enfrentas al monstruo para intentar dañarlo y ganar más tiempo para escapar", -30, "end"));

            end.options.Add(new OptionCore("Aprietas el botón de la izquierda (Abrir la puerta)", 0, "goodEnding"));
            end.options.Add(new OptionCore("Aprietas el botón del centro (Despliegas la trampa, pero el monstruo logra atacarte)", -25, "neutralEnding"));
            end.options.Add(new OptionCore("Aprietas el botón de la derecha (No pasa nada y el monstruo te atraviesa", -100, "badEnding"));


            return list;

        }
    }
}
