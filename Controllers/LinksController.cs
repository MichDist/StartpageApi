using Microsoft.AspNetCore.Mvc;
using StartpageApi.Data;
using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Controllers
{
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly ILinkRepo _repository;

        public LinksController(ILinkRepo repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<Link>> GetAllLinks()
        {
            var linkItems = _repository.GetLinks();

            return Ok(linkItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Link> GetLinkById(int id)
        {
            var linkItem = _repository.GetLinkById(id);

            return Ok(linkItem);
        }
    }


}
