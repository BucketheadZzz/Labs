using System;
using Lab4.Lab4;

namespace Labs
{
    /*
     * 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
       Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
       
       2. Реализуйте задачу 1 в виде статического класса StaticClass;
       а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
       б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
       в)*Добавьте обработку ситуации отсутствия файла на диске.
       
       3.
       а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
       б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
       в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
    */

    //Не разбивал прям коммент-задача, т.к. они пересекаются. Вероятно где-то мог отклониться от условия :)
    public class Lab4
    {
        public void TaskOne()
        {
            var param = GetParamObject();
            param.MinNumber = -10000;
            param.MaxNumber = 10000;

            var task = new LabTask(TaskType.RandomNumbers, param);

            var pairsCount = task.FindPairs();

            Console.WriteLine($"The number of pairs: {pairsCount}");
            Console.WriteLine($"Max count: {task.MaxCount}");
            Console.WriteLine("=============================");

            var occurrences = task.GetOccurrencesNumber();
            foreach (var item in occurrences)
            {
                Console.WriteLine($"Number: {item.Key}: Occurrences: {item.Value}");
            }
        }


        public void TaskTwo()
        {
            var param = GetParamObject();
            var task = new LabTask(TaskType.File, param);
            var pairsCount = task.FindPairs();

            Console.WriteLine($"The number of pairs: {pairsCount}");
        }


        public void TaskThree()
        {
            var param = GetParamObject();
            param.StartValue = 0;
            param.Step = 1;

            var task = new LabTask(TaskType.NumbersByStep, param);

            Console.WriteLine($"Sum: {task.Sum}");
            Console.WriteLine($"Inversed array: {string.Join(",", task.Inverse)}");
            Console.WriteLine($"Max count: {task.MaxCount}");

            Console.WriteLine("=============================");

            var occurrences = task.GetOccurrencesNumber();
            foreach (var item in occurrences)
            {
                Console.WriteLine($"Number: {item.Key}: Occurrences: {item.Value}");
            }

        }

        private FillSettings GetParamObject()
        {
            return new FillSettings();
        }
    }
}
