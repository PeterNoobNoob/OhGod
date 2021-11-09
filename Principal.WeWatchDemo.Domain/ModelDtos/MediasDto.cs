using Principal.WeWatchDemo.Domain.responseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    public class MediasDto : BaseResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime? Created { get; set; }

    }
}
