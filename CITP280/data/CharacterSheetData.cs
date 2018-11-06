using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.data
{
    public class CharacterSheetData
    {
        public AbilityData Strength { get; set; }
        public AbilityData Dexterity { get; set; }
        public AbilityData Constitution { get; set; }
        public AbilityData Intelligence { get; set; }
        public AbilityData Wisdom { get; set; }
        public AbilityData Charisma { get; set; }
        public int DamageTaken { get; set; }
        public int MaxHealth { get; set; }
        public int PlayerClassLevel { get; set; }
        public string PlayerClassName { get; set; }
        public int FavoredClassSkillCount { get; set; }
        public int FavoredClassHealthCount { get; set; }
        public int FavoredClassOtherCount { get; set; }

    }
}
