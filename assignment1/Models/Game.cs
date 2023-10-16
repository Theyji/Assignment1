using System.ComponentModel.DataAnnotations;

namespace assignment1.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Developer { get; set; } = string.Empty;

        [Required]
        [GenreValidation(ErrorMessage = "Selection must be from Action, Adventure or Sport Genre")]
        public string Genre { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Release Year")]
        [ReleaseYearValidation]
        public int ReleaseYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        [PurchaseDateValidation(ErrorMessage = "Purchase Date can't be in future.")]
        public DateTime? PurchaseDate { get; set; }

        [Range(1, 100)]
        public int Rating { get; set; }
    }
}
