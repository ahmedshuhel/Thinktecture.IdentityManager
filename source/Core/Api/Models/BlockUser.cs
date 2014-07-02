using System.ComponentModel.DataAnnotations;

namespace Thinktecture.IdentityManager.Api.Models
{
    public class BlockUser
    {
        [Required]
        public string Subject { get; set; }
    }
}