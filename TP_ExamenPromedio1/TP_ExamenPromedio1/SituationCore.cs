using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class SituationCore
    {
        public string id;
        public string description;
        public List<OptionCore> options;

        public SituationCore(string id,  string description)
        {
            this.id = id;
            this.description = description;
            options = new List<OptionCore>(); 
        }

        public virtual void Execute(PlayerCore player)
        {
            Console.WriteLine(description);
        }


    }
}
