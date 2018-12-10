namespace CITP280
{
    partial class CharacterSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSheetForm));
            this.lblAbilitiesSection = new System.Windows.Forms.Label();
            this.lblAbilityName = new System.Windows.Forms.Label();
            this.lblAbilityScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.DamageTakenTextBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.lblClass1HealthFromLevel = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.lblClass1HitDice = new System.Windows.Forms.Label();
            this.cbClassNames1 = new System.Windows.Forms.ComboBox();
            this.lblClass1Bab = new System.Windows.Forms.Label();
            this.lblClass1Fort = new System.Windows.Forms.Label();
            this.lblClass1Will = new System.Windows.Forms.Label();
            this.lblClass1Ref = new System.Windows.Forms.Label();
            this.lblClass1Skills = new System.Windows.Forms.Label();
            this.tbClass1FavoredClassSkills = new System.Windows.Forms.TextBox();
            this.tbClass1FavoredClassHitPoints = new System.Windows.Forms.TextBox();
            this.tbClass1Level = new System.Windows.Forms.TextBox();
            this.tbClass1FavoredClassOther = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.tbCurrentHealth = new System.Windows.Forms.TextBox();
            this.tbClass2Level = new System.Windows.Forms.TextBox();
            this.tbClass2FavoredClassOther = new System.Windows.Forms.TextBox();
            this.tbClass2FavoredClassHitPoints = new System.Windows.Forms.TextBox();
            this.tbClass2FavoredClassSkills = new System.Windows.Forms.TextBox();
            this.lblClass2Skills = new System.Windows.Forms.Label();
            this.lblClass2Will = new System.Windows.Forms.Label();
            this.lblClass2Ref = new System.Windows.Forms.Label();
            this.lblClass2Fort = new System.Windows.Forms.Label();
            this.lblClass2Bab = new System.Windows.Forms.Label();
            this.cbClassNames2 = new System.Windows.Forms.ComboBox();
            this.lblClass2HitDice = new System.Windows.Forms.Label();
            this.lblClass2HealthFromLevel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CharismaScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.WisdomScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.IntelligenceScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.ConstitutionScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.DexterityScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.StrengthScoreControl = new CITP280.AbilityScoreCalculationControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbilitiesSection
            // 
            this.lblAbilitiesSection.BackColor = System.Drawing.Color.Black;
            this.lblAbilitiesSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbilitiesSection.ForeColor = System.Drawing.Color.White;
            this.lblAbilitiesSection.Location = new System.Drawing.Point(388, 195);
            this.lblAbilitiesSection.Name = "lblAbilitiesSection";
            this.lblAbilitiesSection.Size = new System.Drawing.Size(395, 23);
            this.lblAbilitiesSection.TabIndex = 0;
            this.lblAbilitiesSection.Text = "Abilities";
            this.lblAbilitiesSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbilityName
            // 
            this.lblAbilityName.BackColor = System.Drawing.Color.Transparent;
            this.lblAbilityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbilityName.ForeColor = System.Drawing.Color.White;
            this.lblAbilityName.Location = new System.Drawing.Point(396, 220);
            this.lblAbilityName.Margin = new System.Windows.Forms.Padding(1);
            this.lblAbilityName.Name = "lblAbilityName";
            this.lblAbilityName.Size = new System.Drawing.Size(40, 15);
            this.lblAbilityName.TabIndex = 1;
            this.lblAbilityName.Text = "Ability";
            this.lblAbilityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbilityScore
            // 
            this.lblAbilityScore.BackColor = System.Drawing.Color.Transparent;
            this.lblAbilityScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbilityScore.ForeColor = System.Drawing.Color.White;
            this.lblAbilityScore.Location = new System.Drawing.Point(443, 220);
            this.lblAbilityScore.Margin = new System.Windows.Forms.Padding(1);
            this.lblAbilityScore.Name = "lblAbilityScore";
            this.lblAbilityScore.Size = new System.Drawing.Size(40, 15);
            this.lblAbilityScore.TabIndex = 13;
            this.lblAbilityScore.Text = "Score";
            this.lblAbilityScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modifier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(528, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Base";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(575, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Enhance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(623, 220);
            this.label22.Margin = new System.Windows.Forms.Padding(1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 49;
            this.label22.Text = "Inherent";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(677, 220);
            this.label29.Margin = new System.Windows.Forms.Padding(1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 15);
            this.label29.TabIndex = 62;
            this.label29.Text = "Temp";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(725, 220);
            this.label36.Margin = new System.Windows.Forms.Padding(1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(42, 15);
            this.label36.TabIndex = 75;
            this.label36.Text = "Penalty";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.Salmon;
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(499, 126);
            this.label39.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(84, 32);
            this.label39.TabIndex = 91;
            this.label39.Text = "Health";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DamageTakenTextBox
            // 
            this.DamageTakenTextBox.BackColor = System.Drawing.Color.LightPink;
            this.DamageTakenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DamageTakenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DamageTakenTextBox.Location = new System.Drawing.Point(591, 126);
            this.DamageTakenTextBox.Name = "DamageTakenTextBox";
            this.DamageTakenTextBox.Size = new System.Drawing.Size(110, 32);
            this.DamageTakenTextBox.TabIndex = 92;
            this.DamageTakenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DamageTakenTextBox.TextChanged += new System.EventHandler(this.UpdateCurrentHealth);
            this.DamageTakenTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DamageTakenTextBox_Validating);
            this.DamageTakenTextBox.Validated += new System.EventHandler(this.DamageTakenTextBox_Validated);
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Red;
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(701, 126);
            this.label40.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 32);
            this.label40.TabIndex = 93;
            this.label40.Text = "Damage";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1HealthFromLevel
            // 
            this.lblClass1HealthFromLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1HealthFromLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1HealthFromLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1HealthFromLevel.Location = new System.Drawing.Point(389, 65);
            this.lblClass1HealthFromLevel.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1HealthFromLevel.Name = "lblClass1HealthFromLevel";
            this.lblClass1HealthFromLevel.Size = new System.Drawing.Size(50, 21);
            this.lblClass1HealthFromLevel.TabIndex = 101;
            this.lblClass1HealthFromLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClass1HealthFromLevel.TextChanged += new System.EventHandler(this.UpdateCurrentHealth);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(392, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 9);
            this.label47.TabIndex = 102;
            this.label47.Text = "HP from lvl";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(439, 55);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(17, 9);
            this.label52.TabIndex = 106;
            this.label52.Text = "HD";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1HitDice
            // 
            this.lblClass1HitDice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1HitDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1HitDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1HitDice.Location = new System.Drawing.Point(440, 65);
            this.lblClass1HitDice.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1HitDice.Name = "lblClass1HitDice";
            this.lblClass1HitDice.Size = new System.Drawing.Size(21, 21);
            this.lblClass1HitDice.TabIndex = 105;
            this.lblClass1HitDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbClassNames1
            // 
            this.cbClassNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassNames1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassNames1.FormattingEnabled = true;
            this.cbClassNames1.IntegralHeight = false;
            this.cbClassNames1.Location = new System.Drawing.Point(462, 65);
            this.cbClassNames1.Margin = new System.Windows.Forms.Padding(1);
            this.cbClassNames1.Name = "cbClassNames1";
            this.cbClassNames1.Size = new System.Drawing.Size(120, 21);
            this.cbClassNames1.Sorted = true;
            this.cbClassNames1.TabIndex = 109;
            this.cbClassNames1.SelectedIndexChanged += new System.EventHandler(this.ClassNames1_SelectedIndexChanged);
            // 
            // lblClass1Bab
            // 
            this.lblClass1Bab.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1Bab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1Bab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1Bab.Location = new System.Drawing.Point(583, 65);
            this.lblClass1Bab.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1Bab.Name = "lblClass1Bab";
            this.lblClass1Bab.Size = new System.Drawing.Size(21, 20);
            this.lblClass1Bab.TabIndex = 115;
            this.lblClass1Bab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1Fort
            // 
            this.lblClass1Fort.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1Fort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1Fort.Location = new System.Drawing.Point(605, 65);
            this.lblClass1Fort.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1Fort.Name = "lblClass1Fort";
            this.lblClass1Fort.Size = new System.Drawing.Size(21, 20);
            this.lblClass1Fort.TabIndex = 116;
            this.lblClass1Fort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1Will
            // 
            this.lblClass1Will.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1Will.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1Will.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1Will.Location = new System.Drawing.Point(649, 65);
            this.lblClass1Will.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1Will.Name = "lblClass1Will";
            this.lblClass1Will.Size = new System.Drawing.Size(21, 20);
            this.lblClass1Will.TabIndex = 118;
            this.lblClass1Will.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1Ref
            // 
            this.lblClass1Ref.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1Ref.Location = new System.Drawing.Point(627, 65);
            this.lblClass1Ref.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1Ref.Name = "lblClass1Ref";
            this.lblClass1Ref.Size = new System.Drawing.Size(21, 20);
            this.lblClass1Ref.TabIndex = 117;
            this.lblClass1Ref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass1Skills
            // 
            this.lblClass1Skills.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass1Skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass1Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass1Skills.Location = new System.Drawing.Point(671, 65);
            this.lblClass1Skills.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass1Skills.Name = "lblClass1Skills";
            this.lblClass1Skills.Size = new System.Drawing.Size(21, 20);
            this.lblClass1Skills.TabIndex = 119;
            this.lblClass1Skills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbClass1FavoredClassSkills
            // 
            this.tbClass1FavoredClassSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass1FavoredClassSkills.Location = new System.Drawing.Point(693, 65);
            this.tbClass1FavoredClassSkills.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass1FavoredClassSkills.Name = "tbClass1FavoredClassSkills";
            this.tbClass1FavoredClassSkills.Size = new System.Drawing.Size(21, 20);
            this.tbClass1FavoredClassSkills.TabIndex = 120;
            // 
            // tbClass1FavoredClassHitPoints
            // 
            this.tbClass1FavoredClassHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass1FavoredClassHitPoints.Location = new System.Drawing.Point(715, 65);
            this.tbClass1FavoredClassHitPoints.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass1FavoredClassHitPoints.Name = "tbClass1FavoredClassHitPoints";
            this.tbClass1FavoredClassHitPoints.Size = new System.Drawing.Size(21, 20);
            this.tbClass1FavoredClassHitPoints.TabIndex = 121;
            // 
            // tbClass1Level
            // 
            this.tbClass1Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass1Level.Location = new System.Drawing.Point(759, 65);
            this.tbClass1Level.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass1Level.Name = "tbClass1Level";
            this.tbClass1Level.Size = new System.Drawing.Size(21, 20);
            this.tbClass1Level.TabIndex = 123;
            this.tbClass1Level.TextChanged += new System.EventHandler(this.Class1Level_TextChanged);
            this.tbClass1Level.Validating += new System.ComponentModel.CancelEventHandler(this.tbClass1Level_Validating);
            this.tbClass1Level.Validated += new System.EventHandler(this.tbClass1Level_Validated);
            // 
            // tbClass1FavoredClassOther
            // 
            this.tbClass1FavoredClassOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass1FavoredClassOther.Location = new System.Drawing.Point(737, 65);
            this.tbClass1FavoredClassOther.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass1FavoredClassOther.Name = "tbClass1FavoredClassOther";
            this.tbClass1FavoredClassOther.Size = new System.Drawing.Size(21, 20);
            this.tbClass1FavoredClassOther.TabIndex = 122;
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(385, 24);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(393, 23);
            this.label69.TabIndex = 142;
            this.label69.Text = "Class Recorder";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(459, 55);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(120, 9);
            this.label70.TabIndex = 143;
            this.label70.Text = "Class";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(604, 55);
            this.label72.Margin = new System.Windows.Forms.Padding(0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(16, 7);
            this.label72.TabIndex = 145;
            this.label72.Text = "Fort";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(582, 55);
            this.label71.Margin = new System.Windows.Forms.Padding(0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(19, 7);
            this.label71.TabIndex = 146;
            this.label71.Text = "BAB";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(623, 55);
            this.label73.Margin = new System.Windows.Forms.Padding(0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(15, 7);
            this.label73.TabIndex = 148;
            this.label73.Text = "Ref";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(641, 55);
            this.label74.Margin = new System.Windows.Forms.Padding(0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(17, 7);
            this.label74.TabIndex = 147;
            this.label74.Text = "Will";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(710, 55);
            this.label75.Margin = new System.Windows.Forms.Padding(0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(20, 7);
            this.label75.TabIndex = 152;
            this.label75.Text = "FC H";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(733, 55);
            this.label76.Margin = new System.Windows.Forms.Padding(0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(20, 7);
            this.label76.TabIndex = 151;
            this.label76.Text = "FC O";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(661, 55);
            this.label77.Margin = new System.Windows.Forms.Padding(0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(23, 7);
            this.label77.TabIndex = 150;
            this.label77.Text = "Skills";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(756, 55);
            this.label79.Margin = new System.Windows.Forms.Padding(0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(22, 7);
            this.label79.TabIndex = 153;
            this.label79.Text = "Level";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(687, 55);
            this.label78.Margin = new System.Windows.Forms.Padding(0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(20, 7);
            this.label78.TabIndex = 149;
            this.label78.Text = "FC S";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentHealth
            // 
            this.tbCurrentHealth.BackColor = System.Drawing.Color.MistyRose;
            this.tbCurrentHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentHealth.Enabled = false;
            this.tbCurrentHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbCurrentHealth.Location = new System.Drawing.Point(389, 126);
            this.tbCurrentHealth.Name = "tbCurrentHealth";
            this.tbCurrentHealth.ReadOnly = true;
            this.tbCurrentHealth.Size = new System.Drawing.Size(110, 32);
            this.tbCurrentHealth.TabIndex = 233;
            this.tbCurrentHealth.Text = " / ";
            this.tbCurrentHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbClass2Level
            // 
            this.tbClass2Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass2Level.Location = new System.Drawing.Point(759, 88);
            this.tbClass2Level.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass2Level.Name = "tbClass2Level";
            this.tbClass2Level.Size = new System.Drawing.Size(21, 20);
            this.tbClass2Level.TabIndex = 256;
            this.tbClass2Level.TextChanged += new System.EventHandler(this.tbClass2Level_TextChanged);
            this.tbClass2Level.Validating += new System.ComponentModel.CancelEventHandler(this.tbClass2Level_Validating);
            this.tbClass2Level.Validated += new System.EventHandler(this.tbClass2Level_Validated);
            // 
            // tbClass2FavoredClassOther
            // 
            this.tbClass2FavoredClassOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass2FavoredClassOther.Location = new System.Drawing.Point(737, 88);
            this.tbClass2FavoredClassOther.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass2FavoredClassOther.Name = "tbClass2FavoredClassOther";
            this.tbClass2FavoredClassOther.Size = new System.Drawing.Size(21, 20);
            this.tbClass2FavoredClassOther.TabIndex = 255;
            // 
            // tbClass2FavoredClassHitPoints
            // 
            this.tbClass2FavoredClassHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass2FavoredClassHitPoints.Location = new System.Drawing.Point(715, 88);
            this.tbClass2FavoredClassHitPoints.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass2FavoredClassHitPoints.Name = "tbClass2FavoredClassHitPoints";
            this.tbClass2FavoredClassHitPoints.Size = new System.Drawing.Size(21, 20);
            this.tbClass2FavoredClassHitPoints.TabIndex = 254;
            // 
            // tbClass2FavoredClassSkills
            // 
            this.tbClass2FavoredClassSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass2FavoredClassSkills.Location = new System.Drawing.Point(693, 88);
            this.tbClass2FavoredClassSkills.Margin = new System.Windows.Forms.Padding(1);
            this.tbClass2FavoredClassSkills.Name = "tbClass2FavoredClassSkills";
            this.tbClass2FavoredClassSkills.Size = new System.Drawing.Size(21, 20);
            this.tbClass2FavoredClassSkills.TabIndex = 253;
            // 
            // lblClass2Skills
            // 
            this.lblClass2Skills.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2Skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2Skills.Location = new System.Drawing.Point(671, 88);
            this.lblClass2Skills.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2Skills.Name = "lblClass2Skills";
            this.lblClass2Skills.Size = new System.Drawing.Size(21, 20);
            this.lblClass2Skills.TabIndex = 252;
            this.lblClass2Skills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass2Will
            // 
            this.lblClass2Will.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2Will.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2Will.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2Will.Location = new System.Drawing.Point(649, 88);
            this.lblClass2Will.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2Will.Name = "lblClass2Will";
            this.lblClass2Will.Size = new System.Drawing.Size(21, 20);
            this.lblClass2Will.TabIndex = 251;
            this.lblClass2Will.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass2Ref
            // 
            this.lblClass2Ref.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2Ref.Location = new System.Drawing.Point(627, 88);
            this.lblClass2Ref.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2Ref.Name = "lblClass2Ref";
            this.lblClass2Ref.Size = new System.Drawing.Size(21, 20);
            this.lblClass2Ref.TabIndex = 250;
            this.lblClass2Ref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass2Fort
            // 
            this.lblClass2Fort.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2Fort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2Fort.Location = new System.Drawing.Point(605, 88);
            this.lblClass2Fort.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2Fort.Name = "lblClass2Fort";
            this.lblClass2Fort.Size = new System.Drawing.Size(21, 20);
            this.lblClass2Fort.TabIndex = 249;
            this.lblClass2Fort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass2Bab
            // 
            this.lblClass2Bab.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2Bab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2Bab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2Bab.Location = new System.Drawing.Point(583, 88);
            this.lblClass2Bab.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2Bab.Name = "lblClass2Bab";
            this.lblClass2Bab.Size = new System.Drawing.Size(21, 20);
            this.lblClass2Bab.TabIndex = 248;
            this.lblClass2Bab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbClassNames2
            // 
            this.cbClassNames2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassNames2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassNames2.FormattingEnabled = true;
            this.cbClassNames2.IntegralHeight = false;
            this.cbClassNames2.Location = new System.Drawing.Point(462, 88);
            this.cbClassNames2.Margin = new System.Windows.Forms.Padding(1);
            this.cbClassNames2.Name = "cbClassNames2";
            this.cbClassNames2.Size = new System.Drawing.Size(120, 21);
            this.cbClassNames2.Sorted = true;
            this.cbClassNames2.TabIndex = 247;
            this.cbClassNames2.SelectedIndexChanged += new System.EventHandler(this.cbClassNames2_SelectedIndexChanged);
            // 
            // lblClass2HitDice
            // 
            this.lblClass2HitDice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2HitDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2HitDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2HitDice.Location = new System.Drawing.Point(440, 88);
            this.lblClass2HitDice.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2HitDice.Name = "lblClass2HitDice";
            this.lblClass2HitDice.Size = new System.Drawing.Size(21, 21);
            this.lblClass2HitDice.TabIndex = 246;
            this.lblClass2HitDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass2HealthFromLevel
            // 
            this.lblClass2HealthFromLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClass2HealthFromLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass2HealthFromLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2HealthFromLevel.Location = new System.Drawing.Point(389, 88);
            this.lblClass2HealthFromLevel.Margin = new System.Windows.Forms.Padding(1);
            this.lblClass2HealthFromLevel.Name = "lblClass2HealthFromLevel";
            this.lblClass2HealthFromLevel.Size = new System.Drawing.Size(50, 21);
            this.lblClass2HealthFromLevel.TabIndex = 245;
            this.lblClass2HealthFromLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClass2HealthFromLevel.TextChanged += new System.EventHandler(this.UpdateCurrentHealth);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 257;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CharismaScoreControl
            // 
            this.CharismaScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.CharismaScoreControl.CstmTxt_AbilityAbbrvLabelText = "CHA";
            this.CharismaScoreControl.CstmTxt_AbilityModText = "-5";
            this.CharismaScoreControl.CstmTxt_AbilityTotalText = "0";
            this.CharismaScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.CharismaScoreControl.CstmTxt_EnhancementScoreText = "";
            this.CharismaScoreControl.CstmTxt_InherentScoreText = "";
            this.CharismaScoreControl.CstmTxt_PenaltyScoreText = "";
            this.CharismaScoreControl.CstmTxt_TempScoreText = "";
            this.CharismaScoreControl.Location = new System.Drawing.Point(391, 374);
            this.CharismaScoreControl.Name = "CharismaScoreControl";
            this.CharismaScoreControl.Size = new System.Drawing.Size(389, 32);
            this.CharismaScoreControl.TabIndex = 239;
            // 
            // WisdomScoreControl
            // 
            this.WisdomScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.WisdomScoreControl.CstmTxt_AbilityAbbrvLabelText = "WIS";
            this.WisdomScoreControl.CstmTxt_AbilityModText = "-5";
            this.WisdomScoreControl.CstmTxt_AbilityTotalText = "0";
            this.WisdomScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.WisdomScoreControl.CstmTxt_EnhancementScoreText = "";
            this.WisdomScoreControl.CstmTxt_InherentScoreText = "";
            this.WisdomScoreControl.CstmTxt_PenaltyScoreText = "";
            this.WisdomScoreControl.CstmTxt_TempScoreText = "";
            this.WisdomScoreControl.Location = new System.Drawing.Point(391, 346);
            this.WisdomScoreControl.Name = "WisdomScoreControl";
            this.WisdomScoreControl.Size = new System.Drawing.Size(389, 32);
            this.WisdomScoreControl.TabIndex = 238;
            // 
            // IntelligenceScoreControl
            // 
            this.IntelligenceScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.IntelligenceScoreControl.CstmTxt_AbilityAbbrvLabelText = "INT";
            this.IntelligenceScoreControl.CstmTxt_AbilityModText = "-5";
            this.IntelligenceScoreControl.CstmTxt_AbilityTotalText = "0";
            this.IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.IntelligenceScoreControl.CstmTxt_EnhancementScoreText = "";
            this.IntelligenceScoreControl.CstmTxt_InherentScoreText = "";
            this.IntelligenceScoreControl.CstmTxt_PenaltyScoreText = "";
            this.IntelligenceScoreControl.CstmTxt_TempScoreText = "";
            this.IntelligenceScoreControl.Location = new System.Drawing.Point(391, 318);
            this.IntelligenceScoreControl.Name = "IntelligenceScoreControl";
            this.IntelligenceScoreControl.Size = new System.Drawing.Size(389, 32);
            this.IntelligenceScoreControl.TabIndex = 237;
            // 
            // ConstitutionScoreControl
            // 
            this.ConstitutionScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.ConstitutionScoreControl.CstmTxt_AbilityAbbrvLabelText = "CON";
            this.ConstitutionScoreControl.CstmTxt_AbilityModText = "-5";
            this.ConstitutionScoreControl.CstmTxt_AbilityTotalText = "0";
            this.ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.ConstitutionScoreControl.CstmTxt_EnhancementScoreText = "";
            this.ConstitutionScoreControl.CstmTxt_InherentScoreText = "";
            this.ConstitutionScoreControl.CstmTxt_PenaltyScoreText = "";
            this.ConstitutionScoreControl.CstmTxt_TempScoreText = "";
            this.ConstitutionScoreControl.Location = new System.Drawing.Point(391, 290);
            this.ConstitutionScoreControl.Name = "ConstitutionScoreControl";
            this.ConstitutionScoreControl.Size = new System.Drawing.Size(389, 32);
            this.ConstitutionScoreControl.TabIndex = 236;
            // 
            // DexterityScoreControl
            // 
            this.DexterityScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.DexterityScoreControl.CstmTxt_AbilityAbbrvLabelText = "DEX";
            this.DexterityScoreControl.CstmTxt_AbilityModText = "-5";
            this.DexterityScoreControl.CstmTxt_AbilityTotalText = "0";
            this.DexterityScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.DexterityScoreControl.CstmTxt_EnhancementScoreText = "";
            this.DexterityScoreControl.CstmTxt_InherentScoreText = "";
            this.DexterityScoreControl.CstmTxt_PenaltyScoreText = "";
            this.DexterityScoreControl.CstmTxt_TempScoreText = "";
            this.DexterityScoreControl.Location = new System.Drawing.Point(391, 263);
            this.DexterityScoreControl.Name = "DexterityScoreControl";
            this.DexterityScoreControl.Size = new System.Drawing.Size(389, 32);
            this.DexterityScoreControl.TabIndex = 235;
            // 
            // StrengthScoreControl
            // 
            this.StrengthScoreControl.BackColor = System.Drawing.Color.Transparent;
            this.StrengthScoreControl.CstmTxt_AbilityAbbrvLabelText = "STR";
            this.StrengthScoreControl.CstmTxt_AbilityModText = "-5";
            this.StrengthScoreControl.CstmTxt_AbilityTotalText = "0";
            this.StrengthScoreControl.CstmTxt_BaseAbilityScoreText = "";
            this.StrengthScoreControl.CstmTxt_EnhancementScoreText = "";
            this.StrengthScoreControl.CstmTxt_InherentScoreText = "";
            this.StrengthScoreControl.CstmTxt_PenaltyScoreText = "";
            this.StrengthScoreControl.CstmTxt_TempScoreText = "";
            this.StrengthScoreControl.Location = new System.Drawing.Point(391, 234);
            this.StrengthScoreControl.Name = "StrengthScoreControl";
            this.StrengthScoreControl.Size = new System.Drawing.Size(389, 32);
            this.StrengthScoreControl.TabIndex = 234;
            // 
            // CharacterSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1126, 534);
            this.Controls.Add(this.tbClass2Level);
            this.Controls.Add(this.tbClass2FavoredClassOther);
            this.Controls.Add(this.tbClass2FavoredClassHitPoints);
            this.Controls.Add(this.tbClass2FavoredClassSkills);
            this.Controls.Add(this.lblClass2Skills);
            this.Controls.Add(this.lblClass2Will);
            this.Controls.Add(this.lblClass2Ref);
            this.Controls.Add(this.lblClass2Fort);
            this.Controls.Add(this.lblClass2Bab);
            this.Controls.Add(this.cbClassNames2);
            this.Controls.Add(this.lblClass2HitDice);
            this.Controls.Add(this.lblClass2HealthFromLevel);
            this.Controls.Add(this.CharismaScoreControl);
            this.Controls.Add(this.WisdomScoreControl);
            this.Controls.Add(this.IntelligenceScoreControl);
            this.Controls.Add(this.ConstitutionScoreControl);
            this.Controls.Add(this.DexterityScoreControl);
            this.Controls.Add(this.StrengthScoreControl);
            this.Controls.Add(this.tbCurrentHealth);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.tbClass1Level);
            this.Controls.Add(this.tbClass1FavoredClassOther);
            this.Controls.Add(this.tbClass1FavoredClassHitPoints);
            this.Controls.Add(this.tbClass1FavoredClassSkills);
            this.Controls.Add(this.lblClass1Skills);
            this.Controls.Add(this.lblClass1Will);
            this.Controls.Add(this.lblClass1Ref);
            this.Controls.Add(this.lblClass1Fort);
            this.Controls.Add(this.lblClass1Bab);
            this.Controls.Add(this.cbClassNames1);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.lblClass1HitDice);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.lblClass1HealthFromLevel);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.DamageTakenTextBox);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAbilityName);
            this.Controls.Add(this.lblAbilitiesSection);
            this.Controls.Add(this.lblAbilityScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CharacterSheetForm";
            this.Text = "CharacterSheetForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbilitiesSection;
        private System.Windows.Forms.Label lblAbilityName;
        private System.Windows.Forms.Label lblAbilityScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox DamageTakenTextBox;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblClass1HealthFromLevel;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label lblClass1HitDice;
        private System.Windows.Forms.ComboBox cbClassNames1;
        private System.Windows.Forms.Label lblClass1Bab;
        private System.Windows.Forms.Label lblClass1Fort;
        private System.Windows.Forms.Label lblClass1Will;
        private System.Windows.Forms.Label lblClass1Ref;
        private System.Windows.Forms.Label lblClass1Skills;
        private System.Windows.Forms.TextBox tbClass1FavoredClassSkills;
        private System.Windows.Forms.TextBox tbClass1FavoredClassHitPoints;
        private System.Windows.Forms.TextBox tbClass1Level;
        private System.Windows.Forms.TextBox tbClass1FavoredClassOther;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox tbCurrentHealth;
        private AbilityScoreCalculationControl StrengthScoreControl;
        private AbilityScoreCalculationControl DexterityScoreControl;
        private AbilityScoreCalculationControl ConstitutionScoreControl;
        private AbilityScoreCalculationControl IntelligenceScoreControl;
        private AbilityScoreCalculationControl WisdomScoreControl;
        private AbilityScoreCalculationControl CharismaScoreControl;
        private System.Windows.Forms.TextBox tbClass2Level;
        private System.Windows.Forms.TextBox tbClass2FavoredClassOther;
        private System.Windows.Forms.TextBox tbClass2FavoredClassHitPoints;
        private System.Windows.Forms.TextBox tbClass2FavoredClassSkills;
        private System.Windows.Forms.Label lblClass2Skills;
        private System.Windows.Forms.Label lblClass2Will;
        private System.Windows.Forms.Label lblClass2Ref;
        private System.Windows.Forms.Label lblClass2Fort;
        private System.Windows.Forms.Label lblClass2Bab;
        private System.Windows.Forms.ComboBox cbClassNames2;
        private System.Windows.Forms.Label lblClass2HitDice;
        private System.Windows.Forms.Label lblClass2HealthFromLevel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}