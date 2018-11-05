namespace CITP280
{
    partial class AbilityScoreCalculationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PenaltyScoreTextBox = new System.Windows.Forms.TextBox();
            this.TempScoreTextBox = new System.Windows.Forms.TextBox();
            this.addSymbol3 = new System.Windows.Forms.Label();
            this.InherentScoreTextBox = new System.Windows.Forms.TextBox();
            this.EnhancementScoreTextBox = new System.Windows.Forms.TextBox();
            this.BaseAbilityScoreTextBox = new System.Windows.Forms.TextBox();
            this.AbilityModTextBox = new System.Windows.Forms.TextBox();
            this.AbilityTotalTextBox = new System.Windows.Forms.TextBox();
            this.AbilityAbbrvLabel = new System.Windows.Forms.Label();
            this.addSymbol1 = new System.Windows.Forms.Label();
            this.addSymbol2 = new System.Windows.Forms.Label();
            this.addSymbol4 = new System.Windows.Forms.Label();
            this.subtractSymbol1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PenaltyScoreTextBox
            // 
            this.PenaltyScoreTextBox.BackColor = System.Drawing.Color.LightPink;
            this.PenaltyScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PenaltyScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenaltyScoreTextBox.Location = new System.Drawing.Point(344, 5);
            this.PenaltyScoreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PenaltyScoreTextBox.MaxLength = 3;
            this.PenaltyScoreTextBox.Name = "PenaltyScoreTextBox";
            this.PenaltyScoreTextBox.Size = new System.Drawing.Size(35, 21);
            this.PenaltyScoreTextBox.TabIndex = 94;
            this.PenaltyScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PenaltyScoreTextBox.TextChanged += new System.EventHandler(this.AbilityAggregateScore_TextChanged);
            // 
            // TempScoreTextBox
            // 
            this.TempScoreTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TempScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TempScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempScoreTextBox.Location = new System.Drawing.Point(294, 5);
            this.TempScoreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TempScoreTextBox.MaxLength = 3;
            this.TempScoreTextBox.Name = "TempScoreTextBox";
            this.TempScoreTextBox.Size = new System.Drawing.Size(35, 21);
            this.TempScoreTextBox.TabIndex = 92;
            this.TempScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TempScoreTextBox.TextChanged += new System.EventHandler(this.AbilityAggregateScore_TextChanged);
            // 
            // addSymbol3
            // 
            this.addSymbol3.BackColor = System.Drawing.Color.Transparent;
            this.addSymbol3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSymbol3.ForeColor = System.Drawing.Color.Black;
            this.addSymbol3.Location = new System.Drawing.Point(229, 5);
            this.addSymbol3.Margin = new System.Windows.Forms.Padding(3);
            this.addSymbol3.Name = "addSymbol3";
            this.addSymbol3.Size = new System.Drawing.Size(15, 21);
            this.addSymbol3.TabIndex = 91;
            this.addSymbol3.Text = "+";
            this.addSymbol3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InherentScoreTextBox
            // 
            this.InherentScoreTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InherentScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InherentScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InherentScoreTextBox.Location = new System.Drawing.Point(244, 5);
            this.InherentScoreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InherentScoreTextBox.MaxLength = 3;
            this.InherentScoreTextBox.Name = "InherentScoreTextBox";
            this.InherentScoreTextBox.Size = new System.Drawing.Size(35, 21);
            this.InherentScoreTextBox.TabIndex = 90;
            this.InherentScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InherentScoreTextBox.TextChanged += new System.EventHandler(this.AbilityAggregateScore_TextChanged); 
            // 
            // EnhancementScoreTextBox
            // 
            this.EnhancementScoreTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnhancementScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnhancementScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnhancementScoreTextBox.Location = new System.Drawing.Point(194, 5);
            this.EnhancementScoreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EnhancementScoreTextBox.MaxLength = 3;
            this.EnhancementScoreTextBox.Name = "EnhancementScoreTextBox";
            this.EnhancementScoreTextBox.Size = new System.Drawing.Size(35, 21);
            this.EnhancementScoreTextBox.TabIndex = 88;
            this.EnhancementScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnhancementScoreTextBox.TextChanged += new System.EventHandler(this.AbilityAggregateScore_TextChanged);
            // 
            // BaseAbilityScoreTextBox
            // 
            this.BaseAbilityScoreTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BaseAbilityScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseAbilityScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseAbilityScoreTextBox.Location = new System.Drawing.Point(144, 5);
            this.BaseAbilityScoreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.BaseAbilityScoreTextBox.MaxLength = 3;
            this.BaseAbilityScoreTextBox.Name = "BaseAbilityScoreTextBox";
            this.BaseAbilityScoreTextBox.Size = new System.Drawing.Size(35, 21);
            this.BaseAbilityScoreTextBox.TabIndex = 87;
            this.BaseAbilityScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaseAbilityScoreTextBox.TextChanged += new System.EventHandler(this.AbilityAggregateScore_TextChanged);
            // 
            // AbilityModTextBox
            // 
            this.AbilityModTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AbilityModTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AbilityModTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityModTextBox.Location = new System.Drawing.Point(94, 5);
            this.AbilityModTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AbilityModTextBox.MaxLength = 3;
            this.AbilityModTextBox.Name = "AbilityModTextBox";
            this.AbilityModTextBox.ReadOnly = true;
            this.AbilityModTextBox.Size = new System.Drawing.Size(35, 21);
            this.AbilityModTextBox.TabIndex = 85;
            this.AbilityModTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbilityTotalTextBox
            // 
            this.AbilityTotalTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AbilityTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AbilityTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityTotalTextBox.Location = new System.Drawing.Point(52, 5);
            this.AbilityTotalTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AbilityTotalTextBox.MaxLength = 3;
            this.AbilityTotalTextBox.Name = "AbilityTotalTextBox";
            this.AbilityTotalTextBox.ReadOnly = true;
            this.AbilityTotalTextBox.Size = new System.Drawing.Size(35, 21);
            this.AbilityTotalTextBox.TabIndex = 83;
            this.AbilityTotalTextBox.Text = "0";
            this.AbilityTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AbilityTotalTextBox.TextChanged += new System.EventHandler(this.AbilityTotalTextBox_TextChanged);
            // 
            // AbilityAbbrvLabel
            // 
            this.AbilityAbbrvLabel.BackColor = System.Drawing.Color.Black;
            this.AbilityAbbrvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityAbbrvLabel.ForeColor = System.Drawing.Color.White;
            this.AbilityAbbrvLabel.Location = new System.Drawing.Point(5, 5);
            this.AbilityAbbrvLabel.Margin = new System.Windows.Forms.Padding(5);
            this.AbilityAbbrvLabel.Name = "AbilityAbbrvLabel";
            this.AbilityAbbrvLabel.Size = new System.Drawing.Size(40, 21);
            this.AbilityAbbrvLabel.TabIndex = 84;
            this.AbilityAbbrvLabel.Text = "ABL";
            this.AbilityAbbrvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSymbol1
            // 
            this.addSymbol1.BackColor = System.Drawing.Color.Transparent;
            this.addSymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSymbol1.ForeColor = System.Drawing.Color.Black;
            this.addSymbol1.Location = new System.Drawing.Point(129, 5);
            this.addSymbol1.Margin = new System.Windows.Forms.Padding(3);
            this.addSymbol1.Name = "addSymbol1";
            this.addSymbol1.Size = new System.Drawing.Size(15, 21);
            this.addSymbol1.TabIndex = 97;
            this.addSymbol1.Text = "+";
            this.addSymbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSymbol2
            // 
            this.addSymbol2.BackColor = System.Drawing.Color.Transparent;
            this.addSymbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSymbol2.ForeColor = System.Drawing.Color.Black;
            this.addSymbol2.Location = new System.Drawing.Point(179, 5);
            this.addSymbol2.Margin = new System.Windows.Forms.Padding(3);
            this.addSymbol2.Name = "addSymbol2";
            this.addSymbol2.Size = new System.Drawing.Size(15, 21);
            this.addSymbol2.TabIndex = 98;
            this.addSymbol2.Text = "+";
            this.addSymbol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSymbol4
            // 
            this.addSymbol4.BackColor = System.Drawing.Color.Transparent;
            this.addSymbol4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSymbol4.ForeColor = System.Drawing.Color.Black;
            this.addSymbol4.Location = new System.Drawing.Point(279, 5);
            this.addSymbol4.Margin = new System.Windows.Forms.Padding(3);
            this.addSymbol4.Name = "addSymbol4";
            this.addSymbol4.Size = new System.Drawing.Size(15, 21);
            this.addSymbol4.TabIndex = 99;
            this.addSymbol4.Text = "+";
            this.addSymbol4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtractSymbol1
            // 
            this.subtractSymbol1.BackColor = System.Drawing.Color.Transparent;
            this.subtractSymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractSymbol1.ForeColor = System.Drawing.Color.Black;
            this.subtractSymbol1.Location = new System.Drawing.Point(329, 5);
            this.subtractSymbol1.Margin = new System.Windows.Forms.Padding(3);
            this.subtractSymbol1.Name = "subtractSymbol1";
            this.subtractSymbol1.Size = new System.Drawing.Size(15, 21);
            this.subtractSymbol1.TabIndex = 100;
            this.subtractSymbol1.Text = "-";
            this.subtractSymbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilityScoreCalculationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subtractSymbol1);
            this.Controls.Add(this.addSymbol4);
            this.Controls.Add(this.addSymbol2);
            this.Controls.Add(this.addSymbol1);
            this.Controls.Add(this.PenaltyScoreTextBox);
            this.Controls.Add(this.TempScoreTextBox);
            this.Controls.Add(this.addSymbol3);
            this.Controls.Add(this.InherentScoreTextBox);
            this.Controls.Add(this.EnhancementScoreTextBox);
            this.Controls.Add(this.BaseAbilityScoreTextBox);
            this.Controls.Add(this.AbilityModTextBox);
            this.Controls.Add(this.AbilityTotalTextBox);
            this.Controls.Add(this.AbilityAbbrvLabel);
            this.Name = "AbilityScoreCalculationControl";
            this.Size = new System.Drawing.Size(389, 32);
            this.Load += new System.EventHandler(this.AbilityScoreCalculationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PenaltyScoreTextBox;
        private System.Windows.Forms.TextBox TempScoreTextBox;
        private System.Windows.Forms.Label addSymbol3;
        private System.Windows.Forms.TextBox InherentScoreTextBox;
        private System.Windows.Forms.TextBox EnhancementScoreTextBox;
        private System.Windows.Forms.TextBox BaseAbilityScoreTextBox;
        private System.Windows.Forms.TextBox AbilityModTextBox;
        private System.Windows.Forms.TextBox AbilityTotalTextBox;
        private System.Windows.Forms.Label AbilityAbbrvLabel;
        private System.Windows.Forms.Label addSymbol1;
        private System.Windows.Forms.Label addSymbol2;
        private System.Windows.Forms.Label addSymbol4;
        private System.Windows.Forms.Label subtractSymbol1;
    }
}
