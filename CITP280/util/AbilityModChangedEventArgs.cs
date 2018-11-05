using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.util
{
    public class AbilityScoreChangedEventArgs : EventArgs
    {
        public Int32 Score { get; set; }
        public String ModifierString { get; set; }
        public Int32 Modifier {
                get {
                Int32.TryParse(ModifierString, out int mod);
                return mod;
            }
                
        }
    }
}
