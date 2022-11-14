namespace VE2C5T_SOF_2022231.Models
{
    public class Answer
    {
        public string? Id { get; set; }

        public Answer()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
