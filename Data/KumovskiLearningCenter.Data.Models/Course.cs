namespace KumovskiLearningCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Course : BaseDeletableModel<string>
    {
        public Course()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Lectures = new HashSet<Lecture>();
            this.Students = new HashSet<AccountCourse>();
        }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public string LecturerId { get; set; }

        public virtual Account Lecturer { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }

        public virtual ICollection<AccountCourse> Students { get; set; }
    }
}
