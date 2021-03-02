using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Models
{
    public class RatingModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Rating name can only be 25 characters.")]
        public string Name { get; set; }

        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}