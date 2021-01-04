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

        public void CreateLink(Link link)
        {
            if(link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            _context.Links.Add(link);
        }

        public Link GetLinkById(int id)
        {
            return _context.Links.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Link> GetLinks()
        {
            return _context.Links.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateLink(Link link)
        {
            // DbContext does it
        }
    }
}
