using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entytys
{
    public class ServiceProviderr : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Name { get; set; }
        public int Surname { get; set; }
        public int Email { get; set; }
        public int Phone { get; set; }
        public int BankCard { get; set; }
        public virtual ICollection<Apartaments> Apartament { get; set; }
    }
}
