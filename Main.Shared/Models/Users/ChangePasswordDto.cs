using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Shared.Models.Users
{
    public class ChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        [StringLength(30)]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string CofirmPassword { get; set; }
    }
}
