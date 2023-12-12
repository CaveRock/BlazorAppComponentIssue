using System.ComponentModel.DataAnnotations;

namespace BlazorAppComponentIssue.Client
{
    public class FormModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Name { get; set; }
    }
}
