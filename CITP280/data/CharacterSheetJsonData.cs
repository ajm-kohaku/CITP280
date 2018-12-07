using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.data
{
    public class CharacterSheetJsonData
    {
        public AttributeDao Strength { get; set; }
        public AttributeDao Dexterity { get; set; }
        public AttributeDao Constitution { get; set; }
        public AttributeDao Intelligence { get; set; }
        public AttributeDao Wisdom { get; set; }
        public AttributeDao Charisma { get; set; }
        public int DamageTaken { get; set; }
        public int MaxHealth { get; set; }
        public int PlayerClassLevel { get; set; }
        public string PlayerClassName { get; set; }
        public int FavoredClassSkillCount { get; set; }
        public int FavoredClassHealthCount { get; set; }
        public int FavoredClassOtherCount { get; set; }

    }
}
