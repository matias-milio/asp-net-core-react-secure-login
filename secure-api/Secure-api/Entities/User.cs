using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secure_api.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public byte[] PasswordHash { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public byte[] PasswordSalt { get; set; }
    }
}
