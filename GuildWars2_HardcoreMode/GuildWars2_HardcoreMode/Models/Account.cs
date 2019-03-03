using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildWars2_HardcoreMode.Models
{
    public class Account
    {
        public long ID { set; get; }
        public String APIkey { set; get; }
        public List<Character> characters;

        public Account()
        {
            ID = -1;
            APIkey = "Nothfing";
            characters = new List<Character>();
        }

        public Account(long ID, string APIkey, List<Character> characters)
        {
            this.ID = ID;
            this.APIkey = APIkey;
            this.characters = characters;
        }

        public void addCharacter(Character character)
        {
            characters.Add(character);
        }

    }
}