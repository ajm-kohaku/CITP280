using System.Collections.Generic;

namespace CITP280.data
{
    public struct CharacterSheetData
    {
        public int CharacterId { get; }
        public string CharacterName { get; }
        public AttributeData Strength { get; set; }
        public AttributeData Dexterity { get; set; }
        public AttributeData Constitution { get; set; }
        public AttributeData Intelligence { get; set; }
        public AttributeData Wisdom { get; set; }
        public AttributeData Charisma { get; set; }
        public List<CharacterClassData> ClassRecordList { get; set; }
        public int DamageTaken { get; set; }
    }
}