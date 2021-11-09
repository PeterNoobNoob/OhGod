using Principal.WeWatchDemo.Domain.responseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    public class ItemGridModel : BaseResponseModel
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ProfilePic { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsIncident { get; set; }
        public int? AssociatedEvidenceCount { get; set; }

        public ItemModel AssociatedItemModel { get; set; }

    }
}
