using System.ComponentModel.DataAnnotations;

namespace assignment1.Models
{

    public class GenreValidation : ValidationAttribute
    {
        private readonly string[] validGenres = { "Action", "Adventure", "Racing" };

        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return false;
            }

            var genre = value.ToString();
            return validGenres.Contains(genre, StringComparer.OrdinalIgnoreCase);
        }
    }

    public class ReleaseYearValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var currentYear = DateTime.Now.Year;
            var releaseYear = value;

            return (int?)releaseYear >= (currentYear - 3);

        }

    }

    public class PurchaseDateValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var purchaseDate = Convert.ToDateTime(value);
            return purchaseDate <= DateTime.Now;
        }
    }
}

