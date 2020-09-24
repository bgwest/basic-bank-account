using System;

namespace oopintrotoclasses
{
    class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; }

        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
