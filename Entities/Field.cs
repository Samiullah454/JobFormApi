namespace JobFormApi.Entities
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}