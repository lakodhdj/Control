using System;

namespace Control
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Сколько заданий выполнил студент? ");
            if (int.TryParse(Console.ReadLine(), out int taskCount) && taskCount >= 0)
            {
                int totalScore = taskCount * 12;
                string grade = GetGrade(totalScore);

                Console.WriteLine($"\nСтудент выполнил {taskCount} заданий.");
                Console.WriteLine($"Набрано баллов: {totalScore}");
                Console.WriteLine($"Итоговая оценка: {grade}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }

        public static string GetGrade(int totalScore)
        {
            if (totalScore >= 90) return "5";
            if (totalScore >= 75) return "4";
            if (totalScore >= 60) return "3";
            if (totalScore >= 40) return "2";
            return "1";
        }
    }
}
