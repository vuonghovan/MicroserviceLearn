﻿using System.ComponentModel.DataAnnotations;

namespace PlaformService.Dtos
{
    public class PlatformReadDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}
