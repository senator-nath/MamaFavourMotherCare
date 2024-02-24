namespace MamaFavourMotherCare.Model.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal StarRating { get; set; }
        public string ProductCode { get; set; }
        public string Message { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string CreatedDate { get; set; }
    }
}
