using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.Domain.Models
{
    public partial class Medias
    {
        public int Id { get; set; }
        public int? EvidenceId { get; set; }
        public int? IncidentId { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime? Created { get; set; }

        public virtual Evidences Evidence { get; set; }
        public virtual Incidents Incident { get; set; }
    }
}
