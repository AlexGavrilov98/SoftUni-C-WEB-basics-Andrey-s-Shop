using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Andreys.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        public Category Category { get; set; }

        public Gender Gender { get; set; }
    }
}

//
//· Has a Category – an Enum – option between (Shirt, Denim, Shorts, Jacket) (required)
//
//· Has a Gender – an Enum – option between (Male and Female) (required)
