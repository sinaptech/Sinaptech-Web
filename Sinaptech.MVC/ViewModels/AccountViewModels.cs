﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sinaptech.MVC.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "پست الکترونیکی بایستی وارد شود")]
        [EmailAddress(ErrorMessage = "{0} وارد شده معتبر نیست")]
        [Display(Name = "پست الکترونیکی")]
        public string Email { get; set; }

        [Required(ErrorMessage = "کلمه عبور بایستی وارد شود")]
        [StringLength(100, ErrorMessage = "{0} وارد شده باید حداقل {2} کاراکتر باشد.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        //Mehdi age proje ro run koni beri vase register kardane karbar va password ro bezani 123456 ebhet peyghame englisi mide ino
        //chetori mishe farsish kard?
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار آن یکسان نیست.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "نام بایستی وارد شود")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی بایستی وارد شود")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
