using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildWars2_HardcoreMode.Models
{
    public class Character
    {
        public int deaths { set; get; }
        public String Name { set; get; }
        public long Timeplayed { set; get; }

        public Character()
        {
            deaths = 0;
            Name = "Nothfing";
            Timeplayed = 0;
        }

        public Character(String Name)
        {
            deaths = 0;
            this.Name = Name;
            Timeplayed = 0;
        }

    }
}