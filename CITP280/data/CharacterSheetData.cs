using System.Collections.Generic;

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
        public List<ClassRecordData> ClassRecordList { get; set; }
        public string DamageTaken { get; set; }
    }
}