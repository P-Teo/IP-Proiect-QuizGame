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
            this.panelTitle2 = new System.Windows.Forms.Panel();
            this.groupBoxScor = new System.Windows.Forms.GroupBox();
            this.groupBoxQuestions = new System.Windows.Forms.GroupBox();
            this.panelTitle2.SuspendLayout();
            this.groupBoxScor.SuspendLayout();
            this.groupBoxQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestion.Location = new System.Drawing.Point(259, 16);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(122, 19);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "labelQuestion";
            // 
            // radioButtonOptionA
            // 
            this.radioButtonOptionA.AutoSize = true;
            this.radioButtonOptionA.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOptionA.Location = new System.Drawing.Point(30, 21);
            this.radioButtonOptionA.Name = "radioButtonOptionA";
            this.radioButtonOptionA.Size = new System.Drawing.Size(122, 20);
            this.radioButtonOptionA.TabIndex = 1;
            this.radioButtonOptionA.TabStop = true;
            this.radioButtonOptionA.Text = "radioButton1";
            this.radioButtonOptionA.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionB
            // 
            this.radioButtonOptionB.AutoSize = true;
            this.radioButtonOptionB.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOptionB.Location = new System.Drawing.Point(30, 47);
            this.radioButtonOptionB.Name = "radioButtonOptionB";
            this.radioButtonOptionB.Size = new System.Drawing.Size(122, 20);
            this.radioButtonOptionB.TabIndex = 2;
            this.radioButtonOptionB.TabStop = true;
            this.radioButtonOptionB.Text = "radioButton2";
            this.radioButtonOptionB.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionC
            // 
            this.radioButtonOptionC.AutoSize = true;
            this.radioButtonOptionC.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOptionC.Location = new System.Drawing.Point(30, 73);
            this.radioButtonOptionC.Name = "radioButtonOptionC";
            this.radioButtonOptionC.Size = new System.Drawing.Size(122, 20);
            this.radioButtonOptionC.TabIndex = 3;
            this.radioButtonOptionC.TabStop = true;
            this.radioButtonOptionC.Text = "radioButton3";
            this.radioButtonOptionC.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionD
            // 
            this.radioButtonOptionD.AutoSize = true;
            this.radioButtonOptionD.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOptionD.Location = new System.Drawing.Point(30, 99);
            this.radioButtonOptionD.Name = "radioButtonOptionD";
            this.radioButtonOptionD.Size = new System.Drawing.Size(122, 20);
            this.radioButtonOptionD.TabIndex = 4;
            this.radioButtonOptionD.TabStop = true;
            this.radioButtonOptionD.Text = "radioButton4";
            this.radioButtonOptionD.UseVisualStyleBackColor = true;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelScore.Location = new System.Drawing.Point(33, 18);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 16);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "label2";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNext.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonNext.Location = new System.Drawing.Point(578, 296);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelTitle2
            // 
            this.panelTitle2.BackColor = System.Drawing.Color.ForestGreen;
            this.panelTitle2.Controls.Add(this.labelQuestion);
            this.panelTitle2.Location = new System.Drawing.Point(-10, 85);
            this.panelTitle2.Name = "panelTitle2";
            this.panelTitle2.Size = new System.Drawing.Size(819, 49);
            this.panelTitle2.TabIndex = 7;
            // 
            // groupBoxScor
            // 
            this.groupBoxScor.Controls.Add(this.labelScore);
            this.groupBoxScor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScor.Name = "groupBoxScor";
            this.groupBoxScor.Size = new System.Drawing.Size(115, 48);
            this.groupBoxScor.TabIndex = 8;
            this.groupBoxScor.TabStop = false;
            // 
            // groupBoxQuestions
            // 
            this.groupBoxQuestions.Controls.Add(this.radioButtonOptionA);
            this.groupBoxQuestions.Controls.Add(this.radioButtonOptionB);
            this.groupBoxQuestions.Controls.Add(this.radioButtonOptionC);
            this.groupBoxQuestions.Controls.Add(this.radioButtonOptionD);
            this.groupBoxQuestions.Location = new System.Drawing.Point(143, 140);
            this.groupBoxQuestions.Name = "groupBoxQuestions";
            this.groupBoxQuestions.Size = new System.Drawing.Size(525, 140);
            this.groupBoxQuestions.TabIndex = 9;
            this.groupBoxQuestions.TabStop = false;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxQuestions);
            this.Controls.Add(this.groupBoxScor);
            this.Controls.Add(this.panelTitle2);
            this.Controls.Add(this.buttonNext);
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.panelTitle2.ResumeLayout(false);
            this.panelTitle2.PerformLayout();
            this.groupBoxScor.ResumeLayout(false);
            this.groupBoxScor.PerformLayout();
            this.groupBoxQuestions.ResumeLayout(false);
            this.groupBoxQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonOptionA;
        private System.Windows.Forms.RadioButton radioButtonOptionB;
        private System.Windows.Forms.RadioButton radioButtonOptionC;
        private System.Windows.Forms.RadioButton radioButtonOptionD;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.GroupBox groupBoxScor;
        private System.Windows.Forms.GroupBox groupBoxQuestions;
    }
}

