using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Entytys
{
    public class Apartaments
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Description { get; set; }

        public string Cost { get; set; }

        public string Adress { get; set; }
        public string Long { get; set; }
        public string Lat { get; set; }

        public string? ImageString { get; set; } = "/img/projects/no_photo.jpg";

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string Raiting { get; set; }

        public string NumberOfApartments { get; set; }

        public bool IsFavorite { get; set; }
        public Guid? IsFovorId { get; set; }
        public Guid? InfoId { get; set; }
        public Guid? UserId { get; set; }
        public virtual InformationAboutApartment? inf { get; set; }
    }
}
