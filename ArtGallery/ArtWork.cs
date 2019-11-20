using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery
{
    public class ArtWork
    {
        public int Id{ get; set; }

        [Required, StringLength(30, MinimumLength=4)]
        public string Name { get; set; }

        [Required, Range(2,double.MaxValue)]
        public double Price { get; set; }

        [Required, Display(Name= "Category")]
        public string Category { get; set; }

        [Required]
        public double Size { get; set; }

        [Required, Display(Name ="Status")]
        public string Status { get; set; }

    }
}