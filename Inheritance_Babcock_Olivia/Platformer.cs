using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Babcock_Olivia
{
    class Platformer : Game
    {
        // Assigns parameters to corresponding properties
        public Platformer(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        // Returns string that describes the game, including title & esrb
        public override string Describe()
        {
            return $"{Title} is a platformer game rated {Esrb}!";
        }
    }
}
