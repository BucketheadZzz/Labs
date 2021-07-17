using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.Lab4
{
    public class LabTask
    {
        private readonly int[] values = new int[20];
        private readonly IDictionary<TaskType, Func<FillSettings, int[]>> actions = new Dictionary<TaskType, Func<FillSettings, int[]>>
        {
            {TaskType.RandomNumbers, ArrayFiller.FillArrayWithRandomNumbers},
            {TaskType.File, ArrayFiller.FillArrayFromFile},
            {TaskType.NumbersByStep, ArrayFiller.FillArrayWithNumbersByStep}
        };

        public LabTask(TaskType taskType, FillSettings param)
        {
            values = actions[taskType](param);
        }

        public int Sum => values.Sum();

        public int[] Inverse => values.Select(value => value * -1).ToArray();

        public int MaxCount => values.Count(value => value == values.Max());

        public int FindPairs()
        {
            var pairsCount = 0;
            var previousItem = values[0];
            for (var i = 1; i < values.Length; i++)
            {
                if (values[i] % 3 == 0 && previousItem % 3 == 0)
                {
                    pairsCount++;
                }

                previousItem = values[i];
            }

            return pairsCount;
        }

        public IDictionary<int, int> GetOccurrencesNumber()
        {
            var result = new Dictionary<int, int>();

            foreach (var value in values)
            {
                if (result.ContainsKey(value))
                {
                    result[value] += 1;
                }
                else
                {
                    result[value] = 1;
                }
            }

            return result;
        }
    }
}
