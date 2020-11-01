namespace KumovskiLearningCenter.Data.Models
{
    using KumovskiLearningCenter.Data.Common.Models;

    public class AccountCourse : BaseDeletableModel<int>
    {
        public string AccountId { get; set; }

        public Account Account { get; set; }

        public string CourseId { get; set; }

        public Course Course { get; set; }
    }
}
