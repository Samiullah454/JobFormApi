namespace JobFormApi.Dtos
{
    public class SectionDto
    {
        public string Name { get; set; }
        public List<FieldDto>? Fields { get; set; }
    }
}