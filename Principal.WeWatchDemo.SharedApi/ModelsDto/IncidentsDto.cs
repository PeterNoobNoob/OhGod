using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.SharedApi.ModelsDto
{
    public partial class IncidentsDto
    {
        public IncidentsDto()
        {
            Evidences = new HashSet<EvidencesDto>();
            Medias = new HashSet<MediasDto>();
            RejectedRequests = new HashSet<RejectedRequestsDto>();
            Reports = new HashSet<ReportsDto>();
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

        public virtual UsersDto Owner { get; set; }
        public virtual ICollection<EvidencesDto> Evidences { get; set; }
        public virtual ICollection<MediasDto> Medias { get; set; }
        public virtual ICollection<RejectedRequestsDto> RejectedRequests { get; set; }
        public virtual ICollection<ReportsDto> Reports { get; set; }
    }
}
