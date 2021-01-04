using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public interface ILinkRepo
    {
        bool SaveChanges();

        IEnumerable<Link> GetLinks();
        Link GetLinkById(int id);
        void CreateLink(Link link);
        void UpdateLink(Link link);
    }
}
