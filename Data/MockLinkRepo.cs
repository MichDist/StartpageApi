using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public class MockLinkRepo : ILinkRepo
    {
        Link ILinkRepo.GetLinkById(int id)
        {
            return new Link { id = 0, Name = "Test Link", Description = "Ein Test", HyperLink = "LINK", ImageId = 0, Clicks = 2, Important = 1 };
        }

        IEnumerable<Link> ILinkRepo.GetLinks()
        {
            var Links = new List<Link>
            {
                new Link { id = 0, Name = "Test Link0", Description = "Ein Test", HyperLink = "LINK", ImageId = 0, Clicks = 2, Important = 1 },
                new Link { id = 1, Name = "Test Link1", Description = "Ein Test", HyperLink = "LINK", ImageId = 0, Clicks = 2, Important = 0 },
                new Link { id = 2, Name = "Test Link2", Description = "Ein Test", HyperLink = "LINK", ImageId = 0, Clicks = 2, Important = 1 }
        };

            return Links;
        }
    }
}
