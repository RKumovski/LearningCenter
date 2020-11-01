namespace KumovskiLearningCenter.Data.Models
{
    using KumovskiLearningCenter.Data.Common.Models;

    public class Resource : BaseDeletableModel<int>
    {
        public int LectureId { get; set; }

        public virtual Lecture Lecture { get; set; }

        public string Path { get; set; }

        public string Type { get; set; }
    }
}
