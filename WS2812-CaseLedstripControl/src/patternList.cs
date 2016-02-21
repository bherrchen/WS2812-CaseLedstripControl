using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseledstripcontrol
{
    public class patternList
    {
        public struct ledPattern
        {
            public int id;
            public string name;
            public string description;
            public int command;


            public ledPattern(int id, string name, string description, int command) : this()
            {
                this.id = id;
                this.name = name;
                this.description = description;
                this.command = command;
            }
        }

        public List<ledPattern> ledPatternList = new List<ledPattern>();
        private List<String> ledPatternNames = new List<String> { "boot", "white", "black", "rainbow", "rainbowWithGlitter", "confetti", "sinelon", "juggle", "bpm", "razerRainbow", "fire" };


        public patternList()
        {
            for (int x = 0; x < ledPatternNames.Count; x++)
            {
                ledPatternList.Add(new ledPattern(x, ledPatternNames[x], " ", x));
            }
        }

    }
}
