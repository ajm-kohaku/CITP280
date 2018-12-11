using CITP280.util;
using System;

namespace CITP280.data
{
    public struct AttributeData
    {
        //pk for the table
        public int AttributeId { get; }
        //fk for the table. 
        public int CharacterId { get; set; }
        public CoreAttributes AbilityName { get; set; }
        public int BaseScore { get; set; }
        public int EnhancementScore { get; set; }
        public int InherentScore { get; set; }
        public int TempScore { get; set; }
        public int PenaltyScore { get; set; }
    }
}
