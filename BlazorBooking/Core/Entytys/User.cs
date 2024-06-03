using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entytys
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public int SurName { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Apartaments> Apartament { get; set; }

    }
}
