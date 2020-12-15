using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Models
{
    public class Link
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string HyperLink { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int Clicks { get; set; }

        public int Important { get; set; }

        public string ImagePath { get; set; }

        // Later: Groups
    }
}
