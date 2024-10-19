using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: Читання файлу та розбиття рядків
            Console.WriteLine("Завдання 1: Читання файлу та розбиття рядків.");
            string filePath = "data.txt"; // Файл у кореневій папці проекту

            if (File.Exists(filePath))
            {
                Console.WriteLine("Файл знайдено. Обробка даних...");
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length == 4)
                    {
                        string surname = parts[0];
                        string initials = parts[1];
                        int birthYear = int.Parse(parts[2]);
                        decimal salary = decimal.Parse(parts[3]);

                        Console.WriteLine($"Прізвище: {surname}, Ініціали: {initials}, Рік народження: {birthYear}, Оклад: {salary}");
                    }
                    else
                    {
                        Console.WriteLine("Некоректний формат даних в рядку: " + line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не знайдено. Перевірте шлях до файлу.");
            }

            // Завдання 2: Перевизначені методи в класі Document
            Console.WriteLine("\nЗавдання 2: Перевизначені методи в класі Document.");
            Document doc = new Document();
            doc.Print("Книга", "Мистецтво війни");
            doc.Print("Журнал", "Науковий вісник", 150);

            // Завдання 3: Індексатори з лекції 4
            Console.WriteLine("\nЗавдання 3: Індексатори.");
            IndexerExample example = new IndexerExample();
            example[0] = "First";
            example[1] = "Second";
            Console.WriteLine(example[0]); // Виведе "First"
            Console.WriteLine(example[1]); // Виведе "Second"

            // Завдання 4: Індексатори в класі Student
            Console.WriteLine("\nЗавдання 4: Індексатори в класі Student.");
            Student student = new Student();
            student[0] = 85;
            student[1] = 90;
            student[2] = 78;
            student[3] = 88;
            student[4] = 95;
            student[5] = 92;
            student[6] = 80;
            student[7] = 75;
            student[8] = 83;
            student[9] = 91;
            Console.WriteLine("Середній рейтинг студента: " + student.CalculateAverageGrade());

            // Завдання 5: Перевизначення операцій
            Console.WriteLine("\nЗавдання 5: Перевизначення операцій.");
            ComplexNumber num1 = new ComplexNumber(3, 4);
            ComplexNumber num2 = new ComplexNumber(1, 2);
            ComplexNumber result = num1 + num2;
            Console.WriteLine("Результат додавання комплексних чисел: " + result); // Виведе "4 + 6i"
        }
    }

    public class Document
    {
        public virtual void Print(string type, string title)
        {
            Console.WriteLine($"Тип: {type}, Назва: {title}");
        }

        public virtual void Print(string type, string title, int pageCount)
        {
            Console.WriteLine($"Тип: {type}, Назва: {title}, Кількість сторінок: {pageCount}");
        }
    }

    public class IndexerExample
    {
        private string[] elements = new string[5];
        public string this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
    }

    public class Student
    {
        private int[] grades = new int[10]; // Масив оцінок

        public int this[int index]
        {
            get { return grades[index]; }
            set { grades[index] = value; }
        }

        public double CalculateAverageGrade()
        {
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return (double)sum / grades.Length;
        }
    }

    public class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
