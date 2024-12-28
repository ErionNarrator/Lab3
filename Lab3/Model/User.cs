using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
