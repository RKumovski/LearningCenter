namespace KumovskiLearningCenter.Data.Models
{
    using KumovskiLearningCenter.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
