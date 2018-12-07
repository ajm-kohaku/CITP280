using System.Data.Linq.Mapping;

namespace CITP280.data
{
    [Table(Name = "CharcterSheet")]
    class CharacterSheetDao
    {
        private int characterId;
        private string characterName;
        private string playerName;
        private int damageTaken;
        private int maxHealth;
        private int playerClassLevel;
        private string playerClassName;
        private int favoredClassSkillCount;
        private int favoredClassHealthCount;
        private int favoredClassOtherCount;

        [Column(IsPrimaryKey = true, Storage = "characterId")]
        public int CharacterId { get => characterId; set => characterId = value; }
        [Column(Storage = "characterName")]
        public string CharacterName { get=> characterName; set=> characterName = value; }
        [Column(Storage = "playerName")]
        public string PlayerName { get => playerName; set => playerName = value; }
        [Column(Storage = "damageTaken")]
        public int DamageTaken { get => damageTaken; set => damageTaken = value; }
        [Column(Storage = "maxHealth")]
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        [Column(Storage = "playerClassLevel")]
        public int PlayerClassLevel { get => playerClassLevel; set=> playerClassLevel = value; }
        [Column(Storage = "playerClassName")]
        public string PlayerClassName { get => playerClassName; set => playerClassName = value; }
        [Column(Storage = "favoredClassSkillCount")]
        public int FavoredClassSkillCount { get => favoredClassSkillCount; set=> favoredClassSkillCount = value; }
        [Column(Storage = "favoredClassHealthCount")]
        public int FavoredClassHealthCount { get =>  favoredClassHealthCount; set => favoredClassHealthCount = value; }
        [Column(Storage = "favoredClassOtherCount")]
        public int FavoredClassOtherCount { get => favoredClassOtherCount; set => favoredClassOtherCount = value; }
    }
}
