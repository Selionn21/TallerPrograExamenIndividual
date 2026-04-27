using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class OptionCore
    {

        public string text;
        public int healthChange;
        public string nextId;

        public OptionCore(string text, int healthChange, string nextId)
        {
            this.text = text;
            this.healthChange = healthChange;
            this.nextId = nextId;
        }



    }
}
