using System;

namespace Laboratory_work
{
    internal class BankTransaction
    {
        private readonly DateTime date_time_operation;
        private readonly double summ_operation;
        public DateTime DateTimeOperation
        {
            get
            {
                return date_time_operation;
            }
        }

        public double SummOperation
        {
            get
            {
                return summ_operation;
            }
        }
        public BankTransaction(double summ)
        {
            date_time_operation = DateTime.Now;
            summ_operation = summ;
        }

    }
}
