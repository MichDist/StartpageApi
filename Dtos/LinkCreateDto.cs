using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Dtos
{
    public class LinkCreateDto
    {
        //public int id { get; set; }

        public string hyper_link { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int important { get; set; }

        public string image_path { get; set; }

        public User user_id { get; set; }

        public Group group { get; set; }
    }
}
