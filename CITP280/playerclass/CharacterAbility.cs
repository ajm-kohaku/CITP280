using System;
using System.Collections.Generic;

namespace CITP280.playerclass
{
    public struct CharacterAbility
    {
        public string name { get; set; }
        public string description { get; set; }

        //an ability can scale as one gains more levels. this is used to display progress on the class table
        //int => level obtained, int => description to display on class table.
        public Dictionary<int, String> classTableDescription { get; set; }

    }
}
