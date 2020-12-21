using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StartpageApi.Data;
using StartpageApi.Dtos;
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
        private readonly IMapper _mapper;

        public LinksController(ILinkRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<LinkReadDto>> GetAllLinks()
        {
            var linkItems = _repository.GetLinks();

            return Ok(_mapper.Map<IEnumerable<LinkReadDto>>(linkItems));
        }

        [HttpGet("{id}", Name ="GetLinkById")]
        public ActionResult <LinkReadDto> GetLinkById(int id)
        {
            var linkItem = _repository.GetLinkById(id);

            if(linkItem != null)
            {
                return Ok(_mapper.Map<LinkReadDto>(linkItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<LinkReadDto> CreateLink(LinkCreateDto linkCreateDto)
        {
            // Validation???

            var linkModel = _mapper.Map<Link>(linkCreateDto);
            _repository.CreateLink(linkModel);
            _repository.SaveChanges();

            var linkReadDto = _mapper.Map<LinkReadDto>(linkModel);

            return CreatedAtRoute(nameof(GetLinkById), new { id = linkReadDto.id }, linkReadDto);
        }
    }
}
