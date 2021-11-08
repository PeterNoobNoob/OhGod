using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    class ItemModel
    {
        // common for both Incident and Evidence
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
    }
}
