
namespace Lab7.GuessNumber
{
    partial class GuessNumber: IBaseForm
    {
        private GuessNumberProcessor guessNumberProcessor = new GuessNumberProcessor();
        private EnterNumber enterNumberForm;
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
        public void InitializeComponent()
        {
            this.guessNumberBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.attemptsLbl = new System.Windows.Forms.Label();
            this.attemptsValue = new System.Windows.Forms.Label();
            this.enterNumberBtn = new System.Windows.Forms.Button();
            this.checkNumberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessNumberBtn
            // 
            this.guessNumberBtn.Location = new System.Drawing.Point(12, 25);
            this.guessNumberBtn.Name = "guessNumberBtn";
            this.guessNumberBtn.Size = new System.Drawing.Size(228, 23);
            this.guessNumberBtn.TabIndex = 0;
            this.guessNumberBtn.Text = "Guess the number";
            this.guessNumberBtn.UseVisualStyleBackColor = true;
            this.guessNumberBtn.Click += new System.EventHandler(this.guessNumberBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 60);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(61, 15);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "The result:";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(79, 60);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(29, 15);
            this.resultValueLabel.TabIndex = 2;
            this.resultValueLabel.Text = "N/A";
            // 
            // attemptsLbl
            // 
            this.attemptsLbl.AutoSize = true;
            this.attemptsLbl.Location = new System.Drawing.Point(14, 75);
            this.attemptsLbl.Name = "attemptsLbl";
            this.attemptsLbl.Size = new System.Drawing.Size(59, 15);
            this.attemptsLbl.TabIndex = 3;
            this.attemptsLbl.Text = "Attempts:";
            // 
            // attemptsValue
            // 
            this.attemptsValue.AutoSize = true;
            this.attemptsValue.Location = new System.Drawing.Point(70, 75);
            this.attemptsValue.Name = "attemptsValue";
            this.attemptsValue.Size = new System.Drawing.Size(13, 15);
            this.attemptsValue.TabIndex = 4;
            this.attemptsValue.Text = "0";
            // 
            // enterNumberBtn
            // 
            this.enterNumberBtn.Enabled = false;
            this.enterNumberBtn.Location = new System.Drawing.Point(12, 98);
            this.enterNumberBtn.Name = "enterNumberBtn";
            this.enterNumberBtn.Size = new System.Drawing.Size(228, 23);
            this.enterNumberBtn.TabIndex = 5;
            this.enterNumberBtn.Text = "Enter the number";
            this.enterNumberBtn.UseVisualStyleBackColor = true;
            this.enterNumberBtn.Click += new System.EventHandler(this.enterNumberBtn_Click);
            // 
            // checkNumberBtn
            // 
            this.checkNumberBtn.Enabled = false;
            this.checkNumberBtn.Location = new System.Drawing.Point(12, 127);
            this.checkNumberBtn.Name = "checkNumberBtn";
            this.checkNumberBtn.Size = new System.Drawing.Size(228, 23);
            this.checkNumberBtn.TabIndex = 6;
            this.checkNumberBtn.Text = "Chech the number";
            this.checkNumberBtn.UseVisualStyleBackColor = true;
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 158);
            this.Controls.Add(this.checkNumberBtn);
            this.Controls.Add(this.enterNumberBtn);
            this.Controls.Add(this.attemptsValue);
            this.Controls.Add(this.attemptsLbl);
            this.Controls.Add(this.resultValueLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessNumberBtn);
            this.Name = "GuessNumber";
            this.Text = "Guess GoalNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessNumberBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.Label attemptsLbl;
        private System.Windows.Forms.Label attemptsValue;
        private System.Windows.Forms.Button enterNumberBtn;
        private System.Windows.Forms.Button checkNumberBtn;
    }
}