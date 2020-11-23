using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public interface ILinkRepo
    {
        IEnumerable<Link> GetLinks();
        Link GetLinkById(int id);
    }
}
