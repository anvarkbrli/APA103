using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.ViewModels.Account
{
    public class RegisterVM
    {
        [MinLength(3,ErrorMessage ="Name is too short")]
        [MaxLength(15, ErrorMessage ="Name is too long")]
        public string Name { get; set; }
        [MinLength(3, ErrorMessage = "Surname is too short")]
        [MaxLength(15, ErrorMessage = "Surname is too long")]
        public string Surname { get; set; }
        [MinLength(8, ErrorMessage = "Username is too short")]
        [MaxLength(20, ErrorMessage = "Username is too long")]
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
