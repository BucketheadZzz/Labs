using System.Windows.Forms;

namespace Lab7.GuessNumber
{
    public partial class EnterNumber : Form
    {
        private readonly GuessNumberProcessor guessNumberProcessor;

        public EnterNumber(GuessNumberProcessor guessNumberProcessor)
        {
            InitializeComponent();
            this.guessNumberProcessor = guessNumberProcessor;
        }

        private void enterUserNumberBtn_Click(object sender, System.EventArgs e)
        {
            guessNumberProcessor.UserNumber = int.Parse(userNumber.Text);
            guessNumberProcessor.AttemptsCount++;
            Close();
        }
    }
}
