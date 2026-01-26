namespace SGF.DTO
{
    public class RevenueCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }

    public class RevenueCategoryByDeleteDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
