using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Lead
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }
        public string City { get; set; } // [a-Z]
        public string PostCode { get; set; }
        public string Phone { get; set; } // 48 + 9 cyfr, poprawna waludacja dla włoszech
        public string Email { get; set; }
        public string Region { get; set; } // PL, hard coded o jezyku strony
        public int CampaignCode { get; set; } // 1 - 16
        public string Source { get; set; } // url strony link do reklamy 
        public string OfferType { get; set; } // nie wiadomo po co jest 
        public string Language { get; set; } // przeglądarka
        public string Creations { get; set; } // numer kreacji,  numer baneru nazwa 
        public string Device { get; set; } // pytanie do leadów [mobile, tablet, desktop]
        public int Partner { get; set; } // czego się tu spodziewać 1 - 1000 |
        //ad sense google -> referer wp.pl dodać referera
        public string Referer { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        //product info
        public string Product { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

    }
}
