using System;
using System.Collections.Generic;
using System.IO;

namespace Laboratory_work
{
    public enum BankAccountType
    {
        Savings_account = 1,
        Current_account
    }
    class BankAccount
    {
        private Queue<BankTransaction> list_checks = new Queue<BankTransaction>();
        private ulong account_number;
        private double account_balance;
        private BankAccountType bank_account_type;
        private static ulong number_of_bank_accounts = 0;

        public ulong AccountNumber
        {
            get
            {
                return account_number;
            }
        }
        public double AccountBalance
        {
            get
            {
                return account_balance;
            }
        }
        public BankAccountType AccountType
        {
            get
            {
                return bank_account_type;
            }
        }
        public BankAccount()
        {
            GenerateAnAccountNumber();
            account_number = number_of_bank_accounts;
            account_balance = 0;
            bank_account_type = BankAccountType.Current_account;
        }
        public BankAccount(double account_balance)
        {
            GenerateAnAccountNumber();
            account_number = number_of_bank_accounts;
            this.account_balance = account_balance;
            bank_account_type = BankAccountType.Current_account;
        }
        public BankAccount(double account_balance, BankAccountType bank_account_type)
        {
            GenerateAnAccountNumber();
            account_number = number_of_bank_accounts;
            this.account_balance = account_balance;
            this.bank_account_type = bank_account_type;
        }

        public void GenerateAnAccountNumber()
        {
            number_of_bank_accounts++;
        }

        public bool WithdrawMoneyFromAccount(double withdrawal_amount)
        {
            if (account_balance - withdrawal_amount > 0 && withdrawal_amount > 0)
            {

                account_balance -= withdrawal_amount;
                BankTransaction bank_transaction = new BankTransaction(-withdrawal_amount);
                list_checks.Enqueue(bank_transaction);
                return true;
            }

            return false;
        }

        public void PutMoneyIntoAccount(double deposited_amount)
        {
            if (deposited_amount > 0)
            {
                account_balance += deposited_amount;
                BankTransaction bank_transaction = new BankTransaction(deposited_amount);
                list_checks.Enqueue(bank_transaction);
            }
            else
            {
                Console.WriteLine("Сумма добавления меньше нуля");
            }
        }
        public void TransferFromAnotherAccount(BankAccount bank_account_debit, double transfer_amount)
        {
            if (bank_account_debit.WithdrawMoneyFromAccount(transfer_amount))
            {
                PutMoneyIntoAccount(transfer_amount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на выбранном счету");
            }
        }
        public void Dispose(BankAccount bank_account)
        {
            for (int i = 0; i < list_checks.Count; i++)
            {
                BankTransaction operation = list_checks.Dequeue();
                if (operation.SummOperation < 0)
                {
                    File.AppendAllText("ProgramFiles/dispose.txt", $"Списание баланса произошло {operation.DateTimeOperation}, на {-operation.SummOperation} рублей".ToString() + "\n");
                }
                else
                {
                    File.AppendAllText("ProgramFiles/dispose.txt", $"Пополнение баланса{operation.DateTimeOperation}, на {operation.SummOperation} рублей".ToString() + "\n");
                }
            }
            GC.SuppressFinalize(bank_account);
        }
    }
}