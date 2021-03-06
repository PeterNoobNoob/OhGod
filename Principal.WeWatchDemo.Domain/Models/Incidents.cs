using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.Domain.Models
{
    public partial class Incidents
    {
        public Incidents()
        {
            Evidences = new HashSet<Evidences>();
            Medias = new HashSet<Medias>();
            RejectedRequests = new HashSet<RejectedRequests>();
            Reports = new HashSet<Reports>();

            Evidences = new List<Evidences>();
            Medias = new List<Medias>();
            RejectedRequests = new List<RejectedRequests>();
            Reports = new List<Reports>();

            Owner = new Users();

        }

        public int Id { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsOwnerVictim { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Users Owner { get; set; }
        public virtual ICollection<Evidences> Evidences { get; set; }
        public virtual ICollection<Medias> Medias { get; set; }
        public virtual ICollection<RejectedRequests> RejectedRequests { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
