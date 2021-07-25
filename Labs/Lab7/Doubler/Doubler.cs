using System;
using System.Windows.Forms;

namespace Lab7.Doubler
{
    public partial class Doubler : Form
    {
        private DoublerProcessor doublerProcessor;

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doublerProcessor.Plus();
            OperationPostProcessing();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doublerProcessor.Double();
            OperationPostProcessing();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doublerProcessor.Reset();
            OperationPostProcessing();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            doublerProcessor.Cancel();
            OperationPostProcessing();
        }
      
        private void startButton_Click(object sender, EventArgs e)
        {
            menuGroup.Enabled = false;
            gameplayGroup.Enabled = true;
            startButton.Enabled = false;
            doublerProcessor = new DoublerProcessor(FinishGame);
            goalValue.Text = doublerProcessor.Goal.ToString();

            MessageBox.Show($"Your goal: {doublerProcessor.Goal}", "Goal");
            OperationPostProcessing();
        }

        private void OperationPostProcessing()
        {
            lblNumber.Text = doublerProcessor.CurrentValue.ToString();
            commandsCount.Text = doublerProcessor.OperationCount.ToString();
        }

        private void FinishGame()
        {
            gameplayGroup.Enabled = false;
            menuGroup.Enabled = true;
            startButton.Enabled = true;

            MessageBox.Show("The game is finished", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
