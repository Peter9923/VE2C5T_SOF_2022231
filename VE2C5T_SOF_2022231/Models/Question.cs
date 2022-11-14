namespace VE2C5T_SOF_2022231.Models
{
    public class Question
    {
        public string? Id { get; set; }

        public Question()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
