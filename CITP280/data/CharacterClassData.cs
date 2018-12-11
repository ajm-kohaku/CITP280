using System;

namespace CITP280.data
{
    public struct CharacterClassData
    {
        public int CharacterClassId { get; }
        public int CharacterId { get; set; }
        public int MaxHealth { get; set; }
        public int PlayerClassLevel { get; set; }
        public string PlayerClassName { get; set; }
        public int FavoredClassSkillCount { get; set; }
        public int FavoredClassHealthCount { get; set; }
        public int FavoredClassOtherCount { get; set; }
    }
}
