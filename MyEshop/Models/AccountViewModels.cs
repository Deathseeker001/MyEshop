using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
    public class RegisterViewModel
    {
        
        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }
       
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; }
       
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RePassword { get; set; }

    }
    public class LoginViewModel
    {
        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
