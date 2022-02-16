using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Leads;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeadsController : BaseController
    {
        private readonly ILeadService _leadService;
        private readonly IMapper _mapper;

        public LeadsController(
           ILeadService leadService,
           IMapper mapper)
        {
            _leadService = leadService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<LeadResponse> Create(CreateRequest model)
        {
            var account = _leadService.Create(model);
            return Ok(account);
        }

        [HttpGet("{id:int}")]
        public ActionResult<LeadResponse> GetById(int id)
        {

            var account = _leadService.GetById(id);
            return Ok(account);
        }

        [HttpPut("{id:int}")]
        public ActionResult<LeadResponse> Update(int id, UpdateRequest model)
        {
            var account = _leadService.Update(id, model);
            return Ok(account);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _leadService.Delete(id);
            return Ok(new { message = "Lead deleted successfully" });
        }
    }
}
