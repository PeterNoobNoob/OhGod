using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.SharedApi.ModelsDto
{
    public partial class RejectedRequestsDto
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int IncidentId { get; set; }
        public DateTime? Created { get; set; }

        public virtual IncidentsDto Incident { get; set; }
        public virtual UsersDto Owner { get; set; }
    }
}
