using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Dtos
{
    public class LinkUpdateDto
    {
        [Required]
        public string hyper_link { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        public int important { get; set; }

        public string image_path { get; set; }

        public User user_id { get; set; }

        public Group group { get; set; }
    }
}
