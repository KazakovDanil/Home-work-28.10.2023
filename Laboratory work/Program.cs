using System;

namespace Laboratory_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 9.1
            Console.WriteLine("Упражнение 9.1");
            Console.WriteLine("В этом упражнении нужно переделать класс банковский счет, поля которого должны заполняться конструктором, а не методом");
            BankAccount bank_account_1 = new BankAccount();
            Console.WriteLine($"Счет под номером {bank_account_1.AccountNumber} и типом {bank_account_1.AccountType} содержит {bank_account_1.AccountBalance} рублей");
            BankAccount bank_account_2 = new BankAccount(200000.123);
            Console.WriteLine($"Счет под номером {bank_account_2.AccountNumber} и типом {bank_account_2.AccountType} содержит {bank_account_2.AccountBalance} рублей");
            BankAccount bank_account_3 = new BankAccount(2000001212.543, BankAccountType.Savings_account);
            Console.WriteLine($"Счет под номером {bank_account_3.AccountNumber} и типом {bank_account_3.AccountType} содержит {bank_account_3.AccountBalance} рублей");
            // Упражнение 9.2
            Console.WriteLine("Упражнение 9.2");
            Console.WriteLine("Создать новый класс BankTransaction, который будет хранить информацию о всех банковских операциях.");
            BankAccount bank_account_4 = new BankAccount(1000000, BankAccountType.Current_account);
            bank_account_4.PutMoneyIntoAccount(24000);
            bank_account_4.PutMoneyIntoAccount(100.24);
            bank_account_4.WithdrawMoneyFromAccount(200000);
            Console.WriteLine($"Счет под номером {bank_account_4.AccountNumber} и типом {bank_account_4.AccountType} содержит {bank_account_4.AccountBalance} рублей");
            // Упражнение 9.3
            Console.WriteLine("Упражнение 9.3");
            Console.WriteLine("В класс счета банка добавить метод записи всех элементов BankTransaction");
            BankAccount bank_account_5 = new BankAccount(500000, BankAccountType.Current_account);
            bank_account_5.PutMoneyIntoAccount(24230);
            bank_account_5.PutMoneyIntoAccount(50.24);
            bank_account_5.WithdrawMoneyFromAccount(2130);
            bank_account_5.Dispose(bank_account_5);
            Console.WriteLine($"Счет под номером {bank_account_5.AccountNumber} и типом {bank_account_5.AccountType} содержит {bank_account_5.AccountBalance} рублей");
            // Домашнее задание 9.1
            Console.WriteLine("Домашнее задание 9.1");
            Console.WriteLine("Переделать класс song, добавить конструкторы");
            Song song_1 = new Song("Перемен", "Виктор Цой");
            Song song_2 = new Song("Бездельник", "Виктор Цой");
            Console.WriteLine(song_1.Title, song_2.Title);
            Console.ReadKey();
        }
    }
}
