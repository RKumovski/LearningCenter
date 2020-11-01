namespace KumovskiLearningCenter.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Transaction : BaseDeletableModel<int>
    {
        public int SenderId { get; set; }

        public WalletItem Sender { get; set; }

        public int ReceiverId { get; set; }

        public WalletItem Receiver { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        public decimal Amount { get; set; }
    }
}
