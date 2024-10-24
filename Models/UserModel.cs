using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aafeben.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "name req")]
        public required string Name {get; set;}

        public required string UserName {get; set;}

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        [Required(ErrorMessage = "pass req")]
        [DataType(DataType.Password)]
        public required string Password {get; set;}

        public string? Bio {get; set;}


        // relations
        public ICollection<BlogModel> Blogs { get; } = new List<BlogModel>();


    }
}