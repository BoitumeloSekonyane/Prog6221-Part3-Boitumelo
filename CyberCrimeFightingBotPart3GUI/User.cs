using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCrimeFightingBotPart2GUI
{
    public class User
    {

        public string Name { get; set; }
        public string FavouriteTopic { get; set; }

        public User(string name) 
        {
            Name = name;
            FavouriteTopic = "";
        }
    }
}
