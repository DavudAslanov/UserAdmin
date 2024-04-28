using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdmin.Entitites
{
    public class User:BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public byte Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int RolesID { get; set; } = 1;

    }
}
