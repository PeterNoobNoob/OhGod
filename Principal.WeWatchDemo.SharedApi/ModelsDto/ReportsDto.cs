using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.SharedApi.ModelsDto
{
    public partial class ReportsDto
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public string HttpLink { get; set; }

        public virtual IncidentsDto Incident { get; set; }
    }
}
