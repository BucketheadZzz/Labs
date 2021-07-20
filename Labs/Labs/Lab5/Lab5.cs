using System;

namespace Labs.Lab5
{
    public class Lab5
    {
        /*
         * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
           б) **с использованием регулярных выражений.
         */
        public void TaskOne()
        {
            Console.Write("Enter the login: ");
            var login = Console.ReadLine();

            var isLoginCorrect = LabTasks.IsLoginCorrect(login);
            Console.WriteLine($"The login is correct: {isLoginCorrect}");
        }

        /*
         * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
           а) Вывести только те слова сообщения, которые содержат не более n букв.
           б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
           в) Найти самое длинное слово сообщения.
           г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
         */
        public void TaskTwo()
        {
            //1
            var firstMessage = "This is message to remove some words in this message";
            var changedMessage = LabTasks.RemoveSomeWords(firstMessage, 'm');
            Console.WriteLine($"Changed message {changedMessage}");

            var secondMessage = "hellooo world omg ommmggg omg2";
            //2
            const int maxWordLength = 3;
            var words = LabTasks.GetWordsUpToLength(secondMessage, maxWordLength);
            Console.WriteLine($"Max length: {maxWordLength}. Words: {string.Join(' ', words)}");

            //3
            var longestWord = LabTasks.GetLongestWords(secondMessage);
            Console.WriteLine($"The longest word: {longestWord}");

            //4
            var longestWords = LabTasks.GetLongestWords(secondMessage, 3);
            Console.WriteLine($"The 3 longest words: {longestWords}");
        }

        /*
         * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
           Например: badc являются перестановкой abcd.
         */
        public void TaskThree()
        {
            Console.Write("Enter the original string: ");
            var originalString = Console.ReadLine();

            Console.Write("Enter the shuffled string: ");
            var shuffledString = Console.ReadLine();

            var result = LabTasks.IsStringValueShuffled(originalString, shuffledString);

            Console.WriteLine($"One string is a permutation of another: {result}");
        }
    }
}
