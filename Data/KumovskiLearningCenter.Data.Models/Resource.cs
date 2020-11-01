namespace KumovskiLearningCenter.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Resource : BaseDeletableModel<int>
    {
        public int LectureId { get; set; }

        public virtual Lecture Lecture { get; set; }

        [Required]
        [MaxLength(100)]
        public string Path { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
