
namespace Lab7.GuessNumber
{
    partial class EnterNumber
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
            this.userNumber = new System.Windows.Forms.TextBox();
            this.userNumberLbl = new System.Windows.Forms.Label();
            this.enterUserNumberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNumber
            // 
            this.userNumber.Location = new System.Drawing.Point(26, 41);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(187, 23);
            this.userNumber.TabIndex = 0;
            // 
            // userNumberLbl
            // 
            this.userNumberLbl.AutoSize = true;
            this.userNumberLbl.Location = new System.Drawing.Point(26, 23);
            this.userNumberLbl.Name = "userNumberLbl";
            this.userNumberLbl.Size = new System.Drawing.Size(79, 15);
            this.userNumberLbl.TabIndex = 1;
            this.userNumberLbl.Text = "Your number:";
            // 
            // enterUserNumberBtn
            // 
            this.enterUserNumberBtn.Location = new System.Drawing.Point(26, 79);
            this.enterUserNumberBtn.Name = "enterUserNumberBtn";
            this.enterUserNumberBtn.Size = new System.Drawing.Size(187, 30);
            this.enterUserNumberBtn.TabIndex = 2;
            this.enterUserNumberBtn.Text = "Enter your number";
            this.enterUserNumberBtn.UseVisualStyleBackColor = true;
            this.enterUserNumberBtn.Click += new System.EventHandler(this.enterUserNumberBtn_Click);
            // 
            // EnterNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 127);
            this.Controls.Add(this.enterUserNumberBtn);
            this.Controls.Add(this.userNumberLbl);
            this.Controls.Add(this.userNumber);
            this.Name = "EnterNumber";
            this.Text = "Enter The GoalNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNumber;
        private System.Windows.Forms.Label userNumberLbl;
        private System.Windows.Forms.Button enterUserNumberBtn;
    }
}