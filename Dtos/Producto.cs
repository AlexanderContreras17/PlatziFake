namespace PlatziFake.Dtos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public List<string> Images { get; set; } = null!;
        public DateTime CreationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CategoryDto Category { get; set; } = null!;
    }
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public DateTime CreationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
