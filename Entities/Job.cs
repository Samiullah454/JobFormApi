namespace JobFormApi.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobType { get; set; }
        public DateTime Expiry { get; set; }
        public int JobDuration { get; set; }

        public List<Section>? Sections { get; set; }
    }
}