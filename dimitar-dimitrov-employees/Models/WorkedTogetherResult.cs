namespace dimitar_dimitrov_employees.Models
{
    public class WorkedTogetherResult
    {
        public int ProjectId { get; set; }
        public int Employee1Id { get; set; }
        public int Employee2Id { get; set; }
        public TimeSpan Duration;
    }
}
