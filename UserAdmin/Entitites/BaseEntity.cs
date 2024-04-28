using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdmin.Entitites
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public int Isdeleted { get; set; } = 0;

        public DateTime CreatedDate { get; set; }=DateTime.Now;
    }
}
