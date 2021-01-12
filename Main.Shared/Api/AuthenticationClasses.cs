using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Main.Shared.Api
{
    public class AuthenticationOutput
    {
        public string AccessToken { get; set; }
        public string EncryptedAccessToken { get; set; }
        public int ExpireInSeconds { get; set; }
        public int UserId { get; set; }
    }

    public class AuthenticationInput
    {
        [Required]
        public string UserNameOrEmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberClient { get; set; } = false;
    }

    public class RegistrationInput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }


}
