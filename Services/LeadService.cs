using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Leads;

namespace WebApi.Services
{
    public interface ILeadService
    {
        LeadResponse GetById(int id);
        LeadResponse Create(CreateRequest model);
        LeadResponse Update(int id, UpdateRequest model);
        void Delete(int id);
    }

    public class LeadService : ILeadService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;


        public LeadService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public LeadResponse GetById(int id)
        {
            var lead = getLead(id);
            return _mapper.Map<LeadResponse>(lead);
        }

        public LeadResponse Create(CreateRequest model)
        {
            // validate
            /*if (_context.Leads.Any(x => x.Email == model.Email))
                throw new AppException($"Email '{model.Email}' is already registered");*/

            // map model to new account object
            var lead = _mapper.Map<Lead>(model);
            lead.Created = DateTime.UtcNow;

            // save lead
            _context.Leads.Add(lead);
            _context.SaveChanges();

            return _mapper.Map<LeadResponse>(lead);
        }

        public LeadResponse Update(int id, UpdateRequest model)
        {
            var lead = getLead(id);

            /*// validate
            if (account.Email != model.Email && _context.Accounts.Any(x => x.Email == model.Email))
                throw new AppException($"Email '{model.Email}' is already taken");*/



            // copy model to account and save
            _mapper.Map(model, lead);
            lead.Updated = DateTime.UtcNow;
            _context.Leads.Update(lead);
            _context.SaveChanges();

            return _mapper.Map<LeadResponse>(lead);
        }

        public void Delete(int id)
        {
            var lead = getLead(id);
            _context.Leads.Remove(lead);
            _context.SaveChanges();
        }

        // helper methods

        private Lead getLead(int id)
        {
            var lead = _context.Leads.Find(id);
            if (lead == null) throw new KeyNotFoundException("Lead not found");
            return lead;
        }
    }
}

