using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

namespace WebApi.Models.Leads
{
    public class UpdateRequest
    {
        /*private string _role;*/

        /*[EnumDataType(typeof(Role))]*//*
        public string Role
        {
            get => _role;
            set => _role = replaceEmptyWithNull(value);
        }*/

        public string SesstionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public int CampaignCode { get; set; }
        public string Source { get; set; }
        public string OfferType { get; set; }
        public string Language { get; set; }
        public string Creations { get; set; }
        public string Device { get; set; }
        public int Partner { get; set; }
        public string Referer { get; set; }
        public string Product { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        // helpers

        private string replaceEmptyWithNull(string value)
        {
            // replace empty string with null to make field optional
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}