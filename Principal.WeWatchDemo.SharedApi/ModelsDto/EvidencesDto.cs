using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.SharedApi.ModelsDto
{
    public partial class EvidencesDto
    {
        public EvidencesDto()
        {
            Medias = new HashSet<MediasDto>();
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

        public virtual IncidentsDto Incident { get; set; }
        public virtual UsersDto Owner { get; set; }
        public virtual ICollection<MediasDto> Medias { get; set; }
    }
}
