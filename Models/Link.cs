using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Models
{
    public class Link
    {
        public int id { get; set; }
        public string HyperLink { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Clicks { get; set; }
        public int Important { get; set; }
        public int ImageId { get; set; }
    }
}
