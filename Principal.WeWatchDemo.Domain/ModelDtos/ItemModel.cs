using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    class ItemModel
    {
        // Common properties for both Incident and Evidence
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        // Incident specific:
        public string Type { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsOwnerVictim { get; set; }

        //public virtual Users Owner { get; set; }
        //public virtual ICollection<Evidences> Evidences { get; set; }
        //public virtual ICollection<Medias> Medias { get; set; }
        //public virtual ICollection<RejectedRequests> RejectedRequests { get; set; }
        //public virtual ICollection<Reports> Reports { get; set; }

        //User Info:

        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserDeviceId { get; set; }
        public Guid UserToken { get; set; }
        public string UserForename { get; set; }
        public string UserSurname { get; set; }
        public string UserPhone { get; set; }
        public string UserCity { get; set; }
        public string UserStreet { get; set; }
        public string UserZip { get; set; }
        public DateTime? UserCreated { get; set; }
        public string UserProfilePic { get; set; }
    }
}
