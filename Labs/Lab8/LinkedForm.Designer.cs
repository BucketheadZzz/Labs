
namespace Lab8
{
    partial class LinkedForm
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
            this.coreValue = new System.Windows.Forms.TextBox();
            this.linkedVal = new System.Windows.Forms.NumericUpDown();
            this.coreValueLbl = new System.Windows.Forms.Label();
            this.linkedValLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linkedVal)).BeginInit();
            this.SuspendLayout();
            // 
            // coreValue
            // 
            this.coreValue.Location = new System.Drawing.Point(30, 36);
            this.coreValue.Name = "coreValue";
            this.coreValue.Size = new System.Drawing.Size(134, 23);
            this.coreValue.TabIndex = 0;
            this.coreValue.TextChanged += new System.EventHandler(this.coreValue_TextChanged);
            // 
            // linkedVal
            // 
            this.linkedVal.Enabled = false;
            this.linkedVal.Location = new System.Drawing.Point(30, 90);
            this.linkedVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.linkedVal.Name = "linkedVal";
            this.linkedVal.Size = new System.Drawing.Size(139, 23);
            this.linkedVal.TabIndex = 1;
            // 
            // coreValueLbl
            // 
            this.coreValueLbl.AutoSize = true;
            this.coreValueLbl.Location = new System.Drawing.Point(30, 9);
            this.coreValueLbl.Name = "coreValueLbl";
            this.coreValueLbl.Size = new System.Drawing.Size(102, 15);
            this.coreValueLbl.TabIndex = 2;
            this.coreValueLbl.Text = "Enter the number:";
            // 
            // linkedValLbl
            // 
            this.linkedValLbl.AutoSize = true;
            this.linkedValLbl.Location = new System.Drawing.Point(30, 62);
            this.linkedValLbl.Name = "linkedValLbl";
            this.linkedValLbl.Size = new System.Drawing.Size(76, 15);
            this.linkedValLbl.TabIndex = 3;
            this.linkedValLbl.Text = "Linked value:";
            // 
            // LinkedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 134);
            this.Controls.Add(this.linkedValLbl);
            this.Controls.Add(this.coreValueLbl);
            this.Controls.Add(this.linkedVal);
            this.Controls.Add(this.coreValue);
            this.Name = "LinkedForm";
            this.Text = "LinkedForm";
            ((System.ComponentModel.ISupportInitialize)(this.linkedVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coreValue;
        private System.Windows.Forms.NumericUpDown linkedVal;
        private System.Windows.Forms.Label coreValueLbl;
        private System.Windows.Forms.Label linkedValLbl;
    }
}