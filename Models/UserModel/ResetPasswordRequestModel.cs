﻿using System.ComponentModel.DataAnnotations;

namespace InternPulse4.Models.UserModel
{
    public class ResetPasswordRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } 
        [Required]
        public string Token { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }
    }
}
