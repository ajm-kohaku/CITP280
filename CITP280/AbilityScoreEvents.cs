using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITP280
{
    public class AbilityScoreEvents
    {
        private TextBox tbBaseScore;
        private TextBox tbEnhanceScore;
        private TextBox tbInherentScore;
        private TextBox tbTempScore;
        private TextBox tbPenaltyScore;

        public AbilityScoreEvents(TextBox tbBaseScore, TextBox tbEnhanceScore, TextBox tbInherentScore, TextBox tbTempScore, TextBox tbPenaltyScore)
        {
            this.tbBaseScore = tbBaseScore;
            this.tbEnhanceScore = tbEnhanceScore;
            this.tbInherentScore = tbInherentScore;
            this.tbTempScore = tbTempScore;
            this.tbPenaltyScore = tbPenaltyScore;
        }

        
    }
}
