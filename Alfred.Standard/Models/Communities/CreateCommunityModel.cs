using System.ComponentModel.DataAnnotations;

namespace Alfred.Standard.Models.Communities
{
    public class CreateCommunityModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
