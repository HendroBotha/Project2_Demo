using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project2_Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateTimeCreated { get; set; } = DateTime.Now;

    }
}
