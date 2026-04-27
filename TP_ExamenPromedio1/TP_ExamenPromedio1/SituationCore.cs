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
        public List<Option> options;

        public SituationCore(string id,  string description)
        {
            this.id = id;
            this.description = description;
            options = new List<Option>(); 
        }

        public virtual void Execute(Player player)
        {
            Console.WriteLine(description);
        }


    }
}
