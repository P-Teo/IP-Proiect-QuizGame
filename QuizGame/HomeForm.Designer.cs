namespace QuizGame
{
    partial class HomeForm
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
            this.labelQuizGame = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.groupBoxAnotherButtons = new System.Windows.Forms.GroupBox();
            this.panelTitle.SuspendLayout();
            this.groupBoxStart.SuspendLayout();
            this.groupBoxAnotherButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuizGame
            // 
            this.labelQuizGame.AutoSize = true;
            this.labelQuizGame.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuizGame.Location = new System.Drawing.Point(116, 30);
            this.labelQuizGame.Name = "labelQuizGame";
            this.labelQuizGame.Size = new System.Drawing.Size(602, 36);
            this.labelQuizGame.TabIndex = 0;
            this.labelQuizGame.Text = "Quiz Game-Intrebari de cultura generala";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonStart.Location = new System.Drawing.Point(71, 33);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonHelp.Location = new System.Drawing.Point(41, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAbout.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonAbout.Location = new System.Drawing.Point(219, 40);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonExit.Location = new System.Drawing.Point(404, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(337, 32);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDifficulty.TabIndex = 6;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(240, 38);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(75, 14);
            this.labelDifficulty.TabIndex = 7;
            this.labelDifficulty.Text = "Difficulty:";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.panelTitle.Controls.Add(this.labelQuizGame);
            this.panelTitle.Location = new System.Drawing.Point(-7, 12);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(821, 96);
            this.panelTitle.TabIndex = 8;
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.buttonStart);
            this.groupBoxStart.Controls.Add(this.labelDifficulty);
            this.groupBoxStart.Controls.Add(this.comboBoxDifficulty);
            this.groupBoxStart.Location = new System.Drawing.Point(141, 139);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(534, 93);
            this.groupBoxStart.TabIndex = 9;
            this.groupBoxStart.TabStop = false;
            // 
            // groupBoxAnotherButtons
            // 
            this.groupBoxAnotherButtons.Controls.Add(this.buttonHelp);
            this.groupBoxAnotherButtons.Controls.Add(this.buttonAbout);
            this.groupBoxAnotherButtons.Controls.Add(this.buttonExit);
            this.groupBoxAnotherButtons.Location = new System.Drawing.Point(141, 257);
            this.groupBoxAnotherButtons.Name = "groupBoxAnotherButtons";
            this.groupBoxAnotherButtons.Size = new System.Drawing.Size(534, 98);
            this.groupBoxAnotherButtons.TabIndex = 10;
            this.groupBoxAnotherButtons.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAnotherButtons);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.panelTitle);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            this.groupBoxAnotherButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuizGame;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.GroupBox groupBoxStart;
        private System.Windows.Forms.GroupBox groupBoxAnotherButtons;
    }
}