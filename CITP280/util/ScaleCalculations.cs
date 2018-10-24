using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.util
{
    class ScaleCalculations
    {
        //translates the scale of a save into a numerical value based on the level of the character.
        public static Int32 GetSave(int level, SavesScale scale)
        {
            Int32 save = 0;
            switch (scale) {
                case SavesScale.GOOD: {
                        // a GOOD save is the floor of 2 + half the character's level 
                        double formula = 2 + (level * .5);
                        save = Decimal.ToInt32(Math.Floor((decimal)formula));
                        break;
                    }
                case SavesScale.POOR: {
                        // a POOR save is the floor of a third of the character's level
                        double formula = level / 3;
                        save = Decimal.ToInt32(Math.Floor((decimal)formula));
                        break;
                    }
            }

            return save;
        }

        //translates the scale of a base attack bonus into a numerical value based on the level of the character
        public static Int32 GetBaseAttack(int level, BaseAttackScale scale)
        {
            Int32 baseAttack = 0;
            switch (scale) {
                //a full base attack is equal to the character's level
                case BaseAttackScale.FULL: {
                        baseAttack = level;
                        break;
                    }
                //a 3/4 base attack is just that. the floor of 3/4 the character's level
                case BaseAttackScale.THREE_QUARTER: {
                        decimal formula = Convert.ToDecimal(level * .75);
                        baseAttack = Decimal.ToInt32(Math.Floor(formula));
                        break;
                    }
                 //a 1/2 base attack is again. just that. the floor of 1/2 the character's level
                case BaseAttackScale.HALF: {
                        decimal formula = Convert.ToDecimal(level * .5);
                        baseAttack = Decimal.ToInt32(Math.Floor(formula));
                        break;
                    }

            }
            return baseAttack;
        }

        //formats the character's base attack to show potential additional attacks a character gets
        // when the Base Attack reaches 6, the character can make 2 attacks that turn. One attack at a bonus value of 6 and another at a bonus of 1.
        // the number of attacks increases again at 11 and 16
        public static string GetFormattedBaseAttackBonus(int bab)
        {
            string formattedBonus = "";
            int attacks = bab / 5;
            //was having a bit of diffulty forcing the number of extra attacks so forcing the math to work with this if statement
            if ((bab % 5 == 0) && bab > 0) {
                attacks--;
            }
            formattedBonus = "+" + bab;
            for (int i = 1; i <= attacks; i++) {
                int secondaryAttack = bab - (5 * i);
                formattedBonus += " / +" + secondaryAttack;
            }
            return formattedBonus + "\t";
        }
    }
}
