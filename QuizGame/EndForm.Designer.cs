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
            this.panelTitle3 = new System.Windows.Forms.Panel();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.panelTitle3.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFelicitari
            // 
            this.labelFelicitari.AutoSize = true;
            this.labelFelicitari.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFelicitari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFelicitari.Location = new System.Drawing.Point(339, 10);
            this.labelFelicitari.Name = "labelFelicitari";
            this.labelFelicitari.Size = new System.Drawing.Size(134, 30);
            this.labelFelicitari.TabIndex = 0;
            this.labelFelicitari.Text = "Felicitari!";
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor.Location = new System.Drawing.Point(22, 49);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(91, 16);
            this.labelScor.TabIndex = 1;
            this.labelScor.Text = "Scorul este:";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonExit.Location = new System.Drawing.Point(106, 96);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelTitle3
            // 
            this.panelTitle3.BackColor = System.Drawing.Color.ForestGreen;
            this.panelTitle3.Controls.Add(this.labelFelicitari);
            this.panelTitle3.Location = new System.Drawing.Point(-12, 68);
            this.panelTitle3.Name = "panelTitle3";
            this.panelTitle3.Size = new System.Drawing.Size(834, 49);
            this.panelTitle3.TabIndex = 8;
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.labelScor);
            this.groupBoxMessage.Controls.Add(this.buttonExit);
            this.groupBoxMessage.Location = new System.Drawing.Point(251, 178);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(284, 151);
            this.groupBoxMessage.TabIndex = 9;
            this.groupBoxMessage.TabStop = false;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.panelTitle3);
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.panelTitle3.ResumeLayout(false);
            this.panelTitle3.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFelicitari;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelTitle3;
        private System.Windows.Forms.GroupBox groupBoxMessage;
    }
}