using System;
using System.Windows.Forms;

namespace Lab7.GuessNumber
{
    public partial class GuessNumber : Form
    {
        private void guessNumberBtn_Click(object sender, System.EventArgs e)
        {
            guessNumberProcessor.GuessTheNumber();
            MessageBox.Show("Now try to guess the number!");

            enterNumberBtn.Enabled = true;
            checkNumberBtn.Enabled = true;
        }

        private void EnterNumberFormOnClosed(object? sender, EventArgs e)
        {
            attemptsValue.Text = guessNumberProcessor.AttemptsCount.ToString();
            var result = guessNumberProcessor.CheckNumber();

            var message = "";
            switch (result)
            {
                case NumberState.Less:
                    message = "Your number is less. Try to enter a bigger number";
                    break;
                case NumberState.More:
                    message = "Your number is bigger. Try to enter a bigger number";
                    break;
                case NumberState.Equal:
                    message = "Your number is correct!!!";
                    break;
            }

            resultValueLabel.Text = message;

            if (result == NumberState.Equal)
            {
                enterNumberBtn.Enabled = false;
                checkNumberBtn.Enabled = false;
            }
        }

        private void enterNumberBtn_Click(object sender, EventArgs e)
        {
            enterNumberForm = new EnterNumber(guessNumberProcessor);
            enterNumberForm.Closed += EnterNumberFormOnClosed;
            enterNumberForm.Show();
        }
    }
}
