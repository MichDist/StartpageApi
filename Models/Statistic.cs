using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Models
{
    public class Statistic
    {
        [Key]
        public int id { get; set; }

        public Link link { get; set; }

        public DateTime date { get; set; }
    }
}
