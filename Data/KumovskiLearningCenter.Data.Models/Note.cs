namespace KumovskiLearningCenter.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Note : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(500)]
        public string Content { get; set; }
    }
}
