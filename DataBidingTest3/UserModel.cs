using System.ComponentModel.DataAnnotations;

namespace DataBidingTest3
{
    public class UserModel
    {
        public UserModel()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Password = "";
        }


        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string Password { get; set; }

    }
}
