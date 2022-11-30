using System.ComponentModel.DataAnnotations;

namespace api02.Repositories
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        //Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}