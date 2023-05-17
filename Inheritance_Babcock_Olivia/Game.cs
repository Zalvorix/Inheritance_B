using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Babcock_Olivia
{
    abstract class Game
    {
        // Defines string parameters
        public string Esrb { get; set; }

        public string Title { get; set; }

        // Assigns string parameters
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        /// <summary>
        /// Prints the title and says it is starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }
        
        // Returns string value
        public abstract string Describe();
    }
}
