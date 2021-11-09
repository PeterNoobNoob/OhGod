using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.Domain.ModelDtos
{
    public class MediasDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime? Created { get; set; }

    }
}
