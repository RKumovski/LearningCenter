namespace KumovskiLearningCenter.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Lecture : BaseDeletableModel<int>
    {
        public Lecture()
        {
            this.Resources = new HashSet<Resource>();
        }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public string CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}
