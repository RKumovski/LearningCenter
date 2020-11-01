namespace KumovskiLearningCenter.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using KumovskiLearningCenter.Data.Common.Models;

    public class WalletItem : BaseDeletableModel<int>
    {
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }

        public bool IsMainCurrency { get; set; }

        [InverseProperty("Sender")]
        public ICollection<Transaction> TransactionsSent { get; set; }

        [InverseProperty("Receiver")]
        public ICollection<Transaction> TransactionsReceived { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        public decimal Amount { get; set; }
    }
}
