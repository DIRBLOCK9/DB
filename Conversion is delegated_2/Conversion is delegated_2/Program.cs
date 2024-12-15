using System;

class Program
{
    
    delegate void DayDelegate();

    
    static void Monday()
    {
        Console.WriteLine("Понедiлок: ");
        Console.WriteLine("- Пiдготовка до тижня.");
        Console.WriteLine("- Робота над проектами.");
        Console.WriteLine("- Спорт.");
    }

    static void Tuesday()
    {
        Console.WriteLine("Вiвторок: ");
        Console.WriteLine("- Завершення завдань.");
        Console.WriteLine("- Вiдвiдування зустрiчей.");
        Console.WriteLine("- Читання статей.");
    }

    static void Wednesday()
    {
        Console.WriteLine("Середа: ");
        Console.WriteLine("- Створення звiтiв.");
        Console.WriteLine("- Командна робота.");
        Console.WriteLine("- Вивчення нових технологiй.");
    }

    static void Thursday()
    {
        Console.WriteLine("Четвер: ");
        Console.WriteLine("- Пiдготовка до публiкацiй.");
        Console.WriteLine("- Виконання завдань.");
        Console.WriteLine("- Спiлкування з колегами.");
    }

    static void Friday()
    {
        Console.WriteLine("П'ятниця: ");
        Console.WriteLine("- Завершення тижня.");
        Console.WriteLine("- Перевiрка результатiв.");
        Console.WriteLine("- Вiдпочинок.");
    }

    static void Saturday()
    {
        Console.WriteLine("Субота: ");
        Console.WriteLine("- Вiльний час.");
        Console.WriteLine("- Прогулянки.");
        Console.WriteLine("- Час з родиною.");
    }

    static void Sunday()
    {
        Console.WriteLine("Недiля: ");
        Console.WriteLine("- Релакс.");
        Console.WriteLine("- Планування наступного тижня.");
        Console.WriteLine("- Вiдпочинок.");
    }

    static void Main()
    {
        Console.WriteLine("Введiть номер дня тижня (1 - Понедiлок, 2 - Вiвторок, ..., 7 - Недiля): ");

        
        string input = Console.ReadLine();

        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число.");
            return;
        }

        
        if (!int.TryParse(input, out int dayNumber) || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Невiрне значення. Введiть число вiд 1 до 7.");
            return;
        }

        
        DayDelegate[] weekDays = new DayDelegate[]
        {
            Monday,    
            Tuesday,   
            Wednesday, 
            Thursday,  
            Friday,   
            Saturday,  
            Sunday     
        };

        
        weekDays[dayNumber - 1]();
    }
}
