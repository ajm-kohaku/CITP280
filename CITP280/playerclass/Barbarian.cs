using CITP280.util;
using System;
using System.Collections.Generic;

namespace CITP280.playerclass
{
    public class Barbarian : BaseClass
    {
        public override string className => "Barbarian";

        public override BaseAttackScale baseAttack => BaseAttackScale.FULL;

        public override SavesScale fortitudeScale => SavesScale.GOOD;

        public override SavesScale reflexScale => SavesScale.POOR;

        public override SavesScale willScale => SavesScale.POOR;

        public override int skillRanksPerLevel => 4;

        public override int dieType => 12;

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Acrobatics");
            skills.Add("Climb");
            skills.Add("Craft");
            skills.Add("Handle Animal");
            skills.Add("Intimidate");
            skills.Add("Knowledge (Nature)");
            skills.Add("Perception");
            skills.Add("Ride");
            skills.Add("Survival");
            skills.Add("Swim");
            return skills;
        }

        public override List<string> GetClassAbilitiesTableList()
        {
            List<string> abilities = new List<string>();
            for (int i = 1; i <= maxLevel; i++)
            {
                List<string> abilityRow = new List<string>();
                if (!string.IsNullOrEmpty(GetDescription(i, FastMovement().classTableDescription)))
                {
                    abilityRow.Add(GetDescription(i, FastMovement().classTableDescription));
                }
                if (!string.IsNullOrEmpty(GetDescription(i, Rage().classTableDescription)))
                {
                    abilityRow.Add(GetDescription(i, Rage().classTableDescription));
                }
                if (!string.IsNullOrEmpty(GetDescription(i, RagePower().classTableDescription)))
                {
                    abilityRow.Add(GetDescription(i, RagePower().classTableDescription));
                }
                if (!string.IsNullOrEmpty(GetDescription(i, TrapSense().classTableDescription)))
                {
                    abilityRow.Add(GetDescription(i, TrapSense().classTableDescription));
                }
                abilities.Add(string.Join(", ", abilityRow));
            }
            return abilities;
        }

        private string GetDescription(int index, Dictionary<int, string> description)
        {
            string value = "";
            if (description != null && description.ContainsKey(index))
            {
                description.TryGetValue(index, out value);
            }
            return value;
        }

        public CharacterAbility WeaponAndArmorProficiency()
        {
            CharacterAbility ability = new CharacterAbility();
            ability.name = "Weapon and Armor Proficiency";
            ability.description = "A barbarian is proficient with all simple and martial weapons, light armor, medium armor, and shields (except tower shields).";
            //this ability does not typically display in the class summary table
            return ability;
        }

        public CharacterAbility FastMovement()
        {
            CharacterAbility ability = new CharacterAbility
            {
                name = "Fast Movement",
                description = "A barbarian’s land speed is faster than the norm for her race by +10 feet. " +
                "This benefit applies only when he is wearing no armor, light armor, or medium armor, and not carrying a heavy load." +
                " Apply this bonus before modifying the barbarian’s speed because of any load carried or armor worn. " +
                "This bonus stacks with any other bonuses to the barbarian’s land speed.",
                //displayed on the table only at level 1
                classTableDescription = new Dictionary<int, String>()
            };
            ability.classTableDescription.Add(1, "Fast Movement");
            return ability;
        }

        public CharacterAbility Rage()
        {
            CharacterAbility ability = new CharacterAbility();
            ability.name = "Rage";
            ability.description = "A barbarian can call upon inner reserves of strength and ferocity, granting her additional combat prowess. " +
                "Starting at 1st level, a barbarian can rage for a number of rounds per day equal to 4 + her Constitution modifier. " +
                "At each level after 1st, she can rage for 2 additional rounds. " +
                "Temporary increases to Constitution, such as those gained from rage and spells like bear’s endurance, do not increase the total number of rounds that a barbarian can rage per day. " +
                "A barbarian can enter rage as a free action. The total number of rounds of rage per day is renewed after resting for 8 hours, although these hours do not need to be consecutive.\n\n" +
                "While in rage, a barbarian gains a +4 morale bonus to her Strength and Constitution, as well as a + 2 morale bonus on Will saves.In addition, she takes a –2 penalty to Armor Class. " +
                "The increase to Constitution grants the barbarian 2 hit points per Hit Dice, but these disappear when the rage ends and are not lost first like temporary hit points. " +
                "While in rage, a barbarian cannot use any Charisma-, Dexterity -, or Intelligence-based skills(except Acrobatics, Fly, Intimidate, and Ride) or any ability that requires patience or concentration." +
                "\n\nA barbarian can end her rage as a free action and is fatigued after rage for a number of rounds equal to 2 times the number of rounds spent in the rage.\n\n" +
                "A barbarian cannot enter a new rage while fatigued or exhausted but can otherwise enter rage multiple times during a single encounter or combat. " +
                "If a barbarian falls unconscious, her rage immediately ends, placing her in peril of death.";
            //displayed on the table only at level 1
            ability.classTableDescription = new Dictionary<int, String>();
            ability.classTableDescription.Add(1, "Rage");
            return ability;
        }

        public CharacterAbility RagePower()
        {
            CharacterAbility ability = new CharacterAbility();
            ability.name = "Rage Power";
            ability.description = "A barbarian’s land speed is faster than the norm for her race by +10 feet. " +
                "This benefit applies only when he is wearing no armor, light armor, or medium armor, and not carrying a heavy load." +
                " Apply this bonus before modifying the barbarian’s speed because of any load carried or armor worn. " +
                "This bonus stacks with any other bonuses to the barbarian’s land speed.";

            ability.classTableDescription = new Dictionary<int, String>();
            //display on the table at even levels
            for (int i = 0; i < maxLevel; i++)
            {
                if (i % 2 == 0)
                {
                    ability.classTableDescription.Add(i, "Rage Power");
                }
            }

            return ability;
        }

        public CharacterAbility TrapSense()
        {
            CharacterAbility ability = new CharacterAbility();
            ability.name = "Trap Sense";
            ability.description = "Some description about trap sense";

            ability.classTableDescription = new Dictionary<int, String>();
            //display on the table every 3rd level.
            for (int i = 0; i < maxLevel; i++)
            {
                if (i % 3 == 0)
                {
                    ability.classTableDescription.Add(i, "Trap Sense +" + (i / 3));
                }
            }

            return ability;
        }
    }
}
