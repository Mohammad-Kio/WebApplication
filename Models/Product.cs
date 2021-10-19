﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}