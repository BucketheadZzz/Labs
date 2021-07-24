
using System.Windows.Forms;

namespace Lab7
{
    partial class Doubler : IBaseForm
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
        public void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnCommand3 = new System.Windows.Forms.Button();
            this.gameplayGroup = new System.Windows.Forms.GroupBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.menuGroup = new System.Windows.Forms.GroupBox();
            this.commandsCount = new System.Windows.Forms.Label();
            this.commandsCountLbl = new System.Windows.Forms.Label();
            this.goalValue = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameplayGroup.SuspendLayout();
            this.menuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(35, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(39, 47);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            // 
            // btnCommand1
            // 
            this.btnCommand1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCommand1.Location = new System.Drawing.Point(164, 45);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(101, 23);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCommand2.Location = new System.Drawing.Point(164, 87);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(101, 22);
            this.btnCommand2.TabIndex = 2;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnCommand3
            // 
            this.btnCommand3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCommand3.Location = new System.Drawing.Point(164, 124);
            this.btnCommand3.Name = "btnCommand3";
            this.btnCommand3.Size = new System.Drawing.Size(101, 23);
            this.btnCommand3.TabIndex = 3;
            this.btnCommand3.Text = "Reset";
            this.btnCommand3.UseVisualStyleBackColor = true;
            this.btnCommand3.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gameplayGroup
            // 
            this.gameplayGroup.Controls.Add(this.goBackButton);
            this.gameplayGroup.Controls.Add(this.btnCommand1);
            this.gameplayGroup.Controls.Add(this.btnCommand3);
            this.gameplayGroup.Controls.Add(this.lblNumber);
            this.gameplayGroup.Controls.Add(this.btnCommand2);
            this.gameplayGroup.Enabled = false;
            this.gameplayGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameplayGroup.Location = new System.Drawing.Point(13, 98);
            this.gameplayGroup.Name = "gameplayGroup";
            this.gameplayGroup.Size = new System.Drawing.Size(280, 202);
            this.gameplayGroup.TabIndex = 4;
            this.gameplayGroup.TabStop = false;
            this.gameplayGroup.Text = "Gameplay";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.Location = new System.Drawing.Point(164, 164);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(101, 23);
            this.goBackButton.TabIndex = 4;
            this.goBackButton.Text = "One step back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // menuGroup
            // 
            this.menuGroup.Controls.Add(this.commandsCount);
            this.menuGroup.Controls.Add(this.commandsCountLbl);
            this.menuGroup.Controls.Add(this.goalValue);
            this.menuGroup.Controls.Add(this.goal);
            this.menuGroup.Controls.Add(this.startButton);
            this.menuGroup.Location = new System.Drawing.Point(13, 8);
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(280, 84);
            this.menuGroup.TabIndex = 5;
            this.menuGroup.TabStop = false;
            this.menuGroup.Text = "Menu/Statistics";
            // 
            // commandsCount
            // 
            this.commandsCount.AutoSize = true;
            this.commandsCount.Location = new System.Drawing.Point(236, 48);
            this.commandsCount.Name = "commandsCount";
            this.commandsCount.Size = new System.Drawing.Size(13, 15);
            this.commandsCount.TabIndex = 4;
            this.commandsCount.Text = "0";
            // 
            // commandsCountLbl
            // 
            this.commandsCountLbl.AutoSize = true;
            this.commandsCountLbl.Location = new System.Drawing.Point(128, 48);
            this.commandsCountLbl.Name = "commandsCountLbl";
            this.commandsCountLbl.Size = new System.Drawing.Size(108, 15);
            this.commandsCountLbl.TabIndex = 3;
            this.commandsCountLbl.Text = "Commands Count:";
            // 
            // goalValue
            // 
            this.goalValue.AutoSize = true;
            this.goalValue.Location = new System.Drawing.Point(164, 19);
            this.goalValue.Name = "goalValue";
            this.goalValue.Size = new System.Drawing.Size(29, 15);
            this.goalValue.TabIndex = 2;
            this.goalValue.Text = "N/A";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(127, 19);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(37, 15);
            this.goal.TabIndex = 1;
            this.goal.Text = "Goal: ";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(16, 34);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(81, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 312);
            this.Controls.Add(this.menuGroup);
            this.Controls.Add(this.gameplayGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Doubler";
            this.Text = "Doubler";
            this.gameplayGroup.ResumeLayout(false);
            this.gameplayGroup.PerformLayout();
            this.menuGroup.ResumeLayout(false);
            this.menuGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnCommand3;
        private System.Windows.Forms.GroupBox gameplayGroup;
        private System.Windows.Forms.GroupBox menuGroup;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label goalValue;
        private System.Windows.Forms.Label commandsCountLbl;
        private System.Windows.Forms.Label commandsCount;
        private System.Windows.Forms.Button goBackButton;
    }
}