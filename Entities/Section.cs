namespace JobFormApi.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }

        public List<Field> Fields { get; set; }
    }
}