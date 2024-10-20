using System;

namespace BankAndDocuments
{
    // Інтерфейс з двома методами
    public interface IRequisites
    {
        string GetRequisites();
        decimal GetCost();
        string Author { get; set; }
        DateTime Date { get; set; }
    }

    // Базовий клас Документ
    public abstract class Document : IRequisites
    {
        public abstract string GetRequisites();
        public abstract decimal GetCost();
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }

    // Клас Квитанція
    public class Receipt : Document
    {
        public override string GetRequisites()
        {
            return "Реквізити Квитанції: Автор: " + Author + ", Дата: " + Date.ToShortDateString();
        }

        public override decimal GetCost()
        {
            return 50.00m; // Приклад вартості
        }
    }

    // Клас Накладна
    public class Invoice : Document
    {
        public override string GetRequisites()
        {
            return "Реквізити Накладної: Автор: " + Author + ", Дата: " + Date.ToShortDateString();
        }

        public override decimal GetCost()
        {
            return 100.00m; // Приклад вартості
        }
    }

    // Ієрархія класів для банківських рахунків
    public interface IBankAccount
    {
        void NewAccount();
        void DeleteAccount();
    }

    public abstract class BankAccount : IBankAccount
    {
        public abstract void NewAccount();
        public abstract void DeleteAccount();
    }

    public class CurrentAccount : BankAccount
    {
        public override void NewAccount()
        {
            Console.WriteLine("Новий Поточний рахунок створено.");
        }

        public override void DeleteAccount()
        {
            Console.WriteLine("Поточний рахунок видалено.");
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Поновлення рахунку на {amount} грн.");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Зняття {amount} грн з рахунку.");
        }
    }

    public class SavingsAccount : BankAccount
    {
        public override void NewAccount()
        {
            Console.WriteLine("Новий Депозитний рахунок створено.");
        }

        public override void DeleteAccount()
        {
            Console.WriteLine("Депозитний рахунок видалено.");
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Поновлення рахунку на {amount} грн.");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Зняття {amount} грн з рахунку.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            Console.WriteLine("Завдання 1: Квитанція та Накладна");
            Receipt receipt = new Receipt { Author = "Іванов І.I.", Date = DateTime.Now };
            Console.WriteLine(receipt.GetRequisites());
            Console.WriteLine($"Вартість Квитанції: {receipt.GetCost()} грн");

            Invoice invoice = new Invoice { Author = "Петров П.П.", Date = DateTime.Now };
            Console.WriteLine(invoice.GetRequisites());
            Console.WriteLine($"Вартість Накладної: {invoice.GetCost()} грн");

            // Завдання 3: Робота з банківськими рахунками
            Console.WriteLine("\nЗавдання 3: Робота з банківськими рахунками");
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.NewAccount();
            currentAccount.Deposit(1000);
            currentAccount.Withdraw(500);
            currentAccount.DeleteAccount();

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.NewAccount();
            savingsAccount.Deposit(2000);
            savingsAccount.Withdraw(1500);
            savingsAccount.DeleteAccount();

            Console.ReadLine();
        }
    }
}
