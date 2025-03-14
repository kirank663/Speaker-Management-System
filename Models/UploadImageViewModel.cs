using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CruidPersonalInfo.Models
{
    public class UploadImageViewModel
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile SpeakerPicture { get; set; }
    }
}
