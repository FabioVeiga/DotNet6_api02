using System.ComponentModel.DataAnnotations;

namespace api02.Repositories
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
    }
}