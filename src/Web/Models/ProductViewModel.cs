namespace Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? PictureUrl { get; set; }
        public decimal Price { get; set; }

    }
}
