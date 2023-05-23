using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace booklu.api.Core.Domain.Models
{
    public class UserLogin
    {
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }

    public class ForgotPassword
    {
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonIgnore]
        public int MyProperty { get; set; }
    }

    public class CodeForgotPassword
    {
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    public class ChangePasswordRequest
    {
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("newPassword")]
        public string NewPassword { get; set; }
    }
}
