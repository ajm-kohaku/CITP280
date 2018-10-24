namespace CITP280
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbClassNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHitDieType = new System.Windows.Forms.Label();
            this.lbSkillsPerLevel = new System.Windows.Forms.Label();
            this.lbClassSkillsList = new System.Windows.Forms.Label();
            this.dgClassTableView = new System.Windows.Forms.DataGridView();
            this.classTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClassNames
            // 
            this.cbClassNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassNames.FormattingEnabled = true;
            this.cbClassNames.Location = new System.Drawing.Point(42, 22);
            this.cbClassNames.Name = "cbClassNames";
            this.cbClassNames.Size = new System.Drawing.Size(121, 21);
            this.cbClassNames.Sorted = true;
            this.cbClassNames.TabIndex = 0;
            this.cbClassNames.SelectedIndexChanged += new System.EventHandler(this.ClassNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hit Die:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Skills per Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class Skills:";
            // 
            // lbHitDieType
            // 
            this.lbHitDieType.AutoSize = true;
            this.lbHitDieType.BackColor = System.Drawing.Color.Transparent;
            this.lbHitDieType.Location = new System.Drawing.Point(100, 55);
            this.lbHitDieType.Name = "lbHitDieType";
            this.lbHitDieType.Size = new System.Drawing.Size(35, 13);
            this.lbHitDieType.TabIndex = 6;
            this.lbHitDieType.Text = "label4";
            // 
            // lbSkillsPerLevel
            // 
            this.lbSkillsPerLevel.AutoSize = true;
            this.lbSkillsPerLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillsPerLevel.Location = new System.Drawing.Point(153, 74);
            this.lbSkillsPerLevel.Name = "lbSkillsPerLevel";
            this.lbSkillsPerLevel.Size = new System.Drawing.Size(35, 13);
            this.lbSkillsPerLevel.TabIndex = 7;
            this.lbSkillsPerLevel.Text = "label5";
            // 
            // lbClassSkillsList
            // 
            this.lbClassSkillsList.BackColor = System.Drawing.Color.Transparent;
            this.lbClassSkillsList.Location = new System.Drawing.Point(39, 103);
            this.lbClassSkillsList.Name = "lbClassSkillsList";
            this.lbClassSkillsList.Size = new System.Drawing.Size(293, 135);
            this.lbClassSkillsList.TabIndex = 8;
            this.lbClassSkillsList.Text = "label6";
            this.lbClassSkillsList.Click += new System.EventHandler(this.ClassSkillsList_Click);
            // 
            // dgClassTableView
            // 
            this.dgClassTableView.AllowUserToAddRows = false;
            this.dgClassTableView.AllowUserToDeleteRows = false;
            this.dgClassTableView.AllowUserToResizeColumns = false;
            this.dgClassTableView.AllowUserToResizeRows = false;
            this.dgClassTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassTableView.Location = new System.Drawing.Point(387, 22);
            this.dgClassTableView.Name = "dgClassTableView";
            this.dgClassTableView.ReadOnly = true;
            this.dgClassTableView.Size = new System.Drawing.Size(592, 461);
            this.dgClassTableView.TabIndex = 9;
            // 
            // classTableBindingSource
            // 
            this.classTableBindingSource.DataSource = typeof(CITP280.playerclass.ClassTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1022, 591);
            this.Controls.Add(this.dgClassTableView);
            this.Controls.Add(this.lbClassSkillsList);
            this.Controls.Add(this.lbSkillsPerLevel);
            this.Controls.Add(this.lbHitDieType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClassNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Playable Class Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClassNames;
        private System.Windows.Forms.BindingSource classTableBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHitDieType;
        private System.Windows.Forms.Label lbSkillsPerLevel;
        private System.Windows.Forms.Label lbClassSkillsList;
        private System.Windows.Forms.DataGridView dgClassTableView;
    }
}

