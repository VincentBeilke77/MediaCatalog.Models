using System.ComponentModel.DataAnnotations;

namespace MediaCatalog.Models
{
    public class MovieStudiosModel
    {
        public int StudioId { get; set; }

        [StringLength(25, ErrorMessage = "Studio name can only be 25 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}