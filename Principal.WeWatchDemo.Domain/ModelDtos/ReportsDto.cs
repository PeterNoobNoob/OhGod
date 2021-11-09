using Principal.WeWatchDemo.Domain.responseModels;
using System;
using System.Collections.Generic;

namespace Principal.WeWatchDemo.Domain.Models
{
    public partial class ReportsDto: BaseResponseModel
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public int EvidenceId { get; set; }
        public string HttpLink { get; set; }

        public virtual Incidents Incident { get; set; }
    }
}
