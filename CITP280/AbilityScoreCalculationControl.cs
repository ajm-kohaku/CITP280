using CITP280.util;
using System;
using System.Windows.Forms;

using static CITP280.util.TextBoxValidator;

namespace CITP280
{
    /**
     The purpose of this class is to create a template for modifying ability scores.
        The BaseAbilityScore represents the raw number for the ability score before any other modifiers are applied
        The EnhancementScore represents the value of a magical enhancement bonus to the abililty score. 
            This is usually due to a magical item worn by the character and is typically considered permanent.
        The InherentScore represents a bonus to the total score from an inherent source such those granted by race, feat, or a wish.
        The TempScore represents a bonus to the total score from a temporary source. For instance a spell cast with a short duration.
        The PenaltyScore represents a penalty to the total score. These penalties are usually temporary but can last for long periods of time.
            For example, becoming fatigued or exhausted for multiple days before a full rest is possible.
         */
    public partial class AbilityScoreCalculationControl : UserControl
    {
        //define field labels so that they can be used oustide the control
        public string CstmTxt_AbilityAbbrvLabelText {
            get => AbilityAbbrvLabel.Text;
            set => AbilityAbbrvLabel.Text = value;
        }

        public string CstmTxt_AbilityTotalText {
            get => AbilityTotalLabel.Text;
            set => AbilityTotalLabel.Text = value;
        }

        public string CstmTxt_AbilityModText {
            get => AbilityModTextBox.Text;
            set => AbilityModTextBox.Text = value;
        }

        public string CstmTxt_BaseAbilityScoreText {
            get => BaseAbilityScoreTextBox.Text;
            set => BaseAbilityScoreTextBox.Text = value;
        }

        public string CstmTxt_EnhancementScoreText {
            get => EnhancementScoreTextBox.Text;
            set => EnhancementScoreTextBox.Text = value;
        }

        public string CstmTxt_InherentScoreText {
            get => InherentScoreTextBox.Text;
            set => InherentScoreTextBox.Text = value;
        }

        public string CstmTxt_TempScoreText {
            get => TempScoreTextBox.Text;
            set => TempScoreTextBox.Text = value;
        }

        public string CstmTxt_PenaltyScoreText {
            get => PenaltyScoreTextBox.Text;
            set => PenaltyScoreTextBox.Text = value;
        }


        //creating delagate for tracking an ability score change event.
        public delegate void AbilityScoreChangedEventHandler(object sender, AbilityScoreChangedEventArgs e);
        //the ability score change event
        public event AbilityScoreChangedEventHandler AbilityScoreChanged;


        public AbilityScoreCalculationControl()
        {
            InitializeComponent();

        }

        /// <summary>
        /// When the control loads, default the AbilityMod as if the Total score was 0
        /// </summary>
        private void AbilityScoreCalculationControl_Load(object sender, EventArgs e)
        {
            AbilityModTextBox.Text = AbilityModifierCalculation(0);
        }

        /// <summary>
        /// Raising event when the ability score is changed. This will report the Ability Score Modifier.
        /// The modifier is used across the app to apply bonuses to other features and effects the character wishes to perform.
        /// </summary>
        /// <param name="e">Takes the ability score and provides the ability modifier value</param>
        protected virtual void OnAbilityScoreChanged(AbilityScoreChangedEventArgs e)
        {

            if (AbilityScoreChanged != null)
            {
                e.ModifierString = AbilityModifierCalculation(e.Score);
                AbilityScoreChanged(this, e);
            }
        }

        /// <summary>
        /// Listener when the ability score changes. This triggers the OnAbilityScoreChanged event.
        /// </summary>
        private void AbilityTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(AbilityTotalLabel.Text, out int score);
            AbilityScoreChangedEventArgs args = new AbilityScoreChangedEventArgs() { Score = score };
            OnAbilityScoreChanged(args);

        }

        /// <summary>
        /// Listener to multiple TextChanged events. This method takes the aggregate of these chagnes and updates the Total Score
        /// </summary>
        private void AbilityAggregateScore_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(BaseAbilityScoreTextBox.Text, out int baseScore);
            Int32.TryParse(EnhancementScoreTextBox.Text, out int enhanceScore);
            Int32.TryParse(InherentScoreTextBox.Text, out int inherentScore);
            Int32.TryParse(TempScoreTextBox.Text, out int tempScore);
            Int32.TryParse(PenaltyScoreTextBox.Text, out int penaltyScore1);
            int penaltyScore = 0;
            
            //if the penalty text is not empty, check if it's a number, otherwise do nothing. //todo: make this check common for all score text boxes
            try
            {
                if (PenaltyScoreTextBox.Text.Length > 0)
                {
                    penaltyScore = Int32.Parse(PenaltyScoreTextBox.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Penalty Score is an invalid number. Please correct and try again");

            }
            int total = baseScore + enhanceScore + inherentScore + tempScore - penaltyScore;
            AbilityTotalLabel.Text = total.ToString();
        }

        /// <summary>
        /// Calculates the value of the Ability modifier based on the passed in value.
        /// </summary>
        /// <param name="total"> Value of an Ability Score</param>
        /// <returns>The string value of the Ability Modifier</returns>
        private string AbilityModifierCalculation(Int32 total)
        {
            return Math.Max(-5, (total - 10) / 2).ToString();
        }

        private void BaseAbilityScoreTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(BaseAbilityScoreTextBox);
        }

        private void BaseAbilityScoreTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(BaseAbilityScoreTextBox);
        }

        private void EnhancementScoreTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(EnhancementScoreTextBox);
        }

        private void EnhancementScoreTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(EnhancementScoreTextBox);
        }

        private void InherentScoreTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(InherentScoreTextBox);
        }

        private void InherentScoreTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(InherentScoreTextBox);
        }

        private void TempScoreTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(TempScoreTextBox);
        }

        private void TempScoreTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(TempScoreTextBox);
        }

        private void PenaltyScoreTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(PenaltyScoreTextBox);
        }

        private void PenaltyScoreTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(PenaltyScoreTextBox);
        }

        public void ClearControl()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
            }

            AbilityTotalLabel.Text = null;
        }
    }
}
