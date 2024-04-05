using System.ComponentModel.DataAnnotations;

namespace MidtermProject.Models
{
    public class User
    {
        [Key, Required, MinLength(2, ErrorMessage = "Độ dài tối thiều là 2 ký tự")]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password), MinLength(4, ErrorMessage = "Độ dài tối thiều là 4 ký tự")]
        public string Password { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public User() { }
        public User(AppUser appUser)
        {
            UserName = appUser.UserName;
            Password = appUser.PasswordHash;
            Email = appUser.Email;
        }
    }
}
