using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruYumMVC.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "The field Price must be greater than or equal to 1")]
        public double Price { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Date of Lauch")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfLauch { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Free Delivery")]
        public bool FreeDelivery { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}