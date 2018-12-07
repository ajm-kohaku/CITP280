using CITP280.util;
using System.Data.Linq.Mapping;

namespace CITP280.data
{
    [Table(Name = "Attribute")]
    public class AttributeDao
    {
        [Column(IsPrimaryKey = true, Storage = "attributeId")]
        public int AttributeId { get; set; }
        [Column(Storage = "characterId")]
        public int CharacterId { get; set; }
        [Column(Storage = "attributeTypeId")]
        public CoreAttributes AbilityName { get; set; }
        [Column(Storage = "baseScore")]
        public int BaseScore { get; set; }
        [Column(Storage = "enhancementScore")]
        public int EnhancementScore { get; set; }
        [Column(Storage = "inherentScore")]
        public int InherentScore { get; set; }
        [Column(Storage = "tempScore")]
        public int TempScore { get; set; }
        [Column(Storage = "penaltyScore")]
        public int PenaltyScore { get; set; }
    }
}
