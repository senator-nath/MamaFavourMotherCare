namespace MamaFavourMotherCare.Model.Dtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public string Message { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}
