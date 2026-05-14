namespace QuizGame
{
    partial class EndForm
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
            this.labelFelicitari = new System.Windows.Forms.Label();
            this.labelScor = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFelicitari
            // 
            this.labelFelicitari.AutoSize = true;
            this.labelFelicitari.Location = new System.Drawing.Point(349, 114);
            this.labelFelicitari.Name = "labelFelicitari";
            this.labelFelicitari.Size = new System.Drawing.Size(60, 16);
            this.labelFelicitari.TabIndex = 0;
            this.labelFelicitari.Text = "Felicitari!";
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.Location = new System.Drawing.Point(349, 168);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(77, 16);
            this.labelScor.TabIndex = 1;
            this.labelScor.Text = "Scorul este:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(351, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.labelFelicitari);
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFelicitari;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Button buttonExit;
    }
}