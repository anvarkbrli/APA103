using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.ViewModels.Account
{
    public class LoginVM
    {
        [MinLength(4, ErrorMessage = "Name is too short")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string UsernameOrEmail { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
    }
}
