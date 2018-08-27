using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [MinLength(5)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [MinLength(5)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}
