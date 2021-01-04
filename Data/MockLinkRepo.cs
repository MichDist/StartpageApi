using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public class MockLinkRepo : ILinkRepo
    {
        public void CreateLink(Link link)
        {
            throw new NotImplementedException();
        }

        public Link GetLinkById(int id)
        {
            return new Link { id = 0, name = "Test Link", description = "Ein Test", hyper_link = "LINK", image_path = "Test", important = 1 };
        }

        public IEnumerable<Link> GetLinks()
        {
            var Links = new List<Link>
            {
                new Link { id = 0, name = "Test Link0", description = "Ein Test", hyper_link = "LINK", image_path = "Test", important = 1 },
                new Link { id = 1, name = "Test Link1", description = "Ein Test", hyper_link = "LINK", image_path = "Test", important = 0 },
                new Link { id = 2, name = "Test Link2", description = "Ein Test", hyper_link = "LINK", image_path = "Test", important = 1 }
        };

            return Links;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateLink(Link link)
        {
            throw new NotImplementedException();
        }
    }
}
