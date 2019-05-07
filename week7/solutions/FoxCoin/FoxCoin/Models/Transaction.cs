using System;

namespace FoxCoin.Models
{
    public class Transaction
    {
        public long TransactionId { get; set; }

        public UserAccount Sender { get; set; }

        public long? SenderId { get; set; }

        public UserAccount Receiver { get; set; }

        public long? ReceiverId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
