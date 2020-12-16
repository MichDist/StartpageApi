using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public class SqlStartpageRepo : ILinkRepo
    {
        private readonly StartpageContext _context;

        public SqlStartpageRepo(StartpageContext context)
        {
            _context = context;
        }

        public Link GetLinkById(int id)
        {
            return _context.Links.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Link> GetLinks()
        {
            return _context.Links.ToList();
        }
    }
}
