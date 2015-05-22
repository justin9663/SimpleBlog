using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Passwod { get; set; }
    }
}