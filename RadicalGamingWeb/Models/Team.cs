﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RadicalGamingWeb.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Member Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
