namespace KumovskiLearningCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KumovskiLearningCenter.Data.Common.Models;

    public class Account : BaseDeletableModel<string>
    {
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Confirmed = false;
            this.Notes = new HashSet<Note>();
            this.Wallet = new HashSet<WalletItem>();
            this.CoursesAsLecturer = new HashSet<Course>();
            this.CoursesAsStudent = new HashSet<AccountCourse>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public bool Confirmed { get; set; }

        public ICollection<Note> Notes { get; set; }

        public ICollection<WalletItem> Wallet { get; set; }

        public virtual ICollection<Course> CoursesAsLecturer { get; set; }

        public virtual ICollection<AccountCourse> CoursesAsStudent { get; set; }
    }
}
