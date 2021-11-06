using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.Domain.Models
{
    public partial class Evidences
    {
        public Evidences()
        {
            Medias = new HashSet<Medias>();
        }

        public int Id { get; set; }
        public int IncidentId { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Incidents Incident { get; set; }
        public virtual Users Owner { get; set; }
        public virtual ICollection<Medias> Medias { get; set; }
    }
}
