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

            //the below subscribes to the AbilityScoreChanged event for each ability score
            this.StrengthScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Strength_AbilityScoreChanged);
            this.DexterityScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Dexterity_AbilityScoreChanged);
            this.ConstitutionScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Constitution_AbilityScoreChanged);
            this.IntelligenceScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Intelligence_AbilityScoreChanged);
            this.WisdomScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Wisdom_AbilityScoreChanged);
            this.CharismaScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Charisma_AbilityScoreChanged);

            //create list of playable classes
            playableClasses = new List<IPlayableClass>
                {
                    new Barbarian(),
                    new Bard(),
                    new Cleric(),
                    new Fighter(),
                    new Monk(),
                    new Sorcerer()
                };

            //for each playable class add the class's name to the classNames dropdown list
            foreach (IPlayableClass playable in playableClasses)
            {
                cbClassNames1.Items.Add(playable.ClassName);
            }
        }

        /// <summary>
        /// Listens for the index to change on the class names dropdown in the class recorder section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassNames1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbClass1Level.Text))
            {
                tbClass1Level.Text = "1";
            }
            ChangeClassStatisticsOnLevelChange();
        }

        // when the class level changes, update the class recorder statistics for that class
        private void Class1Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClassStatisticsOnLevelChange();
        }

        //
        public void ChangeClassStatisticsOnLevelChange()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(tbClass1Level.Text, out int level);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_AbilityModText, out int intMod);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);

            lblClass1Bab.Text = ScaleCalculations.GetBaseAttack(level, playableClass.BaseAttack).ToString();
            lblClass1Fort.Text = ScaleCalculations.GetSave(level, playableClass.FortitudeScale).ToString();
            lblClass1Ref.Text = ScaleCalculations.GetSave(level, playableClass.ReflexScale).ToString();
            lblClass1Will.Text = ScaleCalculations.GetSave(level, playableClass.WillScale).ToString();
            lblClass1Skills.Text = (playableClass.SkillRanksPerLevel + intMod).ToString();
            lblClass1HitDice.Text = playableClass.DieType.ToString();
            UpdateClass1HealthFromLevel();
        }

        //calculates the maximum number of hit points possible for selected class and class level
        private void UpdateClass1HealthFromLevel()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(tbClass1Level.Text, out int level);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);
            lblClass1HealthFromLevel.Text = ((level * playableClass.DieType) + (level * conMod)).ToString();
        }

        /// <summary>
        /// The followng Event listeners that update the Ability Modifier text box when the Ability total is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Strength_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            StrengthScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Dexterity_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            DexterityScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Constitution_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            ConstitutionScoreControl.CstmTxt_AbilityModText = e.ModifierString;
            //updates class health. todo://revamp this to make better use of events
           if (tbClass1Level.Text != null)
            {
                UpdateClass1HealthFromLevel();
            }
        }

        private void Intelligence_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            IntelligenceScoreControl.CstmTxt_AbilityModText = e.ModifierString;
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            lblClass1Skills.Text = (playableClass.SkillRanksPerLevel + e.Modifier).ToString();
        }

        private void Wisdom_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            WisdomScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Charisma_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            CharismaScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void UpdateCurrentHealth(object sender, EventArgs e)
        {
            Int32.TryParse(lblClass1HealthFromLevel.Text, out int class1);
            Int32.TryParse(DamageTakenTextBox.Text, out int damageTaken);
            int totalHealth = class1;
            int currentHealth = totalHealth - damageTaken;
            tbCurrentHealth.Text = currentHealth + " / " + totalHealth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
