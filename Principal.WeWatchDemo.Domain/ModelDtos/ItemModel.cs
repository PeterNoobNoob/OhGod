using Principal.WeWatchDemo.Domain.ModelDtos.Enums;
using Principal.WeWatchDemo.Domain.responseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    public class ItemModel : BaseResponseModel
    {
        // Common properties for both Incident and Evidence:
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        // Incident specific:
        public IncidentTypes Type { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsOwnerVictim { get; set; }

        // Evidence specific:
        public int? IncidentId { get; set; }
        /// <summary>
        /// Auxuliary property to easy differ Incident from Evidence
        /// </summary>
        public bool? IsIncident { get; set; }

        public List<MediasDto> Medias { get; set; }

        //Info about user that is associated with the incident:
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserDeviceId { get; set; }
        public Guid UserToken { get; set; }
        public string UserForename { get; set; }
        public string UserSurname { get; set; }
        public string UserPhone { get; set; }
        public string UserCity { get; set; }
        public string UserStreet { get; set; }
        public string UserZip { get; set; }
        public DateTime? UserCreated { get; set; }
        /// <summary>
        /// Here will be stored link to blob storage
        /// </summary>
        public string UserProfilePic { get; set; } 
    }
}
