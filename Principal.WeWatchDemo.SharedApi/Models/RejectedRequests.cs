using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.SharedApi.Models
{
    public partial class RejectedRequests
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int IncidentId { get; set; }
        public DateTime? Created { get; set; }

        public virtual Incidents Incident { get; set; }
        public virtual Users Owner { get; set; }
    }
}
