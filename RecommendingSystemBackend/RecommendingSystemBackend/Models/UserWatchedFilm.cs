using System;
using System.ComponentModel.DataAnnotations;

namespace RecommendingSystemBackend.Models
{
    public class UserWatchedFilm
    {       
        [Required] 
        public Film Film { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Range(1,10)]
        [Required]
        public int Mark { get; set; }
    }
}