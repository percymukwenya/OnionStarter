namespace Application.DTOs.Product
{
    public class CreateProductDto : IProductDto
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
    }
}
