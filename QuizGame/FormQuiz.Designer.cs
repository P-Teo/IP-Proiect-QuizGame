namespace QuizGame
{
    partial class FormQuiz
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonOptionA = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionB = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionC = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionD = new System.Windows.Forms.RadioButton();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(363, 68);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(90, 16);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "labelQuestion";
            // 
            // radioButtonOptionA
            // 
            this.radioButtonOptionA.AutoSize = true;
            this.radioButtonOptionA.Location = new System.Drawing.Point(350, 167);
            this.radioButtonOptionA.Name = "radioButtonOptionA";
            this.radioButtonOptionA.Size = new System.Drawing.Size(103, 20);
            this.radioButtonOptionA.TabIndex = 1;
            this.radioButtonOptionA.TabStop = true;
            this.radioButtonOptionA.Text = "radioButton1";
            this.radioButtonOptionA.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionB
            // 
            this.radioButtonOptionB.AutoSize = true;
            this.radioButtonOptionB.Location = new System.Drawing.Point(350, 222);
            this.radioButtonOptionB.Name = "radioButtonOptionB";
            this.radioButtonOptionB.Size = new System.Drawing.Size(103, 20);
            this.radioButtonOptionB.TabIndex = 2;
            this.radioButtonOptionB.TabStop = true;
            this.radioButtonOptionB.Text = "radioButton2";
            this.radioButtonOptionB.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionC
            // 
            this.radioButtonOptionC.AutoSize = true;
            this.radioButtonOptionC.Location = new System.Drawing.Point(350, 274);
            this.radioButtonOptionC.Name = "radioButtonOptionC";
            this.radioButtonOptionC.Size = new System.Drawing.Size(103, 20);
            this.radioButtonOptionC.TabIndex = 3;
            this.radioButtonOptionC.TabStop = true;
            this.radioButtonOptionC.Text = "radioButton3";
            this.radioButtonOptionC.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionD
            // 
            this.radioButtonOptionD.AutoSize = true;
            this.radioButtonOptionD.Location = new System.Drawing.Point(350, 326);
            this.radioButtonOptionD.Name = "radioButtonOptionD";
            this.radioButtonOptionD.Size = new System.Drawing.Size(103, 20);
            this.radioButtonOptionD.TabIndex = 4;
            this.radioButtonOptionD.TabStop = true;
            this.radioButtonOptionD.Text = "radioButton4";
            this.radioButtonOptionD.UseVisualStyleBackColor = true;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(68, 27);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(44, 16);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "label2";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(582, 380);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.radioButtonOptionD);
            this.Controls.Add(this.radioButtonOptionC);
            this.Controls.Add(this.radioButtonOptionB);
            this.Controls.Add(this.radioButtonOptionA);
            this.Controls.Add(this.labelQuestion);
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonOptionA;
        private System.Windows.Forms.RadioButton radioButtonOptionB;
        private System.Windows.Forms.RadioButton radioButtonOptionC;
        private System.Windows.Forms.RadioButton radioButtonOptionD;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonNext;
    }
}

