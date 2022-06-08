using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVCCore6.Models
{
    public class Contact
    {
        //public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Email address is not correct.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please select your subject.")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Please enter your message.")]
        [MinLength(3, ErrorMessage = "The minimum message length is 3 characters")]
        [MaxLength(250, ErrorMessage = "The maximum message length is 250 characters")]
        public string? Message { get; set; }

        public SelectList? lst_Subjects { get; set; }

    }
}
