namespace myHr.application.Common
{
    public class BaseDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
