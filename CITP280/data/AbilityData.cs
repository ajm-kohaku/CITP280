using CITP280.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.data
{
    public class AbilityData
    {
        public CoreAttributes AbilityName { get; set; }
        public int BaseScore { get; set; }
        public int EnhancementScore { get; set; }
        public int InherentScore { get; set; }
        public int TempScore { get; set; }
        public int PenaltyScore { get; set; }
    }
}
