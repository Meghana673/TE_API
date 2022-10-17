using System.ComponentModel.DataAnnotations;

namespace TE_API.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }
    }
}
