using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Instances_and_Variables
    {
        internal bool gameOn = true;
        internal bool isRunning = true;
        internal Pokemon p = new Pokemon();
        internal Characters c = new Characters();
        internal Moves m = new Moves();
        internal Fight f = new Fight();
        internal Catch ca = new Catch();
        internal Random random = new();
    }
}
