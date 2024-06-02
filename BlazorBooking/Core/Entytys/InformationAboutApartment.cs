using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entytys
{
    public class InformationAboutApartment : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DateTime { get; set; }
        public string City { get; set; }
        public int NumberOfKlient { get; set; }
        public Guid? ApartamentId { get; set; }
        public virtual Apartaments? Apartament { get; set; }


    }
}
