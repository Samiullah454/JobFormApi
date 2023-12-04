namespace JobFormApi.Dtos
{
    public class JobDto
    {
        public string JobTitle { get; set; }
        public string JobType { get; set; }
        public DateTime Expiry { get; set; }
        public int JobDuration { get; set; }
        public List<SectionDto>? Sections { get; set; }
    }
}