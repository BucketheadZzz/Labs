using System;

namespace Lab7.GuessNumber
{
    public class GuessNumberProcessor
    {
        public int GoalNumber { get; private set; }

        public int UserNumber { get; set; }

        public int AttemptsCount { get; set; }

        public void GuessTheNumber()
        {
            GoalNumber = new Random().Next(0, 100);
        }

        public NumberState CheckNumber()
        {
            if (UserNumber < GoalNumber)
            {
                return NumberState.Less;
            }

            if (UserNumber > GoalNumber)
            {
                return NumberState.More;
            }

            return NumberState.Equal;
        }
    }
}
