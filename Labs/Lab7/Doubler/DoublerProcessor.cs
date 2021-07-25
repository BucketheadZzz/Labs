using System;
using System.Collections.Generic;

namespace Lab7.Doubler
{
    public class DoublerProcessor
    {
        private readonly Stack<int> operations = new Stack<int>();
        private readonly Action finishGameCallBack;
       
        public int Goal { get; }

        public int CurrentValue { get; private set; }

        public int OperationCount { get; private set; }

        public bool CurrentValueEqualsGoal => Goal == CurrentValue;

        public DoublerProcessor(Action finishGameCallBack)
        {
            Goal = new Random().Next(2, 50);
            CurrentValue = 1;
            operations.Push(CurrentValue);
            this.finishGameCallBack = finishGameCallBack;
        }

        public void Plus()
        {
            CurrentValue += 1;
            operations.Push(CurrentValue);
            OperationCount++;
            CheckIfGameFinished();
        }

        public void Double()
        {
            CurrentValue *= 2;
            operations.Push(CurrentValue);
            OperationCount++;
            CheckIfGameFinished();
        }


        public void Reset()
        {
            CurrentValue = 1;
            operations.Clear();
            OperationCount++;
        }

        public void Cancel()
        {
            if (operations.Count <= 0) return;
            if (CurrentValue == operations.Peek())
            {
                operations.Pop();
            }

            CurrentValue = operations.Pop();
            OperationCount++;
        }

        private void CheckIfGameFinished()
        {
            if (CurrentValueEqualsGoal)
            {
                finishGameCallBack();
            }
        }
    }
}
