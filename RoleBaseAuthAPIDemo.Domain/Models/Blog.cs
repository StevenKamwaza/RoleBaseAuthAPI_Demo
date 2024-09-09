namespace RoleBaseAuthAPIDemo.Domain.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string BlogBody { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsApproved { get; set; }=false;
    }
}
