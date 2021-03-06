using Microsoft.Build.Framework;

namespace Alfred.Models.Communities
{
    public class CreateCommunityModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
