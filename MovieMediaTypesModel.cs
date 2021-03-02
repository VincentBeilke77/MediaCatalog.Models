using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Models
{
    public class MovieMediaTypesModel
    {
        public int MediaTypeId { get; set; }

        [StringLength(25, ErrorMessage = "Media type name can only be 25 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}