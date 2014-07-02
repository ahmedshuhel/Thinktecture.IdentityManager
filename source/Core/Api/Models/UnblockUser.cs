using System.ComponentModel.DataAnnotations;

namespace Thinktecture.IdentityManager.Api.Models
{
    public class UnblockUser
    {
        [Required]
        public string Subject { get; set; }
    }
}