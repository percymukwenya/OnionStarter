namespace Application.DTOs.Product
{
    public interface IProductDto
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
    }
}
