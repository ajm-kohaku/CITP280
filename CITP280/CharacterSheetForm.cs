using CITP280.data;
using CITP280.playerclass;
using CITP280.util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CITP280
{
    public partial class CharacterSheetForm : Form
    {
        //create list list of playable classes
        private List<IPlayableClass> playableClasses;

        //gets the directory the program is being executed from
        private string exeDirectory = Path.GetDirectoryName(new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath);
        //provides file name for the character sheet
        private string characterSheetFileName = "character-sheet.txt";
        //holds the fully qualified path to the character sheet file.
        private string characterSheetFullPath;
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

            characterSheetFullPath = Path.Combine(exeDirectory, characterSheetFileName);
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


        //when save button is clicked. add form data to data object and save to json file
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //parse integers for all of the scores
            Int32.TryParse(StrengthScoreControl.CstmTxt_BaseAbilityScoreText, out int strengthBaseScore);
            Int32.TryParse(StrengthScoreControl.CstmTxt_EnhancementScoreText, out int strengthEnhancementScore);
            Int32.TryParse(StrengthScoreControl.CstmTxt_InherentScoreText, out int strengthInherentScore);
            Int32.TryParse(StrengthScoreControl.CstmTxt_TempScoreText, out int strengthTempScore);
            Int32.TryParse(StrengthScoreControl.CstmTxt_PenaltyScoreText, out int strengthPenaltyScore);

            Int32.TryParse(DexterityScoreControl.CstmTxt_BaseAbilityScoreText, out int dexterityBaseScore);
            Int32.TryParse(DexterityScoreControl.CstmTxt_EnhancementScoreText, out int dexterityEnhancementScore);
            Int32.TryParse(DexterityScoreControl.CstmTxt_InherentScoreText, out int dexterityInherentScore);
            Int32.TryParse(DexterityScoreControl.CstmTxt_TempScoreText, out int dexterityTempScore);
            Int32.TryParse(DexterityScoreControl.CstmTxt_PenaltyScoreText, out int dexterityPenaltyScore);

            Int32.TryParse(ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText, out int constitutionBaseScore);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_EnhancementScoreText, out int constitutionEnhancementScore);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_InherentScoreText, out int constitutionInherentScore);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_TempScoreText, out int constitutionTempScore);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_PenaltyScoreText, out int constitutionPenaltyScore);

            Int32.TryParse(IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText, out int intelligenceBaseScore);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_EnhancementScoreText, out int intelligenceEnhancementScore);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_InherentScoreText, out int intelligenceInherentScore);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_TempScoreText, out int intelligenceTempScore);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_PenaltyScoreText, out int intelligencePenaltyScore);

            Int32.TryParse(WisdomScoreControl.CstmTxt_BaseAbilityScoreText, out int wisdomBaseScore);
            Int32.TryParse(WisdomScoreControl.CstmTxt_EnhancementScoreText, out int wisdomEnhancementScore);
            Int32.TryParse(WisdomScoreControl.CstmTxt_InherentScoreText, out int wisdomInherentScore);
            Int32.TryParse(WisdomScoreControl.CstmTxt_TempScoreText, out int wisdomTempScore);
            Int32.TryParse(WisdomScoreControl.CstmTxt_PenaltyScoreText, out int wisdomPenaltyScore);

            Int32.TryParse(CharismaScoreControl.CstmTxt_BaseAbilityScoreText, out int charismaBaseScore);
            Int32.TryParse(CharismaScoreControl.CstmTxt_EnhancementScoreText, out int charismaEnhancementScore);
            Int32.TryParse(CharismaScoreControl.CstmTxt_InherentScoreText, out int charismaInherentScore);
            Int32.TryParse(CharismaScoreControl.CstmTxt_TempScoreText, out int charismaTempScore);
            Int32.TryParse(CharismaScoreControl.CstmTxt_PenaltyScoreText, out int charismaPenaltyScore);

            Int32.TryParse(DamageTakenTextBox.Text, out int damageTaken);
            Int32.TryParse(lblClass1HealthFromLevel.Text, out int maxHealth);
            Int32.TryParse(tbClass1Level.Text, out int classLevel);
            Int32.TryParse(tbClass1FavoredClassSkills.Text, out int favoredClassSkillCount);
            Int32.TryParse(tbClass1FavoredClassHitPoints.Text, out int favoredClassHitPointsCount);
            Int32.TryParse(tbClass1FavoredClassOther.Text, out int favoredClassOtherCount);


            //create character sheet data object to generate a file
            CharacterSheetData characterSheet = new CharacterSheetData();
            characterSheet.PlayerClassName = cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem);
            characterSheet.DamageTaken = damageTaken;
            characterSheet.MaxHealth = maxHealth;
            characterSheet.PlayerClassLevel = classLevel;
            characterSheet.FavoredClassSkillCount = favoredClassSkillCount;
            characterSheet.FavoredClassHealthCount = favoredClassHitPointsCount;
            characterSheet.FavoredClassOtherCount = favoredClassOtherCount;

            characterSheet.Strength = new AbilityData()
            {
                AbilityName = CoreAttributes.STRENGTH,
                BaseScore = strengthBaseScore,
                EnhancementScore = strengthEnhancementScore,
                InherentScore = strengthInherentScore,
                TempScore = strengthTempScore,
                PenaltyScore = strengthPenaltyScore
            };

            characterSheet.Dexterity = new AbilityData()
            {
                AbilityName = CoreAttributes.DEXTERITY,
                BaseScore = dexterityBaseScore,
                EnhancementScore = dexterityEnhancementScore,
                InherentScore = dexterityInherentScore,
                TempScore = dexterityTempScore,
                PenaltyScore = dexterityPenaltyScore
            };

            characterSheet.Constitution = new AbilityData()
            {
                AbilityName = CoreAttributes.CONSTITUTION,
                BaseScore = constitutionBaseScore,
                EnhancementScore = constitutionEnhancementScore,
                InherentScore = constitutionInherentScore,
                TempScore = constitutionTempScore,
                PenaltyScore = constitutionPenaltyScore
            };

            characterSheet.Intelligence = new AbilityData()
            {
                AbilityName = CoreAttributes.INTELLIGENCE,
                BaseScore = intelligenceBaseScore,
                EnhancementScore = intelligenceEnhancementScore,
                InherentScore = intelligenceInherentScore,
                TempScore = intelligenceTempScore,
                PenaltyScore = intelligencePenaltyScore
            };

            characterSheet.Wisdom = new AbilityData()
            {
                AbilityName = CoreAttributes.WISDOM,
                BaseScore = wisdomBaseScore,
                EnhancementScore = wisdomEnhancementScore,
                InherentScore = wisdomInherentScore,
                TempScore = wisdomTempScore,
                PenaltyScore = wisdomPenaltyScore
            };

            characterSheet.Charisma = new AbilityData()
            {
                AbilityName = CoreAttributes.CHARISMA,
                BaseScore = charismaBaseScore,
                EnhancementScore = charismaEnhancementScore,
                InherentScore = charismaInherentScore,
                TempScore = charismaTempScore,
                PenaltyScore = charismaPenaltyScore
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(characterSheetFullPath, JsonConvert.SerializeObject(characterSheet, Formatting.Indented));
            
        }

        //when clicked, display file contents from the file to the richTextBox
        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            
            characterSheetRichText.Text = File.ReadAllText(characterSheetFullPath); 
        }
    }
}
