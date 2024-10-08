using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy.Models
{
    public class CredentialUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
