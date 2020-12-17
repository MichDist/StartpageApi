using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Models
{
    public class Group
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string image_path { get; set; }

        public int important { get; set; }

        public User user_id { get; set; }
    }
}
