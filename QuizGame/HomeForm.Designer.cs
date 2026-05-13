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
            this.buttonDificultate = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuizGame
            // 
            this.labelQuizGame.AutoSize = true;
            this.labelQuizGame.Location = new System.Drawing.Point(267, 87);
            this.labelQuizGame.Name = "labelQuizGame";
            this.labelQuizGame.Size = new System.Drawing.Size(243, 16);
            this.labelQuizGame.TabIndex = 0;
            this.labelQuizGame.Text = "Quiz Game-Intrebari de cultura generala";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(354, 168);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDificultate
            // 
            this.buttonDificultate.Location = new System.Drawing.Point(354, 224);
            this.buttonDificultate.Name = "buttonDificultate";
            this.buttonDificultate.Size = new System.Drawing.Size(75, 23);
            this.buttonDificultate.TabIndex = 2;
            this.buttonDificultate.Text = "Dificultate";
            this.buttonDificultate.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(354, 284);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(354, 347);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(354, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDificultate);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelQuizGame);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuizGame;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDificultate;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
    }
}