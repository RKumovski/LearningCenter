namespace KumovskiLearningCenter.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Currency : BaseDeletableModel<int>
    {
        public Currency()
        {
            this.WalletItems = new HashSet<WalletItem>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string Tag { get; set; }

        public ICollection<WalletItem> WalletItems { get; set; }
    }
}
