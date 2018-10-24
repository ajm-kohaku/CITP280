using CITP280.playerclass;
using CITP280.util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CITP280
{
    public partial class CharacterSheetForm : Form
    {
        //create list list of playable classes
        private List<IPlayableClass> playableClasses;

        public CharacterSheetForm()
        {
            InitializeComponent();

            //initialize ability score modifiers
            tbStrAbilityMod.Text = AbilityModifierCalculation(0);
            tbDexAbilityMod.Text = AbilityModifierCalculation(0);
            tbConAbilityMod.Text = AbilityModifierCalculation(0);
            tbIntAbilityMod.Text = AbilityModifierCalculation(0);
            tbWisAbilityMod.Text = AbilityModifierCalculation(0);
            tbChaAbilityMod.Text = AbilityModifierCalculation(0);
        }

        internal List<IPlayableClass> PlayableClasses {
            get {
                playableClasses = new List<IPlayableClass>
                {
                    new Barbarian(),
                    new Bard(),
                    new Cleric(),
                    new Fighter(),
                    new Monk(),
                    new Sorcerer()
                };
                return playableClasses;
            }
        }

        private void CharacterSheetForm_Load(object sender, EventArgs e)
        {
            //put list of playable classes into the class names drop down.
            foreach (IPlayableClass playable in PlayableClasses)
            {
                cbClassNames1.Items.Add(playable.className);
                cbClassNames2.Items.Add(playable.className);
                cbClassNames3.Items.Add(playable.className);
            }
        }

        private void StrengthTotal_TextChanged(object sender, System.EventArgs e)
        {

            if (Int32.TryParse(tbStrAbilityTotal.Text, out int strength))
            {
                tbStrAbilityMod.Text = AbilityModifierCalculation(strength);
            }
        }

        private void StrengthAggregateScore_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbStrBaseScore.Text, out int baseScore);
            Int32.TryParse(tbStrEnhanceScore.Text, out int enhanceScore);
            Int32.TryParse(tbStrInherentScore.Text, out int inherentScore);
            Int32.TryParse(tbStrTempScore.Text, out int tempScore);
            Int32.TryParse(tbStrPenaltyScore.Text, out int penaltyScore);
            int total = baseScore + enhanceScore + inherentScore + tempScore - penaltyScore;
            tbStrAbilityTotal.Text = total.ToString();
        }

        private void DexterityTotal_TextChanged(object sender, System.EventArgs e)
        {

            if (Int32.TryParse(tbDexAbilityTotal.Text, out int score))
            {
                tbDexAbilityMod.Text = AbilityModifierCalculation(score);
            }
        }

        private void DexterityAggregateScore_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbDexBaseScore.Text, out int baseScore);
            Int32.TryParse(tbDexEnhanceScore.Text, out int enhanceScore);
            Int32.TryParse(tbDexInherentScore.Text, out int inherentScore);
            Int32.TryParse(tbDexTempScore.Text, out int tempScore);
            Int32.TryParse(tbDexPenaltyScore.Text, out int penaltyScore);
            int total = baseScore + enhanceScore + inherentScore + tempScore - penaltyScore;
            tbDexAbilityTotal.Text = total.ToString();
        }

        private void ConstitutionTotal_TextChanged(object sender, System.EventArgs e)
        {

            if (Int32.TryParse(tbConAbilityTotal.Text, out int score))
            {
                tbConAbilityMod.Text = AbilityModifierCalculation(score);
                UpdateClass1HealthFromLevel();
                tbCurrentHealth.Text = GetCurrentHealth();
            }
        }
        private void ConstitutionAggregateScore_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbConBaseScore.Text, out int baseScore);
            Int32.TryParse(tbConEnhanceScore.Text, out int enhanceScore);
            Int32.TryParse(tbConInherentScore.Text, out int inherentScore);
            Int32.TryParse(tbConTempScore.Text, out int tempScore);
            Int32.TryParse(tbConPenaltyScore.Text, out int penaltyScore);
            int total = baseScore + enhanceScore + inherentScore + tempScore - penaltyScore;
            tbConAbilityTotal.Text = total.ToString();
        }

        private string AbilityModifierCalculation(Int32 total)
        {
            return Math.Max(-5, (total - 10) / 2).ToString();
        }

        private string GetCurrentHealthText()
        {
            string health = " / ";

            return health;
        }

        private void ClassNames1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbClass1Level.Text))
            {
                tbClass1Level.Text = "1";
            }
            ChangeClassStatisticsOnLevelChange(tbClass1Level);
        }

        private void Class1Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClassStatisticsOnLevelChange(tbClass1Level);
        }

        private void Class2Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClassStatisticsOnLevelChange(tbClass3Level);
        }

        private void Class3Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClassStatisticsOnLevelChange(tbClass3Level);
        }

        public void ChangeClassStatisticsOnLevelChange(TextBox classLevel)
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.className.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(classLevel.Text, out int level);
            Int32.TryParse(tbIntAbilityMod.Text, out int intMod);
            Int32.TryParse(tbConAbilityMod.Text, out int conMod);

            lblClass1Bab.Text = ScaleCalculations.GetBaseAttack(level, playableClass.baseAttack).ToString();
            lblClass1Fort.Text = ScaleCalculations.GetSave(level, playableClass.fortitudeScale).ToString();
            lblClass1Ref.Text = ScaleCalculations.GetSave(level, playableClass.reflexScale).ToString();
            lblClass1Will.Text = ScaleCalculations.GetSave(level, playableClass.willScale).ToString();
            lblClass1Skills.Text = (playableClass.skillRanksPerLevel + intMod).ToString();
            lblClass1HitDice.Text = playableClass.dieType.ToString();
            UpdateClass1HealthFromLevel();
            lblTotalClassLevels.Text = SumClassLevels().ToString();
            tbCurrentHealth.Text = GetCurrentHealth();
        }

        private void UpdateClass1HealthFromLevel()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.className.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(tbClass1Level.Text, out int level);
            Int32.TryParse(tbConAbilityMod.Text, out int conMod);
            lblClass1HealthFromLevel.Text = ((level * playableClass.dieType) + (level * conMod)).ToString();
        }

        private int SumClassLevels()
        {
            Int32.TryParse(tbClass1Level.Text, out int class1);
            Int32.TryParse(tbClass2Level.Text, out int class2);
            Int32.TryParse(tbClass3Level.Text, out int class3);
            return class1 + class2 + class3;
        }

        private string GetCurrentHealth()
        {
            Int32.TryParse(lblClass1HealthFromLevel.Text, out int class1);
            Int32.TryParse(lblClass2HealthFromLevel.Text, out int class2);
            Int32.TryParse(lblClass3HealthFromLevel.Text, out int class3);
            int totalHealth = class1 + class2 + class3;
            return " / " + totalHealth;
        }
    }
}
