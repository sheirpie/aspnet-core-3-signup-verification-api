using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Leads;

namespace WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        // mappings between model and entity objects
        public AutoMapperProfile()
        {
            CreateMap<Lead, LeadResponse>();

            CreateMap<CreateRequest, Lead>();

            CreateMap<UpdateRequest, Lead>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                     /*   // ignore null role
                        if (x.DestinationMember.Name == "Role" && src.Role == null) return false;*/

                        return true;
                    }
                ));
        }
    }
}