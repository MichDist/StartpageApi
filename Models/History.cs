using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Models
{
    public class History
    {
        [Key]
        public int id { get; set; }

        public string table { get; set; }

        public string object_name { get; set; }

        public string action { get; set; }

        public DateTime date { get; set; }
    }
}
