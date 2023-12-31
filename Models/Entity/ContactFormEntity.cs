﻿using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class ContactFormEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}
