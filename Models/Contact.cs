using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public DateTime InsertionDate { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}