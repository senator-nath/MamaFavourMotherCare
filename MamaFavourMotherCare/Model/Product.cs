using System.ComponentModel.DataAnnotations;

namespace MamaFavourMotherCare.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal StarRating { get; set; }
        public string CreatedDate { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string? ProfileImageUrl { get; set; }

    }
}
