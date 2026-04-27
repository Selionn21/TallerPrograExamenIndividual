using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExamenPromedio1
{
    internal class FinalSituation : SituationCore
    {

        public string ending;

        public FinalSituation(string description, string ending) : base(description)
        {
            this.ending = ending;
        }



    }
}
